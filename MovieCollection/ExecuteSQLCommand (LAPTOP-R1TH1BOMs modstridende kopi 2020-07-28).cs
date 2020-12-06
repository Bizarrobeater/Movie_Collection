using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieCollection
{
    // Class contains the public connection string, and a way to execute non-queries
    public class ExecuteSQLCommand
    {
        //private readonly string connection_string = @"Data Source=CHRISTOPHER-PC\MYTESTSQLSERVER;Initial Catalog=MovieDatabase;Integrated Security=True";
        private readonly string connection_string = @"Data Source=LAPTOP-CHRISTOP\CHLTESTSERVER;Initial Catalog=TestMovieDatabase;Integrated Security=True";

        public string ConnectionString { get => connection_string; }    
        
        public void Execute(string command_string)
        {
            using (SqlConnection sql_connection = new SqlConnection(ConnectionString))
            using (SqlCommand sql_command = new SqlCommand(command_string, sql_connection))
            {
                sql_connection.Open();
                sql_command.ExecuteNonQuery();
                sql_connection.Close();
            }
        }

        public List<string> GetOneColumnDataList(string select_string)
        {
            List<string> column_data_list = new List<string>();

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(select_string, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column_data_list.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return column_data_list;
        }

        public Dictionary<string,string> GetTwoColumnDataDict(string select_string)
        {
            Dictionary<string, string> column_data_dict = new Dictionary<string, string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(select_string, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = reader.GetString(0);
                            string value = reader.GetString(1);
                            if (column_data_dict.ContainsKey(key))
                            {
                                column_data_dict[key] = value;
                            }
                            else
                            {
                                column_data_dict.Add(key, value);
                            }
                        }
                    }
                }
            }
            return column_data_dict;
        }

    }
}
