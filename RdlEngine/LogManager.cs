namespace RdlEngine
{
    using System;

    using log4net;

    public class LogManager
    {
        public static string LoggerName;

        public static ILog Logger
        {
            get { return log4net.LogManager.GetLogger(LoggerName ?? "Printing: " + Environment.MachineName); }
        }
    }
}