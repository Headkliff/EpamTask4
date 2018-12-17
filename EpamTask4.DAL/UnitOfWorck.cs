namespace EpamTask4.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq.Expressions;

    using EpamTask4.DAL.Repository;

    public abstract class UnitOfWorck<T, TEntity> : IDisposable where T : class where TEntity : class
    {
        private readonly DbContext context;
        protected IRepositoryFactory repositoryFactory;

        protected abstract Func<T, TEntity> ToEntity { get; }
        protected abstract Func<TEntity, T> ToModel { get; }

        private bool disposed = false;

        public UnitOfWorck(DbContext context, IRepositoryFactory factory)
        {
            this.context = context;
            this.repositoryFactory = factory;
        }

        public TEntity TryAdd(T modelElement, Expression<Func<T, bool>> searchExpression)
        {
            TEntity newEntityElement = null;

            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return newEntityElement;
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
