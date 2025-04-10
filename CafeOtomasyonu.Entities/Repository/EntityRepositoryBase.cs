using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Interfaces;

namespace CafeOtomasyonu.Entities.Repository
{
    public class EntityRepositoryBase<TContext, TEntity> : IEntitiyRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        public void AddOrUpdate(TContext context, TEntity entity)
        {
            context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(filter));
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
// TContext : Veritabanı bağlantısını temsıl eden DbContext türevi sınıf
// TEntity : Veritabanı tablosunu temsıl eden sınıf(Ornegın urun falan)
// IEntitiyRepository : Generic repository pattern