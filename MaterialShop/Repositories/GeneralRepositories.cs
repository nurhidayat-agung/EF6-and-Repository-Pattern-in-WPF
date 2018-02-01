using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MaterialShop.iRepositories;

namespace MaterialShop.Repositories
{
    public class GeneralRepositories<TEntity> : IRepoGeneral<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected DbSet Set;

        public GeneralRepositories(DbContext context)
        {
            Set = context.Set<TEntity>();
            Context = context;
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> FindEntities(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().Where(expression);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void update(TEntity entity)
        {
            Set.Attach(entity);
            var entry = Context.Entry(entity);
            entry.State = EntityState.Modified;
        }
    }
}
