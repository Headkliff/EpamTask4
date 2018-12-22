namespace EpamTask4.BL.Models
{
    using System;
    using System.Collections.Generic;

    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Item()
        {
            this.Orders = new HashSet<Order>();
        }
    }
}
