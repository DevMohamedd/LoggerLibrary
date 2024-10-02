namespace Logger
{
    public class Class1
    {
        string logFilePath = "C:\\Users\\moham\\OneDrive\\Desktop\\trash\\Logger.txt";
        ILogger logger = LoggerFactory.CreateLogger("Logger.txt", "C:\\Users\\moham\\OneDrive\\Desktop\\trash\\Logger.txt");

    }
}
