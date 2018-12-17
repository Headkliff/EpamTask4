namespace EpamTask4.DAL.Repository
{
    using System.Data.Entity;

    public interface IRepositoryFactory
    {
        IGenericRepository<T> CreateInstance<T>(DbContext context) where T : class;
    }
}