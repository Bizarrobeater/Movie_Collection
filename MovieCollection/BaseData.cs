using MovieCollection.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollection
{
    class MovieData
    {
        private string dim_table_name;
        private string movie_table_name;
        private string movie_data_id;

        public string Dim_table_name { get => dim_table_name; set => dim_table_name = value; }
        public string Movie_table_name { get => movie_table_name; set => movie_table_name = value; }
        public string Movie_data_id { get => movie_data_id; set => movie_data_id = value; }

        public MovieData()
        {
            Dim_table_name = null;
            Movie_table_name = null;
        }

        protected virtual Dictionary<string, string> GetIds()
        {
            string select_string = string.Format("SELECT {0}.id " +
                                                " , {0}.{0}_name " +
                                                "FROM dbo.{0} ",
                                                Dim_table_name);

            Dictionary<string, string> data_dict = new ExecuteSQLCommand().GetTwoColumnDataDict(select_string);

            return data_dict;
        }

        //protected virtual void GetMovieDataId(string movie_id)
        //{
        //    Movie_data_id = movie_id;
        //}

        protected string TitleCase(string title, string language)
        {
            return new TitleWords().ConvertToTitleCase(title, language);
        }

        public virtual void AddFullData()
        {

        }

    }
    
    class BaseDataSet : MovieData
    {
        private string imdb_id;
        private string release_date;
        private string imdb_score;
        private string metacritic_score;
        private string run_time;

        public string Imdb_id { get => imdb_id; set => imdb_id = value; }
        public string Release_date { get => release_date; set => release_date = value; }
        public string Imdb_score { get => imdb_score; set => imdb_score = value; }
        public string Metacritic_score { get => metacritic_score; set => metacritic_score = value; }
        public string Run_time { get => run_time; set => run_time = value; }

        public BaseDataSet ()
        {
            Movie_table_name = "Movie_data";
            Dim_table_name = null;

            Movie_data_id = null;

            Imdb_id = null;
            Release_date = null;
            Imdb_score = null;
            Metacritic_score = null;
            Run_time = null;
        }

        public string PrintBaseData()
        {
            return string.Format("Imdb ID: {0}{5}," +
                                "Release Date: {1}{5}" +
                                "Imdb Score: {2}{5}" +
                                "Metacritic Score: {3}{5}" +
                                "Run Time: {4}",
                                Imdb_id, Release_date, Imdb_score, Metacritic_score, Run_time,
                                Environment.NewLine);
        }

        public void InitialiseBaseData(string id, string releasedate, string imdbscore, string metacriticscore, string runtime)
        {
            Imdb_id = id;
            Release_date = releasedate;
            Imdb_score = imdbscore;
            Metacritic_score = metacriticscore;
            Run_time = runtime;
        }

        private void GetMovieDataId(string _ = "")
        {
            string select_string = string.Format("SELECT movie_data.id " +
                                    "FROM dbo.movie_data " +
                                    "WHERE movie_data.imdb_id = '{0}' ",
                                    Imdb_id);

            List<string> select_result_list = new ExecuteSQLCommand().GetOneColumnDataList(select_string);

            Movie_data_id = select_result_list[0];
        }

        public override void AddFullData()
        {
            string insert_string = string.Format("  INSERT INTO dbo.movie_data " +
                                                 "      (imdb_id " +
                                                 "      , release_date " +
                                                 "      , imdb_score " +
                                                 "      , metacritic_score " +
                                                 "      , run_time " +
                                                 "      , date_added) " +
                                                 "  VALUES" +
                                                 "      ('{0}' " +
                                                 "      , '{1}' " +
                                                 "      , {2} " +
                                                 "      , {3} " +
                                                 "      , {4} " +
                                                 "      , '{5}' )",
                                                 Imdb_id,
                                                 Release_date,
                                                 Imdb_score,
                                                 Metacritic_score,
                                                 Run_time,
                                                 DateTime.Today.ToString("yyyy-MM-dd")
                                                 );
            new ExecuteSQLCommand().Execute(insert_string);
            GetMovieDataId();
        }
    }

    class TitleSet : MovieData
    {
        private string title;
        private string language;
        private bool original_language;
        private string id_compare;
        private Dictionary<string, string> language_dict;

        public string Title { get => title; set => title = value; }
        public string Language { get => language; set => language = value; }
        public bool Original_language { get => original_language; set => original_language = value; }
        public string Id_compare { get => id_compare; set => id_compare = value; }
        public Dictionary<string, string> Language_dict { get => language_dict; set => language_dict = value; }

        public TitleSet(string title, string language, bool original_language)
        {
            Dim_table_name = "language";
            Movie_table_name = "movie_title";
            Language = TitleCase(language, "");
            Title = TitleCase(title, Language);
            Original_language = original_language;
            Id_compare = Title + Language;
        }

        public override void AddFullData()
        {
            string original_lang = "0";
            if (Original_language)
            {
                original_lang = "1";
            }
            string insert_string = string.Format("  INSERT INTO dbo.movie_title " +
                                                 "      (movie_data_id " +
                                                 "      , title " +
                                                 "      , language_id " +
                                                 "      , original_title) " +
                                                 "  VALUES" +
                                                 "      ( {0} " +
                                                 "      , '{1}' " +
                                                 "      , {2} " +
                                                 "      , {3} )",
                                                 Movie_data_id,
                                                 Title.Replace("'", "''"),
                                                 Language_dict[Language],
                                                 original_lang);
            new ExecuteSQLCommand().Execute(insert_string);
        }


    }

    class StandardDataSet : MovieData
    {
        private List<string> data_list;
        private Dictionary<string, string> database_dict = new Dictionary<string, string>();
        public List<string> Data_list { get => data_list; set => data_list = value; }
        public Dictionary<string, string> Database_dict { get => database_dict; set => database_dict = value; }

        public StandardDataSet(string dim_table, string movie_table)
        {
            Data_list = new List<string>();
            Dim_table_name = dim_table;
            Movie_table_name = movie_table;
        }

        public void AddNewDataToDimTable()
        {
            UpdateDatabaseDict();
            List<string> new_data = FindNewDataToAdd();
            while (new_data.Count > 0)
            {
                StringBuilder string_builder = new StringBuilder();
                string_builder.AppendFormat("INSERT INTO dbo.{0} " +
                                            "({0}_name) " +
                                            "VALUES ", Dim_table_name);
                foreach(string data in new_data)
                {
                    string_builder.AppendFormat("('{0}'), ", data.Replace("'", "''"));
                }
                string_builder.Length -= 2;

                new ExecuteSQLCommand().Execute(string_builder.ToString());

                UpdateDatabaseDict();
                new_data = FindNewDataToAdd();
                //MessageBox.Show(string_builder.ToString());
            }
        }

        public override void AddFullData()
        {
            if (Data_list.Count == 0)
            {
                return;
            }
            StringBuilder insert_string_builder = new StringBuilder();
            insert_string_builder.AppendFormat("  INSERT INTO dbo.{0} " +
                                       "      (movie_data_id " +
                                       "      , {1}_id ) " +
                                       "  VALUES ",
                                       Movie_table_name,
                                       Dim_table_name);
            foreach (string data in Data_list)
            {
                insert_string_builder.AppendFormat("({0}, {1}), ",
                                           Movie_data_id,
                                           Database_dict[data]);
            }
            insert_string_builder.Length -= 2;
            new ExecuteSQLCommand().Execute(insert_string_builder.ToString());
        }

        private List<string> FindNewDataToAdd()
        {
            List<string> new_data = new List<string>();
            foreach (string data in Data_list)
            {
                if (!Database_dict.ContainsKey(data))
                {
                    new_data.Add(data);
                }
            }
            return new_data;
        }

        public virtual void InitialiseData(List<string> data_list)
        {
            List<string> new_data_list = new List<string>();
            foreach (string data in data_list)
            {
                new_data_list.Add(TitleCase(data, ""));
            }
            Data_list = new_data_list;
        }

        public virtual void UpdateDatabaseDict()
        {
            Database_dict = GetIds();
        }

        public void RemoveData()
        {
            Data_list = new List<string>();
        }
    }




    class PersonSet : StandardDataSet
    {
        private string person_type;
        private string person_type_id;
        public string Person_type { get => person_type; set => person_type = value; }
        public string Person_type_id { get => person_type_id; set => person_type_id = value; }

        public PersonSet(string persontype) : base("person", "movie_person")
        {
            Person_type = persontype;
            Person_type_id = GetPersonTypeId();
        }

        private string GetPersonTypeId()
        {
            string select_string = "SELECT person_type.id " +
                                   " , person_type.person_type_name " +
                                   "FROM dbo.person_type";

            Dictionary<string, string> data_dict = new ExecuteSQLCommand().GetTwoColumnDataDict(select_string);

            return data_dict[person_type];
        }

        public override void InitialiseData(List<string> data_list)
        {
            List<string> new_data_list = new List<string>();
            foreach (string data in data_list)
            {
                new_data_list.Add(data);
            }
            Data_list = new_data_list;
            Database_dict = GetIds();
        }

        public override void AddFullData()
        {
            if (Data_list.Count == 0)
            {
                return;
            }
            StringBuilder insert_string_builder = new StringBuilder();
            insert_string_builder.AppendFormat("  INSERT INTO dbo.{0} " +
                                               "      (movie_data_id " +
                                               "      , {1}_id " +
                                               "      , person_type_id)  " +
                                               "  VALUES ",
                                               Movie_table_name,
                                               Dim_table_name);
            foreach (string data in Data_list)
            {
                insert_string_builder.AppendFormat("({0}, {1}, {2}), ",
                                                   Movie_data_id,
                                                   Database_dict[data],
                                                   Person_type_id);
            }
            insert_string_builder.Length -= 2;
            new ExecuteSQLCommand().Execute(insert_string_builder.ToString());
        }


    }

    // Makes it possible to compare different instances of Titleset
    class TitleComparer : IEqualityComparer<TitleSet>
    {
        public bool Equals(TitleSet x, TitleSet y)
        {
            return (x.Id_compare == y.Id_compare);
        }

        public int GetHashCode(TitleSet obj)
        {
            return obj.Id_compare == null ? 0 : obj.Id_compare.GetHashCode();
        }
    }
}
