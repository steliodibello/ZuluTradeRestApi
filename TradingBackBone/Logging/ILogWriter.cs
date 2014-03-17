using System;

namespace TradingBackBone.Logging
{
    public interface ILogWriter
    {
        void Error(string message, LogWriterCategory category = LogWriterCategory.Platform);
        void Error(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform);
        void Fatal(string message, LogWriterCategory category = LogWriterCategory.Platform);
        void Fatal(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform);
        void Warning(string message, LogWriterCategory category = LogWriterCategory.Platform);
        void Warning(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform);
        void Info(string message, LogWriterCategory category = LogWriterCategory.Platform);
    }
}