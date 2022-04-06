using System.Data.SqlClient;

namespace WeatherSolution.Models.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
