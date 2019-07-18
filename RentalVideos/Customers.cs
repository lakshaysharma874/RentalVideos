using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideos
{
    public partial class Customers : Form
    {
        BAL bal = new BAL();
        public Customers()
        {
            InitializeComponent();
            GetCustomerList();
        }

        /// <summary>
        ///  Customer List
        /// </summary>
        private void GetCustomerList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("SPGetCustomerList");
            dGWCustomerList.DataSource = dt;

        }
        /// <summary>
        /// Back to Tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// Add Customer Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[4];
            sqlparameter[0] = new SqlParameter("@FirstName", textBoxFirstName.Text);
            sqlparameter[1] = new SqlParameter("@LastName", textBoxLastName.Text);
            sqlparameter[2] = new SqlParameter("@Address", textBoxAddress.Text);
            sqlparameter[3] = new SqlParameter("@Phone", textBoxPhoneNumber.Text);
            dt = bal.geDataTableWithParamter("SPInsertUpdateCustomer", sqlparameter);
            GetCustomerList();
            MessageBox.Show("Customer updated successfully");
        }
        /// <summary>
        /// Update Customer Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[5];
            sqlparameter[0] = new SqlParameter("@FirstName", textBoxFirstName.Text);
            sqlparameter[1] = new SqlParameter("@LastName", textBoxLastName.Text);
            sqlparameter[2] = new SqlParameter("@Address", textBoxAddress.Text);
            sqlparameter[3] = new SqlParameter("@Phone", textBoxPhoneNumber.Text);
            sqlparameter[4] = new SqlParameter("@CustID", textBoxCustID.Text);
            bal.geDataTableWithParamter("SPInsertUpdateCustomer", sqlparameter);
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxCustID.Text = "";
            GetCustomerList();
            MessageBox.Show("Customer updated successfully");
        }
        /// <summary>
        /// Delete Customer Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[1];
            sqlparameter[0] = new SqlParameter("@customerID", textBoxCustID.Text);
            bal.geDataTableWithParamter("SPDeleteCustomers", sqlparameter);
            GetCustomerList();
            MessageBox.Show("Customer deleted successfully");
        }
        /// <summary>
        /// Ppulate textbox with data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
                textBoxCustID.Text = row.Cells[0].Value.ToString();
                textBoxFirstName.Text = row.Cells[1].Value.ToString();
                textBoxLastName.Text = row.Cells[2].Value.ToString();
                textBoxAddress.Text = row.Cells[3].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells[4].Value.ToString();
            }

        }
    }
}
