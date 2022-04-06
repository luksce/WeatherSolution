namespace WeatherSolution.Models.Repositories
{
    public interface IPrevisaoRepository
    {
        void CadastrarPrevisao(PrevisaoClima previsao);
        List<PrevisaoClima> ListarPrevisao();
        PrevisaoClima PesquisarPrevisaoPorTempMin();
        PrevisaoClima PesquisarPrevisaoPorTempMax();
        PrevisaoClima PesquisarPrevisaoCidade(int cidadeid);
    }
}
