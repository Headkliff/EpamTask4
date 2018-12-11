namespace EpamTask4.DAL
{
    using System;
    using System.Data.Entity;
    using EpamTask4.DAL.Repository;

    public class UnitOfWorck<T> : IDisposable where T : class
    {
        private DbContext context;
        private IGenericRepository<T> repository;
        private bool disposed = false;

        public UnitOfWorck(DbContext context)
        {
            this.context = context;
            context.Set<T>();
        }

        public IGenericRepository<T> Repository
        {
            get
            {
                if (this.repository == null)
                {
                    this.repository = new GenericRepository<T>(this.context);
                }

                return this.repository;
            }
        }

        public void Save()
        {
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
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
