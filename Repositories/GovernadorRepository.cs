using Projeto_Desafio_API_Usuario.Context;
using Projeto_Desafio_API_Usuario.Entities;
using Projeto_Desafio_API_Usuario.Interfaces;

namespace Projeto_Desafio_API_Usuario.Repositories
{
    public class GovernadorRepository : BaseRepository<Governador>, IGovernadorRepository
    {
        private readonly ApplicationDbContext _context;

        public GovernadorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}