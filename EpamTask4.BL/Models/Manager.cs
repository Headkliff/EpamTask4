namespace EpamTask4.BL.Models
{
    using System;
    using System.Collections.Generic;

    public class Manager
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<File> File { get; set; }

        public Manager()
        {
            this.Order = new HashSet<Order>();
            this.File = new HashSet<File>();
        }
    }
}
