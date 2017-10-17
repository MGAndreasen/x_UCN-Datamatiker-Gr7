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

        public ShowCustomersWindF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Customer Cust = new Customer();

          //  listView1.Items.Add.DBConnection.GetAllAccounts(); 


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }
    }
}
