using System;

namespace EpamTask4.BL.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public DateTime Data { get; set; }

        public Manager Manager { get; set; }
    }
}
