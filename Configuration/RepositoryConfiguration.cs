using Microsoft.Extensions.DependencyInjection;
using Projeto_Desafio_API_Usuario.Interfaces;
using Projeto_Desafio_API_Usuario.Repositories;

namespace Projeto_Desafio_API_Usuario.Configuration
{
    public static class RepositoryConfiguration
    {
        public static void AddConfigureRepository(this IServiceCollection services) // this -> pegar o mesmo IServiceCollection 
        {                       
            services.AddScoped<IDeputadoRepository, DeputadoRepository>();
            services.AddScoped<IGovernadorRepository, GovernadorRepository>();
            services.AddScoped<IMinistroRepository, MinistroRepository>();
            services.AddScoped<IPrefeitoRepository, PrefeitoRepository>();
            services.AddScoped<IPresidenteRepository, PresidenteRepository>();
            services.AddScoped<ISenadorRepository, SenadorRepository>();
            services.AddScoped<IVereadorRepository, VereadorRepository>();
        }
    }
}