using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Logger
{
    public class TextFileLogDestination : ILogDestination
    {
        private readonly string _filePath;

        public TextFileLogDestination(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(string message)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
