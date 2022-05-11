using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Share
{
    public interface IRepositorio<TEntity> where TEntity: class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>>predicado);

        bool Add(TEntity entity);
        bool Add(IEnumerable<TEntity> entities);

        bool Delete(TEntity entity);
        bool Delete(IEnumerable<TEntity> entities);


    }
}
