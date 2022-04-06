using WeatherSolution.Models.Contexts;
using WeatherSolution.Models.Repositories;
using WeatherSolution.Models.Services;

namespace WeatherSolution
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddScoped<IPrevisaoRepository, PrevisaoRepository>();
            services.AddScoped<IPrevisaoService, PrevisaoService>();

            ConfigureDataSource(services);
        }

        public void ConfigureDataSource(IServiceCollection services)
        {
            var datasource = Configuration["DataSource"];
            switch(datasource)
            {
                case "Local":
                    services.AddSingleton<IContextData, ContextDataFake>();
                    break;

                case "SqlServer":
                    services.AddSingleton<IContextData, ContextDataSqlServer>();
                    services.AddSingleton<IConnectionManager, ConnectionManager>();
                    break;

            }
    }
}
