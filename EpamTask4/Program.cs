using System;
using System.IO;

namespace EpamTask4
{
    class Program
    {
        private static FileSystemWatcher watcher;

        public static void Main()
        {
            string path = @"Files";
            string type = "*.csv";
            MonitorDirectory(path: path, type: type);
        }

        private static void MonitorDirectory(string path, string type)
        {
            watcher = new FileSystemWatcher(path: path, filter: type);
            
            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
                        
        }
    }
}
