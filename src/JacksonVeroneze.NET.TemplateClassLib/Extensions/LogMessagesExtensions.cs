namespace JacksonVeroneze.NET.TemplateClassLib.Extensions;

public static partial class LogMessagesExtensions
{
    #region Common

    [LoggerMessage(
        EventId = 1000,
        Level = LogLevel.Error,
        Message = "{className} - {methodName} - Error")]
    public static partial void LogGenericError(this ILogger logger,
        string className, string methodName, Exception ex);

    #endregion
}