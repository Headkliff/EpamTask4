namespace EpamTask4.DAL.Repository
{
    using System.Data.Entity;

    public interface IRepositoryFactory
    {
        IGenericRepository<T> CreateRepository<T>(DbContext context) where T : class;
    }
}