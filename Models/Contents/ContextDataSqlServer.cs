using System.Data;
using System.Data.SqlClient;
using WeatherSolution.Models.Contexts;
using WeatherSolution.Models.Enum;
using WeatherSolution.Models.Repositories;

namespace WeatherSolution.Models.Contents
{
    public class ContextDataSqlServer : IContextData
    {

        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }
        public void CadastrarPrevisao(PrevisaoClima previsao)
        {

            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_PREVISAO);

                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@cidadeid", SqlDbType.Int).Value = previsao.CidadeId;
                command.Parameters.Add("@dataprevisao", SqlDbType.DateTime).Value = previsao.DataPrevisao;
                command.Parameters.Add("@clima", SqlDbType.VarChar).Value = previsao.Clima;
                command.Parameters.Add("@temperaturaminima", SqlDbType.Decimal).Value = previsao.TemperaturaMinima;
                command.Parameters.Add("@temperaturamaxima", SqlDbType.Decimal).Value = previsao.TemperaturaMaxima;

                command.ExecuteNonQuery();

            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }


        }

        public List<PrevisaoClima> ListarPrevisao()
        {
            var lista = new List<PrevisaoClima>();

            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_PREVISAO);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach(DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var cidadeid = colunas[1].ToString();
                    var dataprevisao = colunas[2].ToString();
                    var clima = colunas[3].ToString();
                    var tempmin = colunas[4].ToString();
                    var tempmax = colunas[5].ToString();

                    var previsao = new PrevisaoClima(id, cidadeid, dataprevisao, clima, tempmin, tempmax);
                    lista.Add(previsao);

                }
                adapter = null;
                dataset = null;

                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public PrevisaoClima PesquisarPrevisaoCidade(int cidadeid)
        {
            try
            {
                PrevisaoClima previsao = null;


                var query = SqlManager.GetSql(TSql.SEARCH_PREVISAO);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@cidadeid", SqlDbType.Int).Value = previsao.id;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var dataprevisao = colunas[2].ToString();
                    var clima = colunas[3].ToString();
                    var tempmin = colunas[4].ToString();
                    var tempmax = colunas[5].ToString();

                    var previsao = new PrevisaoClima(id, cidadeid, dataprevisao, clima, tempmin, tempmax);

                }
                adapter = null;
                dataset = null;

                return previsao;
            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public PrevisaoClima PesquisarPrevisaoPorTempMax()
        {
            try
            {
                PrevisaoClima previsao = null;


                var query = SqlManager.GetSql(TSql.LISTAR_PREVISAOMAX);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var cidadeid = colunas[1].ToString();
                    var dataprevisao = colunas[2].ToString();
                    var clima = colunas[3].ToString();
                    var tempmin = colunas[4].ToString();
                    var tempmax = colunas[5].ToString();

                    var previsao = new PrevisaoClima(id, cidadeid, dataprevisao, clima, tempmin, tempmax);

                }
                adapter = null;
                dataset = null;

                return previsao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PrevisaoClima PesquisarPrevisaoPorTempMin()
        {
            try
            {
                PrevisaoClima previsao = null;


                var query = SqlManager.GetSql(TSql.LISTAR_PREVISAOMIN);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var cidadeid = colunas[1].ToString();
                    var dataprevisao = colunas[2].ToString();
                    var clima = colunas[3].ToString();
                    var tempmin = colunas[4].ToString();
                    var tempmax = colunas[5].ToString();

                    var previsao = new PrevisaoClima(id, cidadeid, dataprevisao, clima, tempmin, tempmax);

                }
                adapter = null;
                dataset = null;

                return previsao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
