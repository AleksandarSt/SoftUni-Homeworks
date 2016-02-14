using Logger.Logger.DataAppender;
using Logger.Logger.Interfaces;
using Logger.Logger.Layouts;

namespace Logger.Main
{
    public class LoggerMain
    {
        public static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IDataAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger.Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));

            var fileAppender = new FileAppender(simpleLayout, "log.txt");
            logger = new Logger.Logger(fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");
        }
    }
}