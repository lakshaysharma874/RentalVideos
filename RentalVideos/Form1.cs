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
    public partial class Form1 : Form
    {
        BAL businessLogic = new BAL();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Login Check 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[2];
            sqlparameter[0] = new SqlParameter("@userid", textUserName.Text);

            sqlparameter[1] = new SqlParameter("@pwd", textPassword.Text);
            dt = businessLogic.geDataTableWithParamter("SPuserLogin", sqlparameter);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    this.Hide();
                    Tabs _tabs = new Tabs();
                    _tabs.ShowDialog();

                }

            }
            else
            {
                textUserName.Text = "";
                textPassword.Text = "";
                MessageBox.Show("Login ID and Password is incorrect.");
            }
        }
    }
}
