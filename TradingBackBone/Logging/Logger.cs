using System;
using log4net;

namespace TradingBackBone.Logging
{
    public static class Logger
    {
        public enum Category
        {
            Import,
            Export,
            Default,
            PublicationPorting,
            Newsletter,
            EMIndices,
            ISISIngest
        }

        public static void Audit(string message, Type type)
        {
            Info(message, null, Category.Default, type);
        }

        public static void Audit(string message, Category category = Category.Default, Type type = null)
        {
            Debug(message, category, null, type);
        }

        public static void Debug(string message, Category category = Category.Default, Exception exception = null, Type type = null)
        {
            ILog logger = GetLogger(category);
            if (exception == null)
            {
                logger.Debug(message);
                return;
            }

            string typeName = GetTypeName(type);
            if (!string.IsNullOrWhiteSpace(typeName)) exception.Data.Add("TypeName", typeName);
            logger.Debug(message, exception);
        }

        public static void Info(string message, Type type)
        {
            Info(message, null, Category.Default, type);
        }

        public static void Info(string message, Category category)
        {
            Info(message, null, category);
        }

        public static void Info(string message, Exception exception = null, Category category = Category.Default, Type type = null)
        {
            ILog logger = GetLogger(category);
            if (exception == null)
            {
                logger.Info(message);
                return;
            }

            string typeName = GetTypeName(type);
            if (!string.IsNullOrWhiteSpace(typeName)) exception.Data.Add("TypeName", typeName);
            logger.Info(message, exception);
        }

        public static void Warn(string message, object owner, Category category = Category.Default)
        {
            Warn(message, category, null, owner);
        }

        public static void Warn(string message, Exception exception, Category category = Category.Default)
        {
            Warn(message, category, exception);
        }

        public static void Warn(string message, Category category = Category.Default, Exception exception = null, object owner = null)
        {
            ILog logger = GetLogger(category);
            if (exception == null)
            {
                logger.Warn(message);
                return;
            }

            string typeName = GetObjectTypeName(owner);
            if (!string.IsNullOrWhiteSpace(typeName)) exception.Data.Add("TypeName", typeName);
            logger.Warn(message, exception);
        }

        public static void Error(string message, Category category = Category.Default, Exception exception = null)
        {
            ILog logger = GetLogger(category);
            if (exception != null)
                logger.Error(message, exception);
            else
                logger.Error(message);
        }

        public static void Error(string message, Exception exception, Category category = Category.Default)
        {
            Error(message, category, exception);
        }

        public static void Error(string message, Exception exception, object type, Category category = Category.Default)
        {
            Error(message, category, exception);
        }

        public static void Fatal(string message, Category category = Category.Default, Exception exception = null)
        {
            ILog logger = GetLogger(category);
            if (exception != null)
                logger.Fatal(message, exception);
            else
                logger.Fatal(message);
        }

        private static ILog GetLogger(Category category)
        {
            switch (category)
            {
                case Category.Default:
                    return GetDefaultLogForSite();
                case Category.Import:
                    return LogManager.GetLogger("LegacyImport");
                case Category.Export:
                    return LogManager.GetLogger("LegacyExport");
                case Category.ISISIngest:
                    return LogManager.GetLogger("ISISIngest");
                case Category.EMIndices:
                    return LogManager.GetLogger("EMIndices");
                case Category.PublicationPorting:
                    return LogManager.GetLogger("PublicationPorting");
                default:
                    return GetDefaultLogForSite();
            }
        }

        private static ILog GetDefaultLogForSite()
        {
            //default to midas log - (DAT)
            const string defaultLog = "Midas";

            //try and read the default log setting from web.config
            // string siteLogSetting = WebConfigurationManager.AppSettings["EM.Logging.DefaultLogger"];

            //use the app config setting or fall back to default
            // string loggerToUse = string.IsNullOrWhiteSpace(siteLogSetting) ? defaultLog : siteLogSetting;
            return LogManager.GetLogger(defaultLog);
        }

        private static string GetTypeName(Type type)
        {
            if (type == null) return string.Empty;
            try
            {
                return type.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private static string GetObjectTypeName(object o)
        {
            if (o == null) return string.Empty;
            try
            {
                return o.GetType().ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}