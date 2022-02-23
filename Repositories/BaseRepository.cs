using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Desafio_API_Usuario.Context;
using Projeto_Desafio_API_Usuario.Interfaces;

namespace Projeto_Desafio_API_Usuario.Repositories
{
     public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await _db.AsNoTracking().ToListAsync();
        }

        public async Task<T> ObterPorId(int id)
        {
            return await _db.FindAsync(id);
        }

        public async Task<IEnumerable<T>> Consultar(Expression<Func<T, bool>> predicate)
        {
            return await _db.AsNoTracking().Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}