using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class DataAccess
    {
        public virtual string LoadConnectionString()
        {
            Console.WriteLine("Loading connection string");
            return "testConnectionString";
        }

        public abstract void LoadDataAccess(string sqlQuery);

        public abstract void SaveDataAccess(string sqlQuesry);

    }
}
