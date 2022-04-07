using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class Triangle : IPolygon, IWriteableToFile
    {
        public double Hight { get; set; }
        public double Base { get; set; }
        private readonly IFileWriter _fileWriter;
        public Triangle(double hight, double baseLenght, IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
            Hight = hight;
            Base = baseLenght;
        }
        public double GetArea()
        {
            return Hight * Base / 2;
        }

        public override string ToString()
        {
            return $"Hight {Hight}, Base {Base}, Area {GetArea()} ";
        }

        public void WriteToFile(string path)
        {
            _fileWriter.AppendTextToFile(path, ToString());
        }
    }
}
