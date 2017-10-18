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

        public List<Customer> getAllAcounts(int id, string navn)
        {
            using (SqlConnection sqlCon = new SqlConnection(this.connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("Select from dba.Person Id, navn, efternavn, adresse, city, postnummer VALUES (@id, @navn, @efternavn, @adresse, @city, @postnummer)", sqlCon);
                cmd.Parameters.Add("@id", sqlDbType.Int).Value = id;
                cmd.Parameters.Add("@navn", sqlDbType.VarChar).Value = navn; 


            }
        }
    }
}
