using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromtFinalApp.NewFolder1
{
    public class Connection
    {

        public static MySqlDataAdapter Adapter(string selectQuery, string v)
        {
            return new MySqlDataAdapter(selectQuery, "Server=127.0.0.1;Port=3306;Database=promtfinalapp;Uid=root;Pwd=admin");

        }


        public static void executeMyQuery(string query)
        {
            using MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=promtfinalapp;Uid=root;Pwd=admin;");
            MySqlCommand command;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }
    }
}
