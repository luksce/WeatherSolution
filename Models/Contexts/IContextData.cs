namespace WeatherSolution.Models.Contexts
{
    public interface IContextData
    {
        void CadastrarPrevisao(PrevisaoClima previsao);

        List<PrevisaoClima> ListarPrevisao();

        PrevisaoClima PesquisarPrevisaoPorTempMin();
        PrevisaoClima PesquisarPrevisaoPorTempMax();

        PrevisaoClima PesquisarPrevisaoCidade(int cidadeid);
    }
}
