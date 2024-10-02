using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(string destinationType, string filePath)
        {
            ILogDestination logDestination;

            switch (destinationType.ToLower())
            {
                case "textfile":
                    logDestination = new TextFileLogDestination(filePath);
                    break;
                case "excel":
                    logDestination = new ExcelLogDestination(filePath);
                    break;
                default:
                    throw new ArgumentException("Invalid destination type");
            }

            return new Logger(logDestination);
        }
    }

}
