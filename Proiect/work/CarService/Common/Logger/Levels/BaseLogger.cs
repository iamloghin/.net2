namespace CarService.Common.Logger.Levels
{
    using System.IO;
    using CarService.Common.Logger.Enum;

    public abstract class BaseLogger: ILogger
    {
        protected static readonly string RootPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
        protected static readonly string FilePath = $@"{RootPath}\CarServiceLog.txt";
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
    }
}
