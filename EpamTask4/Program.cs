using System;
using System.IO;

namespace EpamTask4
{
    using EpamTask4.BL;

    class Program
    {
        public static void Main()
        {
            MonitorDirectory();
        }

        private static void MonitorDirectory()
        {
            var unity = new Unity();

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q')
            {
            }
        }
    }
}
