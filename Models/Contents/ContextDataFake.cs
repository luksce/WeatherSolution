using WeatherSolution.Models.Contexts;

namespace WeatherSolution.Models.Contents
{
    public class ContextDataFake : IContextData
    {
        private static List<PrevisaoClima> previsaoClimas = new List<PrevisaoClima>();
        private static List<Cidade> cidades = new List<Cidade>();
        private static List<Estado> estados = new List<Estado>();

        public ContextDataFake()
        {
            InitializeData();
        }

        public void CadastrarPrevisao(PrevisaoClima previsao)
        {
            try
            {
                previsaoClimas.Add(previsao);

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PrevisaoClima> ListarPrevisao()
        {
            try
            {
                return previsaoClimas.OrderBy(p => p.ToString()).ToList();
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public PrevisaoClima PesquisarPrevisaoCidade(int cidadeid)
        {
            try
            {
                return previsaoClimas.FirstOrDefault(p => p.CidadeId == cidadeid);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public PrevisaoClima PesquisarPrevisaoPorTempMax()
        {
            int x = 0;
            var aux = new PrevisaoClima();
            foreach (var previsao in previsaoClimas)
            {
                if(previsao.TemperaturaMaxima > previsaoClimas[x].TemperaturaMaxima)
                {
                    aux = previsao;
                    x++;
                }
            }

            return aux;
        }

        public PrevisaoClima PesquisarPrevisaoPorTempMin()
        {
            int x = 0;
            var aux = new PrevisaoClima();
            foreach (var previsao in previsaoClimas)
            {
                if (previsao.TemperaturaMinima < previsaoClimas[x].TemperaturaMinima)
                {
                    aux = previsao;
                    x++;
                }
            }

            return aux;
        }


        private void InitializeData()
        {
            var estado = new Estado(1,"Ceará","CE");
            estados.Add(estado);

            estado = new Estado(2, "Rio de Janeiro", "RJ");
            estados.Add(estado);

            var cidade = new Cidade(1, "Fortaleza", 1);
            cidades.Add(cidade);
            cidade = new Cidade(2, "Crateús", 1);
            cidades.Add(cidade);
            cidade = new Cidade(3, "Rio de Janeiro", 2);
            cidades.Add(cidade);
            cidade = new Cidade(4, "Angra dos Reis", 2);
            cidades.Add(cidade);

            var previsao = new PrevisaoClima(1, DateTime.Now, "Chuvoso", 19.0, 24.0);
            previsaoClimas.Add(previsao);

            previsao = new PrevisaoClima(2, DateTime.Now, "Ensolarado", 29.0, 34.0);
            previsaoClimas.Add(previsao);

            previsao = new PrevisaoClima(3, DateTime.Now, "Nublado", 23.0, 28.0);
            previsaoClimas.Add(previsao);

            previsao = new PrevisaoClima(4 ,DateTime.Now, "Ventos Fortes", 13.0, 15.0);
            previsaoClimas.Add(previsao);
        }
    }
}
