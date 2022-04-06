namespace WeatherSolution.Models
{
    public class Estado
    {
         public int Id { get; set; }

        public string Nome { get; set; }

        public string UF { get; set; }

        public Estado(int id, string nome, string uf)
        {
            this.Id = id;
            this.Nome = nome;
            this.UF = uf;
        }

       
    }
}
