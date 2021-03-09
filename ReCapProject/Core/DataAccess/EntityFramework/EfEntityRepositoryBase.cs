using System.Linq.Expressions;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using ReCapProject.Core.Entities;
using System.Data.Entity;

namespace ReCapProject.Core.DataAccess.EntityFramework
{/*Evrensel
  * Entity framewrok kullanarak bir repository base oluşturmak
  * 
  * public class EfEntityRepositoryBase<TEntity, TContext> bir entity tipi bir context tipi ver
  *  Projelerde tablo oluşturuduğumuzda bir kere yazacağız tamam olacak
  *  
  */
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityReposityory<TEntity>
           where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                                     : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}