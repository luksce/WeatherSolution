using WeatherSolution.Models.Enum;

namespace WeatherSolution.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch (tsql)
            {
                case TSql.CADASTRAR_PREVISAO:
                    sql = "insert into previsaoclima (id, cidadeid, dataprevisao, clima, temperaturaminima, temperaturamaxima) values (@id, @cidadeid, @dataprevisao, @clima, @temperaturaminima, @temperaturamaxima)";
                    break;
                case TSql.LISTAR_PREVISAO:
                    sql = "select nome from cidade orderby nome; select uf from estado; select id, cidadeid, dataprevisao, clima, temperaturaminima, temperaturamaxima from previsaoclima where cidadeid = @cidadeid";
                    break;
                case TSql.LISTAR_PREVISAOMIN:
                    sql = "select cidadeid, temperaturaminima, temperaturamaxima from previsaoclima where temperaturaminima = @temperaturaminima";
                    break;
                case TSql.LISTAR_PREVISAOMAX:
                    sql = "select cidadeid, temperaturaminima, temperaturamaxima from previsaoclima where temperaturamaxima = @temperaturamaxima";
                    break;
                case TSql.SEARCH_PREVISAO:
                    sql = "select nome from cidade orderby nome; select uf from estado; select temperaturaminima, temperaturamaxima from previsaoclima where cidadeid = @cidadeid";
                    break;
            }
            return sql;
        }
    }
}
