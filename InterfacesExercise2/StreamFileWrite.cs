using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class StreamFileWrite : IFileWriter
    {
        public void AppendTextToFile(string path, string text)
        {
            using (var streamWriter = new StreamWriter(path, append: true))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}
