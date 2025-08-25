using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionAfterSingleton
{
    //singleton pattern
    internal class DbConnection
    {
        private readonly SqlConnection _connection;
        private static int _numOfConnections = 0;
        private static DbConnection _instance;
        private DbConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _numOfConnections++;
            Console.WriteLine($"Number of connections: {_numOfConnections}");
        }

        public static DbConnection CreateInstance(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new DbConnection(connectionString);
            }
            return _instance;
        }
    }
}
