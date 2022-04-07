using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void AccessData()
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("INFO " + message);
            }
        }

        public void LoginuInformacija(string message)
        {
            throw new NotImplementedException();
        }
    }
}
