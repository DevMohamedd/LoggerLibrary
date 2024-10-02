using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger : ILogger
    {
        private readonly ILogDestination _logDestination;

        public Logger(ILogDestination logDestination)
        {
            _logDestination = logDestination;
        }

        public void Log(string message)
        {
            _logDestination.WriteLog(message);
        }
    }

}
