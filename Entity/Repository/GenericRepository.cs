using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity.Repository
{
    using System.Data.Entity;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        DbContext context;
        DbSet<T> dbSet;
        private bool disposed = false;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            return this.dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return this.dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public T FindById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Create(T item)
        {
            this.dbSet.Add(item);
            this.context.SaveChanges();
        }

        public void Update(T item)
        {
            this.context.Entry(item).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Remove(T item)
        {
            this.dbSet.Remove(item);
            this.context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
