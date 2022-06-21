using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AppBancoAdo
{
    public class Banco : IDisposable
    {
        private readonly MySqlConnection connection;

        public Banco()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            connection.Open();
        }

        public void ExecuteCommand(string strQuery) 
        {
            var vCommand = new MySqlCommand
            {
                CommandText = strQuery,
                CommandType = System.Data.CommandType.Text,
                Connection = connection
            };
            vCommand.ExecuteNonQuery();
        }

        public MySqlDataReader ReturnCommand (string strQuery)
        {
            var command = new MySqlCommand(strQuery, connection);
            return command.ExecuteReader();
        }

        public void Dispose() 
        {
            if(connection.State==System.Data.ConnectionState.Open)
            connection.Close();    
        }
    }
}
