using System;
using System.Diagnostics;

namespace TradingBackBone.Logging
{
    public class StopWatchLogger
    {
        public StopWatchLogger(string loggingMethodName, string timerName)
        {
            LoggingMethod = loggingMethodName;
            TimerName = timerName;
            WatchId = Guid.NewGuid();
        }

        private string LoggingMethod { get; set; }
        private string TimerName { get; set; }
        private Stopwatch Watch { get; set; }

        public long TotalMs
        {
            get { return Watch.ElapsedMilliseconds; }
        }

        private Guid WatchId { get; set; }

        public void Start()
        {
            Log("*start*");
            Watch = new Stopwatch();
            Watch.Start();
        }

        public void Stop()
        {
            Log("*stop*");
            Watch.Stop();
            Log("*elapsed* " + TotalMs + "ms");
        }

        public void Log(string logEntry)
        {
            Logger.Info(string.Format("{0}-{4} :: {1} ({2}) - WID:{3}", LoggingMethod, logEntry, DateTime.UtcNow, WatchId, TimerName));
        }
    }
}