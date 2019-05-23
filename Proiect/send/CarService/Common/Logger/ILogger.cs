namespace CarService.Common.Logger
{
    using CarService.Common.Logger.Enum;

    public interface ILogger
    {
        ILogger SetNext(ILogger logger);
        object Handle(LogLevel level, string message);
    }
}
