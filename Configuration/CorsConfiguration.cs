using Microsoft.Extensions.DependencyInjection;

namespace Projeto_Desafio_API_Usuario.Configuration
{
    public class CorsConfiguration//Usado para não dar erro de acesso caso alguém tente acessar de IPs diferentes
    {
        
        public static void Configure(IServiceCollection services) 
        {
            //Configuração do Cors - Cross Origin Resource Sharing
            services.AddCors(
                s => s.AddPolicy("DefaultPolicy", builder =>
                {
                    //permitindo que qualquer servidor faça requisições para a API
                    builder.AllowAnyOrigin()
                    //permitindo que qualquer método da API seja executado(Post, Put, Get, Delete, etc)
                    .AllowAnyMethod()
                    //permitindo que qualquer cabeçalho seja enviado para a API(Token por exemplo)
                    .AllowAnyHeader();

   
                })); 
                
        }
        
    }
}