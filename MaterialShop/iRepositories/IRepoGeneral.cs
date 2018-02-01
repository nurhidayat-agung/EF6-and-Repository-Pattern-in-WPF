using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaterialShop.iRepositories
{
    public interface IRepoGeneral<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FindEntities(Expression<Func<TEntity, bool>> expression);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);


        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void update(TEntity entity);
    }
}
