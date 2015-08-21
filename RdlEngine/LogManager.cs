namespace RdlEngine
{
    using log4net;

    public class LogManager
    {
        public static ILog Logger
        {
            get
            {
                return log4net.LogManager.GetLogger(typeof(LogManager));
            }
        }
    }
}