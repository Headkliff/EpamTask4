namespace EpamTask4.BL.Models
{
    using System;

    public class Order
    {
        public Guid Id {get; set; }
        public DateTime Data { get; set; }

        public Manager Manager { get; set; }
        public Item Item { get; set; }
        public Customer Customer { get; set; }
    }
}
