using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class OracleDataAccess : DataAccess
    {
        public override string LoadConnectionString()
        {
            Console.WriteLine("Loading connection string from Oracle database");
            return "connectionstringFromOracle";
        }
        public override void LoadDataAccess(string sqlQuery)
        {
            Console.WriteLine("Selecting data from Oracle database");
        }

        public override void SaveDataAccess(string sqlQuery)
        {
            Console.WriteLine("Inserting data in Oracle database");
        }
    }
}
