using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProjetoBase.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntidade, TId>
           where TEntidade : class
           where TId : struct
    {
        IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties);
        IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade ObterPorId(TId id, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade ObterPor(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade Adicionar(TEntidade entidade);
        IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades);
        TEntidade Editar(TEntidade entidade);
        void Remover(TEntidade entidade);
        bool Existe(Func<TEntidade, bool> where);
    }
}
