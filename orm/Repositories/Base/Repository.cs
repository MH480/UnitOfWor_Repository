using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using orm.Infrastructures;

namespace orm.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _dbcontext;
        public Repository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void Add(TEntity obj)
        {
            _dbcontext.Set<TEntity>().Add(obj);
        }

        public void AddRange(IEnumerable<TEntity> objs)
        {
            _dbcontext.Set<TEntity>().AddRange(objs);
        }

        public void Delete(TEntity obj)
        {
            _dbcontext.Set<TEntity>().Remove(obj);            
        }

        public void DeleteById(object id)
        {
            Type type = typeof(TEntity);
            TEntity entity = Activator.CreateInstance(type) as TEntity;
            entity.GetType().GetProperty("Id").SetValue(entity,id);
            _dbcontext.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> objs)
        {
            _dbcontext.Set<TEntity>().RemoveRange(objs);            
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predic)
        {
            return _dbcontext.Set<TEntity>().Where(predic).AsEnumerable();            
        }

        public TEntity Get(TEntity obj)
        {
            return _dbcontext.Set<TEntity>().Find(obj);
        }

        public TEntity Get(object id)
        {
            return _dbcontext.Set<TEntity>().Find(id);
        }

        
    }
}