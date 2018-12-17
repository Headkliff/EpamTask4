using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask4.DAL.Repository
{
    using System.Data.Entity;

    public class GenericRepositoryFactory : IRepositoryFactory
    {
        public IGenericRepository<T> CreateInstance<T>(DbContext context) where T : class
        {
            return new GenericRepository<T>(context);
        }
    }
}
