using System.IO;

namespace EpamTask4.BL
{
    using EpamTask4.BL.Tools.Reader;

    public class Unity
    {
        private FileSystemWatcher watcher;
        private string path = @"Files";
        private const string type = "*.csv";

        public Unity()
        {
            StartFileWatcher();
        }

        public void StartFileWatcher()
        {

            watcher = new FileSystemWatcher
                           {
                               Path = this.path,
                               Filter = type,
                           };

            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var reader = new Reader();
            var data = reader.Read(e.FullPath);
        }
    }
}
