using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LSP.db
{
    public class DbConnection
    {
        private string connectionString;




        public DbConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; 

        }

    }
}
