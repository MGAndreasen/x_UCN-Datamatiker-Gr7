using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DbLayer
{
    class DbConnection
    {

        private string connectionString;


        public DbConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        }
    }
}
