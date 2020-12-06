using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection
{
    class LastWatchedUpdate
    {
        private List<string> movies_watched = new List<string>();
        private string watched_date;

        public List<string> Movies_watched { get => movies_watched; set => movies_watched = value; }
        public string Watched_date { get => watched_date; set => watched_date = value; }

        public LastWatchedUpdate(List<string> movies, string date)
        {
            Movies_watched = movies;
            Watched_date = date;
        }

        public string InsertStringBuilder()
        {
            StringBuilder insert_string_builder = new StringBuilder();

            insert_string_builder.Append("INSERT INTO dbo.last_watched_log " +
                                         "(movie_data_id, last_watched_date) " +
                                         "VALUES ");
            for (int i = 0; i < Movies_watched.Count; i++)
            {
                string comma = ", ";
                if (i == 0)
                {
                    comma = "";
                }
                insert_string_builder.AppendFormat("{0} ({1}, '{2}') ",
                                                    comma,
                                                    movies_watched[i],
                                                    Watched_date);
            }
            return insert_string_builder.ToString();
        }
        

    }
}
