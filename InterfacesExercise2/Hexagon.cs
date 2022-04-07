using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class Hexagon : IPolygon, IWriteableToFile
    {
        public double Side { get; set; }
        private readonly IFileWriter _fileWriter;
        public Hexagon(double side, IFileWriter fileWriter)
        {
            Side = side;
            _fileWriter = fileWriter;
        }
        public double GetArea()
        {
            return (3 * Math.Sqrt(3) * Side * Side) / 2; 
        }

        public override string ToString()
        {
            return $"Side {Side}, Area {GetArea()} ";
        }

        public void WriteToFile(string path)
        {
            _fileWriter.AppendTextToFile(path, ToString());
        }
    }
}
