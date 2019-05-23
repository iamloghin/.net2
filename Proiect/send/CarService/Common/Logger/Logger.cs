namespace CarService.Common.Logger
{
    using CarService.Common.Logger.Enum;
    using CarService.Common.Logger.Levels;

    public static class Logger
    {
        public static BaseLogger Build()
        {
            BaseLogger errorLogger = new ErrorLogger(LogLevel.Error);
            BaseLogger infoLogger = new InfoLogger(LogLevel.Info);

            errorLogger.SetNext(infoLogger).SetNext(errorLogger);

            return errorLogger;
        }

        public static readonly BaseLogger Log = Build();
    }
}
