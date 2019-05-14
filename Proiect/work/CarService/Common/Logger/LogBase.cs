namespace CarService.Common.Logger
{
    using System;
    using System.IO;

    public abstract class LogBase
    {
        protected static readonly string RootPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
        protected static readonly string FilePath = $@"{RootPath}\CarServiceLog.txt";
        protected readonly object LockObj = new object();
        public abstract void Log(string message);
    }

    public class FileLogger : LogBase
    {
        public override void Log(string message)
        {
            lock (LockObj)
            {
                using (var file = File.Open(FilePath, FileMode.Append, FileAccess.Write))
                    using (var streamWriter = new StreamWriter(file))
                    {
                        streamWriter.WriteLine($"{DateTime.Now}: {message}.");
                        streamWriter.Close();
                    }
            }
        }
    }

    public class EventLogger : LogBase
    {
        public override void Log(string message)
        {
            lock (LockObj)
            {
                using (var file = File.Open(FilePath, FileMode.Append, FileAccess.Write))
                using (var streamWriter = new StreamWriter(file))
                {
                    streamWriter.WriteLine("ERROR !");
                    streamWriter.WriteLine("_______________________________");
                    streamWriter.WriteLine($"{DateTime.Now}: {message}.");
                    streamWriter.WriteLine("_______________________________");
                    streamWriter.Close();
                }
            }
        }
    }
}
