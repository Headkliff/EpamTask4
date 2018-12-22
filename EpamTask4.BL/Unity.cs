using System.IO;

namespace EpamTask4.BL
{
    using System.Threading.Tasks;

    using EpamTask4.BL.Tools;
    using EpamTask4.BL.Tools.Reader;

    public class Unity
    {
        private FileSystemWatcher watcher;
        private readonly string path = @"Files";
        private const string Type = "*.csv";

        public Unity()
        {
            StartFileWatcher();
        }

        public void StartFileWatcher()
        {

            watcher = new FileSystemWatcher
                           {
                               Path = path,
                               Filter = Type,
                           };

            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var reader = new Reader();
            var dbwriter = new DbWriter();
            Task.Factory.StartNew(
                async () =>
                    {
                        var records = reader.Read(e.FullPath);
                        await dbwriter.Write(records);
                    });
            
        }
    }
}
