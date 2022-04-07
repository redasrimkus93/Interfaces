using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LoginuInformacija($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            _logger.LoginuInformacija($"Migration ended at {DateTime.Now}");
        }
    }
}
