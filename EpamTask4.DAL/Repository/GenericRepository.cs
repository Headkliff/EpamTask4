namespace EpamTask4.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

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

        public T Find(T item)
        {
            return this.dbSet.Find(item);
        }

        public void Create(T item)
        {
            this.dbSet.Add(item);
            this.context.SaveChangesAsync();
        }

        public void Update(T item)
        {
            this.context.Entry(item).State = EntityState.Modified;
            this.context.SaveChangesAsync();
        }

        public void Remove(T item)
        {
            this.dbSet.Remove(item);
            this.context.SaveChangesAsync();
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
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
