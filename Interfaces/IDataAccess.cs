using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IDataAccess
    {
        string LoadConnectionString();

        void LoadDataAccess(string sqlQuery);

        void SaveDataAccess(string sqlQuery);
    }
}
