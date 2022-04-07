using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class FileWriter : IFileWriter
    {
        public void AppendTextToFile(string path, string text)
        {
            File.AppendAllText(path, text + Environment.NewLine);
        }
    }
}
