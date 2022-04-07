using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SqlLiteDataAccess : DataAccess
    {
        public override void LoadDataAccess(string sqlQuery)
        {
            Console.WriteLine("Loading data in SqlLite database");
        }

        public override void SaveDataAccess(string sqlQuery)
        {
            Console.WriteLine("Inserting data into SqlLite database");
        }
    }
}
