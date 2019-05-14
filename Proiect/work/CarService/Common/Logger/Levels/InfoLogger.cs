namespace CarService.Common.Logger.Levels
{
    using System;
    using System.IO;
    using CarService.Common.Logger.Enum;

    public class InfoLogger : BaseLogger
    {
        public InfoLogger(LogLevel level)
        {
            this.Level = level;
        }

        public override object Handle(LogLevel level, string message)
        {
            if (this.Level != level) return base.Handle(level, message);

            lock (LockObj)
            {
                using (var file = File.Open(FilePath, FileMode.Append, FileAccess.Write))
                using (var streamWriter = new StreamWriter(file))
                {
                    streamWriter.WriteLine($"Info::Logger: {DateTime.Now} -- {message}.");
                    streamWriter.Close();
                }
            }

            return $"Info::Logger: {message}";
        }
    }
}
