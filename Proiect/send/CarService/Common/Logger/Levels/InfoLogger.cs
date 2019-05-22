namespace CarService.Common.Logger.Levels
{
    using System;
    using System.IO;
    using CarService.Common.Logger.Enum;

    internal class InfoLogger : BaseLogger
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
                Stream file = null;
                try
                {
                    file = File.Open(FilePath, FileMode.Append, FileAccess.Write);
                    using (var streamWriter = new StreamWriter(file))
                    {
                        streamWriter.WriteLine($"Info::Logger: {DateTime.Now} -- {message}.");
                        streamWriter.Close();
                    }
                }
                finally
                {
                    file?.Dispose();
                }
            }

            return $"Info::Logger: {message}";
        }
    }
}
