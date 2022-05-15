using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> :IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // using IDisposable Pattern Implemendation : Garbage Collector using içerisindeki işlem bitince direkt oraya gönderiliyor. Bellek hızlıca temizleniyor.
            //referansı yakala, 2-bu eklenecek bir nesne, 3-buradaki bütün işlemleri gerçekleştir
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
            //eğer filtre vermemiş ise veri tabanındaki tüm datayı getir, eğer filtre verildiyse o filtreyi uygula
            // : değilse anlamında 
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
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
