using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherSolution.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WeatherSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        static List<PrevisaoClima> ListarPrevisoes()
        {
            var previsoes = new List<PrevisaoClima>();

            var p1 = new PrevisaoClima(DateTime.Now, "Chuvoso", 25.0, 34);
            var p2 = new PrevisaoClima(DateTime.Now, "Ensolarado", 29.0, 34);
            var p3 = new PrevisaoClima(DateTime.Now, "Nevando", 19.0, 24);

            previsoes.Add(p1);
            previsoes.Add(p2);
            previsoes.Add(p3);

            return previsoes;
        }

        static void TestarPrevisao()
        {
            try
            {
                var previsoes = ListarPrevisoes();
                var connection = ConnectionManager.GetConnection();

                connection.Open();

                foreach (var previsao in previsoes)
                {
                    var query = "insert into PrevisaoClima(cidadeid, dataprevisao, clima, temperaturaminima, temperaturamaxima) values (@cidadeid, @dataprevisao, @clima, @temperaturaminima, @temperaturamaxima)";
                    var command = new SqlCommand(query, connection);

                    command.Parameters.Add("@cidadeid", SqlDbType.VarChar).Value = previsao.CidadeId;
                    command.Parameters.Add("@dataprevisao", SqlDbType.VarChar).Value = previsao.DataPrevisao;
                    command.Parameters.Add("@clima", SqlDbType.VarChar).Value = previsao.Clima;
                    command.Parameters.Add("@temperaturaminima", SqlDbType.VarChar).Value = previsao.TemperaturaMinima;
                    command.Parameters.Add("@temperaturamaxima", SqlDbType.VarChar).Value = previsao.TemperaturaMaxima;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
        }

    }
}