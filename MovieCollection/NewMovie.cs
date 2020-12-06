using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection
{
    class NewMovie
    {
        BaseDataSet base_data;

        PersonSet actor_set;
        PersonSet director_set;
        PersonSet writer_set;

        List<TitleSet> title_set_list;

        StandardDataSet genre_set;
        StandardDataSet franchise_set;
        StandardDataSet box_set;
        StandardDataSet collection_set;
        StandardDataSet country_set;
        StandardDataSet subtitle_set;
        StandardDataSet spoken_set;


        bool original_title_added;


        internal BaseDataSet Base_data { get => base_data; set => base_data = value; }

        internal PersonSet Actor_set { get => actor_set; set => actor_set = value; }
        internal PersonSet Director_set { get => director_set; set => director_set = value; }
        internal PersonSet Writer_set { get => writer_set; set => writer_set = value; }
        internal List<TitleSet> Title_set_list { get => title_set_list; set => title_set_list = value; }

        internal StandardDataSet Genre_set { get => genre_set; set => genre_set = value; }
        internal StandardDataSet Franchise_set { get => franchise_set; set => franchise_set = value; }
        internal StandardDataSet Box_set { get => box_set; set => box_set = value; }
        internal StandardDataSet Collection_set { get => collection_set; set => collection_set = value; }
        internal StandardDataSet Country_set { get => country_set; set => country_set = value; }
        internal StandardDataSet Subtitle_set { get => subtitle_set; set => subtitle_set = value; }
        internal StandardDataSet Spoken_set { get => spoken_set; set => spoken_set = value; }
        
        
        public bool Original_title_added { get => original_title_added; set => original_title_added = value; }

        public NewMovie()
        {
            Base_data = new BaseDataSet();
            Title_set_list = new List<TitleSet>();
            Genre_set = new StandardDataSet("genre", "movie_genre");
            Franchise_set = new StandardDataSet("franchise", "movie_franchise");
            Box_set = new StandardDataSet("box", "movie_box");
            Collection_set = new StandardDataSet("collection", "movie_collection");
            Country_set = new StandardDataSet("country", "movie_country");
            Subtitle_set = new StandardDataSet("language", "subtitle_language");
            Spoken_set = new StandardDataSet("language", "original_language");
            Actor_set = new PersonSet("Actor");
            Director_set = new PersonSet("Director");
            Writer_set = new PersonSet("Writer");
            
            Original_title_added = false;
        }

        public void AddNewMovie()
        {
            AddNewMovieDataToDim();
            GetMovieDataid();
            InsertMovieData();
        }

        private void AddNewMovieDataToDim()
        {
            AddNewTitleLanguagesToDim();
            Genre_set.AddNewDataToDimTable();
            Franchise_set.AddNewDataToDimTable();
            Box_set.AddNewDataToDimTable();
            Collection_set.AddNewDataToDimTable();
            Country_set.AddNewDataToDimTable();
            Subtitle_set.AddNewDataToDimTable();
            Spoken_set.AddNewDataToDimTable();
            Actor_set.AddNewDataToDimTable();
            Director_set.AddNewDataToDimTable();
            Writer_set.AddNewDataToDimTable();
        }

        private void GetMovieDataid()
        {
            Base_data.AddFullData();
            string id = Base_data.Movie_data_id;

            Genre_set.Movie_data_id = id;
            Franchise_set.Movie_data_id = id;
            Box_set.Movie_data_id = id;
            Collection_set.Movie_data_id = id;
            Country_set.Movie_data_id = id;
            Subtitle_set.Movie_data_id = id;
            Spoken_set.Movie_data_id = id;
            Actor_set.Movie_data_id = id;
            Director_set.Movie_data_id = id;
            Writer_set.Movie_data_id = id;

            foreach (TitleSet title in Title_set_list)
            {
                title.Movie_data_id = id;
                // Adds the most recent updated language database dictionary to each title set
                title.Language_dict = Subtitle_set.Database_dict;
            }

        }

        private void InsertMovieData()
        {
            foreach (TitleSet title in Title_set_list)
            {
                title.AddFullData();
            }
            Genre_set.AddFullData();
            Franchise_set.AddFullData();
            Box_set.AddFullData();
            Collection_set.AddFullData();
            Country_set.AddFullData();
            Subtitle_set.AddFullData();
            Spoken_set.AddFullData();
            Actor_set.AddFullData();
            Director_set.AddFullData();
            Writer_set.AddFullData();
        }




        public bool AddNewTitle(string title, string language, bool original_language)
        {
            title = title.Trim();
            language = language.Trim();

            TitleSet new_title = new TitleSet(title, language, original_language);

            // Checks whether there is a title or language string
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(language))
            {
                return false;
            }

            // if the titleset already exist or the title is an original title, but one has already been added
            if (!Title_set_list.Contains(new_title, new TitleComparer()) && !(original_language && Original_title_added))
            {
                Title_set_list.Add(new_title);
                // if it's the original title
                if (original_language)
                {
                    Original_title_added = true;
                }
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        private void AddNewTitleLanguagesToDim()
        {
            List<string> language_list = new List<string>();
            foreach (TitleSet title in Title_set_list)
            {
                if (!language_list.Contains(title.Language))
                {
                    language_list.Add(title.Language);
                }
            }
            StandardDataSet language_set = new StandardDataSet("language", "");
            language_set.InitialiseData(language_list);
            language_set.AddNewDataToDimTable();
        }

        public List<string> AddBaseData(Dictionary<string, string> base_data_dict)
        {
            List<string> not_accepted_data = new List<string>();
            bool data_accepted = true;

            //Checks the individual pieces of data
            if (string.IsNullOrWhiteSpace(base_data_dict["imdb_id"]) && base_data_dict["imdb_id"].Length != 9)
            {
                not_accepted_data.Add("imdb_id");
                data_accepted = false;
            }
            if (!(double.TryParse(base_data_dict["imdb_score"], NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double imdb_score) 
                && imdb_score <= 10 
                && imdb_score >= 0))
            {
                not_accepted_data.Add("imdb_score");
                data_accepted = false;
            }
            if (!(int.TryParse(base_data_dict["metacritic_score"], NumberStyles.Any, NumberFormatInfo.InvariantInfo, out int metacritic) 
                && metacritic <= 100 
                && metacritic >= 0))
            {
                not_accepted_data.Add("metacritic_score");
                data_accepted = false;
            }
            if (!(int.TryParse(base_data_dict["run_time"], NumberStyles.Any, NumberFormatInfo.InvariantInfo, out int run_time)
                && run_time > 0))
            {
                not_accepted_data.Add("run_time");
                data_accepted = false;
            }
            if (!DateTime.TryParseExact(base_data_dict["release_date"], "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime _))
            {
                not_accepted_data.Add("release_date");
                data_accepted = false;
            }

            if (data_accepted)
            {
                Base_data.InitialiseBaseData(base_data_dict["imdb_id"],
                                            base_data_dict["release_date"],
                                            base_data_dict["imdb_score"],
                                            base_data_dict["metacritic_score"],
                                            base_data_dict["run_time"]);
            }
            return not_accepted_data;
        }

        public void AddStandardData(List<string> data_list, StandardDataSet standardDataSet)
        {
            standardDataSet.InitialiseData(data_list);
        }

        public bool CheckForOriginalTitle()
        {
            bool orignal_exists = false;
            foreach (TitleSet title in Title_set_list)
            {
                if (title.Original_language)
                {
                    orignal_exists = true;
                    break;
                }
            }
            return orignal_exists;
        }

    }
}
