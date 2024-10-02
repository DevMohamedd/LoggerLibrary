using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public interface ILogger
    {
        void Log(string message);
    }

    public interface ILogDestination
    {
        void WriteLog(string message);
    }

}
