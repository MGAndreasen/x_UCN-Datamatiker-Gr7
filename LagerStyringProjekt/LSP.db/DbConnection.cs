using System;
using DatabasesSimpleADO.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.db
{
    public class DbConnection
    {

        public void getConnection()
        {
            connectionString = ConfigurationManager.ConnectionString["Default"].ConnectionString;
        }
                }
}
