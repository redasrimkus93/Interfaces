using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class Quadrilateral : IPolygon, IWriteableToFile
    {
        public double Side { get; set; }
        private readonly IFileWriter _fileWriter;
        public Quadrilateral(double side, IFileWriter fileWriter)
        {
            Side = side;
            _fileWriter = fileWriter;
        }
        public double GetArea()
        {
            return Side * Side;
        }
        public override string ToString()
        {
            return $"Side {Side}, Area {GetArea()}";
        }

        public void WriteToFile(string path)
        {
            _fileWriter.AppendTextToFile(path, ToString());
        }
    }
}
