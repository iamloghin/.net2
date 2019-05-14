namespace CarService.Common.Logger.Levels
{
    using System;
    using System.IO;
    using CarService.Common.Logger.Enum;

    public class ErrorLogger : BaseLogger
    {
        public ErrorLogger(LogLevel level)
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
                        file = null;
                        streamWriter.WriteLine($"Error::Logger::{DateTime.Now}");
                        streamWriter.WriteLine(message);
                        streamWriter.WriteLine("_______________________________");
                        streamWriter.Close();
                    }
                }
                finally
                {
                    file?.Dispose();
                }
            }

            return $"Error::Logger: {message}";
        }
    }
}
