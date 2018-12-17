using System.Collections.Generic;
using System.IO;

using EpamTask4.BL.Models;

namespace EpamTask4.BL.Tools.Reader
{
    using CsvHelper;

    public class Reader
    {
        public IEnumerable<Order> Read(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                var reader = new CsvReader(sr);

                IEnumerable<Order> records = reader.GetRecords<Order>();

                return records;
            }
        }
    }
}
