using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class Pentagon : IPolygon, IWriteableToFile
    {
        public double Perimeter { get; set; }
        public double Apothem { get; set; }

        private readonly IFileWriter _fileWriter;

        public Pentagon(double perimeter, double apothem, IFileWriter fileWriter)
        {
            Perimeter = perimeter;
            Apothem = apothem;
            _fileWriter = fileWriter;
        }

        public override string ToString()
        {
            return $"Pentagon with area {GetArea()}";
        }
        public double GetArea()
        {
            return Apothem * Perimeter / 2;
        }

        public void WriteToFile(string path)
        {
            _fileWriter.AppendTextToFile(path, ToString());
        }
    }
}
