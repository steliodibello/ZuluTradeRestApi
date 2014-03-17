using System;
using System.Diagnostics;
using EM.Backbone.Services;
using Euromoney.ExceptionHandler;
using log4net.Appender;
using log4net.spi;
using SC = Sitecore;

namespace EM.Backbone.Logging.Appender
{
    public class ExceptionHandlerSitecoreSiteAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            try
            {
                //get the context site from sitecore site settings if it is available
                int siteId;
                if (!int.TryParse(SC.Context.Site.Properties[Constants.SiteSettings.ExceptionLoggingIdField], out siteId)) return;
                if (siteId < 1) return;

                // Get the data
                string message = loggingEvent.RenderedMessage;
                string loggerName = loggingEvent.LoggerName;
                string level = loggingEvent.Level.Name;
                string exceptionStr = loggingEvent.GetExceptionStrRep();
                string email = SC.Context.User != null && SC.Context.User.IsAuthenticated &&
                               SC.Context.User.Profile != null
                                   ? SC.Context.User.Profile.Email
                                   : String.Empty;

                // Create the exception
                var exception = new Exception(String.Format("{0}: {1}", level, message)) {Source = loggerName};
                if (!String.IsNullOrWhiteSpace(exceptionStr))
                    exception.Data.Add("Exception", exceptionStr);

                // Send it
                ExternalExceptionLogging.ProcessWebsiteException(siteId, exception, null, null, email);
            }
            catch
            {
                // Ignore exception and continue
            }
        }
    }
}