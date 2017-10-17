using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using LSP.models;

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
                SqlCommand cmd = new SqlCommand("Select Id, navn, efternavn, adresse, city, postnummer (@id, @navn, @efternavn, @adresse, @city, @postnummer) from dbo.Person", sqlCon);
                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer CustomerList = new Customer();

                    CustomerList.id = reader.GetInt32(0);
                    CustomerList.navn = reader.GetInt32(0);
                    CustomerList.efternavn = reader.GetInt32(0);
                    CustomerList.adresse = reader.GetInt32(0);
                    CustomerList.city = reader.GetInt32(0);
                    CustomerList.postnummer = reader.GetInt32(0);
                }
                return acList;



            }
        }
    }
}
