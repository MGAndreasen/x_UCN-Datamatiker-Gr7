using LSP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSP.DbLayer; 

namespace LSP_Admin
{
    public partial class ShowCustomersWindF : Form
    {

        Customer Cust;
        IDbConnection dbCon;

        public ShowCustomersWindF()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dbCon.GetAllAccounts(id, navn); 


        }
    }
}
