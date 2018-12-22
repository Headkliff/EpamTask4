using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask4.BL.Tools
{
    using System.Data.Entity;
    using System.Diagnostics;

    using EpamTask4.BL.Models;
    using EpamTask4.DAL.Repository;

    public class DbWriter
    {
        private IRepositoryFactory factory = new GenericRepositoryFactory();

        private readonly DbContext context;

        public async Task Write(IEnumerable<Order> records)
        {
            var repository = this.factory.CreateRepository<Order>(this.context);

            foreach (var item in records)
            {
                if (item != null)
                {
                    repository.Create(item);
                }
            }
        }
    }
}
