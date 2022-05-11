using CORE.Share;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repositorios
{
    internal class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        public Repositorio(DbContext context)
        {
            _context = context; 
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicado)
        {
            return _context.Set<TEntity>().Where(predicado);
        }
        public bool Add(TEntity entity)
        {
           _context.Set<TEntity>().Add(entity);
            return true;
        }

        public bool Add(IEnumerable<TEntity> entities)
        {
             _context.Set<TEntity>().AddRange(entities);
            return true;
        }

        public bool Delete(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            return true;
        }
        public bool Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return true;
        }

      
    }
}
