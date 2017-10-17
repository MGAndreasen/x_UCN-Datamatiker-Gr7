using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DbLayer
{
    class DbConnection
    {

        private string connectionString;


        public DbConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        }

        public List<Customer> getAllAcounts()
        {
            using (SqlConnection sqlCon = new SqlConnection(this.connectionString))
            {
                List<Customer> acList = new List<Customer>();
                SqlCommand cmd = new SqlCommand("Select Id, CustomerId, Balance from dbo.Account", sqlCon);
                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer accmeldmig = new Customer();
                    accmeldmig.AccountId = reader.GetInt32(0);
                    accmeldmig.CustomerId = reader.GetInt32(1);
                    accmeldmig.Balance = reader.GetFloat(2);
                    acList.Add(accmeldmig);

                }
                return acList;



            }
        }
    }
}
