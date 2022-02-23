using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Projeto_Desafio_API_Usuario.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            //Configuração da documentação da API (Swagger)
            services.AddSwaggerGen(
                swagger =>
                {
                    swagger.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = "API Para Consumo de API Políticos",
                        Description = "Projeto API REST desenvolvida em ASP.NET Core 5.0 - Desenvolvido por Natália Sousa",
                        Version = "v1",
                        Contact = new OpenApiContact
                        {
                            Name = "Projeto_Desafio_API_Usuario",
                            Url = new System.Uri("https://lh3.googleusercontent.com/proxy/bjbpuxLAOKDjy--2MVFUPXlML5wf_TWsXv3EPWS1tLWVcvD8Iq4rt6m1wI2A7xMsNlR60qlxQTLPZCFi4FEJZ7ebVuK48ygukeRLfDJXS3Klh8jtY6QtqUgoZn01g22SxEeJO_exqkxkv6q7IK1cjjZIfGE"),
                            Email = "startergft@gft.com"
                        }
                    });
                    
                }
            );

        }
    }
}