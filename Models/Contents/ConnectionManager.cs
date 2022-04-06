using System.Data.SqlClient;
using WeatherSolution.Models.Repositories;

namespace WeatherSolution.Models.Contents
{
    public class ConnectionManager : IConnectionManager
    {
        private static string _connectionName = "model";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if (connection == null)
                connection = new SqlConnection(connStr);
        }
        SqlConnection IConnectionManager.GetConnection()
        {
            return connection;
        }
    }
}
