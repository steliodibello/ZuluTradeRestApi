using System;
using log4net;

namespace TradingBackBone.Logging
{
    public class LogWriter : ILogWriter
    {
        public void Error(string message, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Error(message);
        }

        public void Error(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Error(message, exception);
        }

        public void Fatal(string message, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Fatal(message);
        }

        public void Fatal(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Fatal(message, exception);
        }

        public void Warning(string message, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Warn(message);
        }

        public void Warning(string message, Exception exception, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Warn(message, exception);
        }

        public void Info(string message, LogWriterCategory category = LogWriterCategory.Platform)
        {
            GetLogger(category).Info(message);
        }

        private static ILog GetLogger(LogWriterCategory logWriterCategory)
        {
            string logName = Enum.GetName(typeof (LogWriterCategory), logWriterCategory);
            return LogManager.GetLogger(logName);
        }
    }
}