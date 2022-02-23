using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Projeto_Desafio_API_Usuario.Interfaces
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> ObterTodos(); //<IEnumerable<T>> Vai me retornar uma lista do objeto
        Task<T> ObterPorId(int id);
        Task<IEnumerable<T>> Consultar(Expression<Func<T, bool>> predicate); //Vai buscar somente pelo parametro fornecido
    }
}