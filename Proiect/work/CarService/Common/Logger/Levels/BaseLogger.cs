namespace CarService.Common.Logger.Levels
{
    using System.IO;
    using CarService.Common.Logger.Enum;

    public abstract class BaseLogger: ILogger
    {
        protected static readonly string FilePath = GetFilePath("CarServiceLog", 3);
        protected static readonly object LockObj = new object();

        protected LogLevel Level;
        protected ILogger NextLogger;

        public ILogger SetNext(ILogger logger)
        {
            this.NextLogger = logger;
            return logger;
        }

        public virtual object Handle(LogLevel level, string message)
        {
            return NextLogger?.Handle(level, message);
        }

        private static string GetFilePath(string fileName = "log", int folderLevel = 0)
        {
            var rootPath = GetPathAtLevel(folderLevel);
            return $@"{rootPath}\{fileName}.txt";
        }

        private static string GetPathAtLevel(int folderLevel = 0)
        {
            var fullPath = Directory.GetCurrentDirectory();
            while (folderLevel-- > 0)
            {
                fullPath = Path.GetDirectoryName(fullPath);
            }
            return fullPath;
        }
    }
}
