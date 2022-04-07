using System;
using System.Collections.Generic;

namespace InterfacesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPolygon> polygons = new List<IPolygon>()
            {
                new Triangle(8.12, 5, new FileWriter()),
                new Triangle(8.11, 5, new FileWriter()),
                new Triangle(8.10, 5, new FileWriter()),
                new Triangle(8.14, 5, new StreamFileWrite()),
                new Triangle(8.08, 5, new StreamFileWrite()),

            };
            PolygonComparer polygonComparer = new PolygonComparer();
            polygons.Sort(polygonComparer);

            foreach (var item in polygons)
            {
                Console.WriteLine(item.GetType().Name + " " + item.GetArea() );
            }


            List<IWriteableToFile> palygonsAsWriteable = new List<IWriteableToFile>()
            {
                new Hexagon(6.45, new FileWriter()),
                new Triangle(5, 6.6, new StreamFileWrite()),
                new Pentagon(45, 4.5, new FileWriter()),
                new Quadrilateral(54, new FileWriter())
            };

            foreach (var item in palygonsAsWriteable)
            {
                item.WriteToFile("C:\\CodeAcademy\\pentagons.txt");
            }





        }
    }
}
