using Microsoft.EntityFrameworkCore;

namespace WeatherSolution.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
