using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace orm.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {

        TEntity Get(TEntity obj);
        TEntity Get(object id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predic);
        
        void Add(TEntity obj);
        void AddRange(IEnumerable<TEntity> objs);

        void Delete(TEntity obj);
        void DeleteRange(IEnumerable<TEntity> objs);
        void DeleteById(object id);

    }
}