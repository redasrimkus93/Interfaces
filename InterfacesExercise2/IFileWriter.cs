using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    interface IFileWriter
    {
        void AppendTextToFile(string path, string text);
    }
}
