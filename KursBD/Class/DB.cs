using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Npgsql;

namespace KursBD.Class
{
    public class db
    {
        //string connection = String.Format("Server={0};Port={1};User id={2};Password={3};Database={4}" , "localhost", 5432, "postgres", "1234", "KP" );

        NpgsqlConnection connection = new NpgsqlConnection(@"server=localhost;port=5432;User ID=root;password=GfTpa8cy;Database=KP");

        public void OpenConection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public NpgsqlConnection GetConnection()
        {
            return connection;
        }


    }
}
