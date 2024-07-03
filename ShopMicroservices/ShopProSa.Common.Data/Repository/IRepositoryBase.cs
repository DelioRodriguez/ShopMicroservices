using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopProSa.Common.Data.Repository
{
   public interface IRepositoryBase<TEntity,TType> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetEntityByID(TType id);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        bool Exists(Expression<Func<TEntity, bool>> filter);
    }
}
