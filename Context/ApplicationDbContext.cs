using Microsoft.EntityFrameworkCore;
using Projeto_Desafio_API_Usuario.Entities;

namespace Projeto_Desafio_API_Usuario.Context
{
    public class ApplicationDbContext: DbContext
    {
         //construtor tem que ser public
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Deputado> Deputados { get; set; }
        public DbSet<Governador> Governadores { get; set; }
        public DbSet<Ministro> Ministros { get; set; }
        public DbSet<Prefeito> Prefeitos { get; set; }
        public DbSet<Presidente> Presidentes { get; set; }
        public DbSet<Senador> Senadores { get; set; }
        public DbSet<Vereador> Vereadores { get; set; }
    }
}