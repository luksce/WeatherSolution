using WeatherSolution.Models.Contexts;

namespace WeatherSolution.Models.Repositories
{
    public class PrevisaoRepository : IPrevisaoRepository
    {
        private readonly IContextData _contextData;

        public PrevisaoRepository(IContextData contextData)
        {
            _contextData = contextData;
        }

        public void CadastrarPrevisao(PrevisaoClima previsao)
        {
            _contextData.CadastrarPrevisao(previsao);
        }

        public List<PrevisaoClima> ListarPrevisao()
        {
           return _contextData.ListarPrevisao();
        }

        public PrevisaoClima PesquisarPrevisaoCidade(int cidadeid)
        {
            return _contextData.PesquisarPrevisaoCidade(cidadeid);
        }

        public PrevisaoClima PesquisarPrevisaoPorTempMax()
        {
            return _contextData.PesquisarPrevisaoPorTempMax();
        }

        public PrevisaoClima PesquisarPrevisaoPorTempMin()
        {
           return _contextData.PesquisarPrevisaoPorTempMin();
        }
    }
}
