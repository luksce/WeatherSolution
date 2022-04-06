namespace WeatherSolution.Models
{
    public class PrevisaoClima
    {
        public int id { get; set; }
        public int CidadeId { get; set; }  
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public double TemperaturaMaxima { get; set; }
        public double TemperaturaMinima { get; set; }

        public PrevisaoClima(int id,int cidadeid, DateTime dataPrevisao, string clima, double temperaturaMaxima, double temperaturaMinima)
        {
            this.id = id;
            this.CidadeId = cidadeid;
            this.DataPrevisao = dataPrevisao;
            this.Clima = clima;
            this.TemperaturaMaxima = temperaturaMaxima;
            this.TemperaturaMinima = temperaturaMinima;
        }
        public PrevisaoClima() { 
        }

    }
}
