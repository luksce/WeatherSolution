namespace WeatherSolution.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public Cidade(int id, string nome, int estadoid)
        {
            this.Id = id;
            this.Nome = nome;
            this.EstadoId = estadoid;
        }

  

    }
}
