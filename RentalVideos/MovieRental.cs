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
    public partial class MovieRental : Form
    {
        BAL bal = new BAL();
        public MovieRental()
        {
            InitializeComponent();
            GetCustomerList();
            GetMovieList();
            GetRentalList();
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
        /// Get Movies List
        /// </summary>
        private void GetMovieList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("SPGetMovieList");
            dGWMovieList.DataSource = dt;

        }
        /// <summary>
        /// Get Rental Movies List
        /// </summary>
        private void GetRentalList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("SPGetRentalList");
            dgWMovieRentalList.DataSource = dt;

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// Issue Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[2];
            sqlparameter[0] = new SqlParameter("@customerID", textCustID.Text);
            sqlparameter[1] = new SqlParameter("@movieID", textBoxMovieID.Text);
            bal.geDataTableWithParamter("SPInsertRentalIssueMovie", sqlparameter);
            GetRentalList();
            MessageBox.Show("Movie rented to the customer");
        }
        /// <summary>
        /// Return Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[1];
            sqlparameter[0] = new SqlParameter("@rentalID", textBoxRentalID.Text);
            bal.geDataTableWithParamter("SPUpdateRentalReturnMovie", sqlparameter);
            GetRentalList();
            MessageBox.Show("Movie returned by the customer");
        }
        /// <summary>
        /// populate Rental Record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgWMovieRentalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgWMovieRentalList.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxRentalID.Text = row.Cells[0].Value.ToString();
                textBoxFName.Text = row.Cells[1].Value.ToString();
                textBoxLName.Text = row.Cells[2].Value.ToString();
                textBoxRentalCost.Text = row.Cells[5].Value.ToString();
            }
        }
        /// <summary>
        /// Ppulate Customer details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
            textCustID.Text = row.Cells[0].Value.ToString();
            textBoxFName.Text = row.Cells[1].Value.ToString();
            textBoxLName.Text = row.Cells[2].Value.ToString();
        }
        /// <summary>
        /// populate Movie Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMovieList.Rows[e.RowIndex];
            textBoxMovieID.Text = row.Cells[0].Value.ToString();
            textBoxTitle.Text = row.Cells[1].Value.ToString();
            textBoxGenre.Text = row.Cells[2].Value.ToString();
            textBoxRentalCost.Text = row.Cells[3].Value.ToString();
            textBoxPlot.Text = row.Cells[4].Value.ToString();
        }
        /// <summary>
        /// All Rented List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAllRented_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "A");
            dt = bal.geDataTableWithParamter("GetMoviesRentalList", sp);
            dgWMovieRentalList.DataSource = dt;
        }
        /// <summary>
        /// Out Rented List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOutRented_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "O");
            dt = bal.geDataTableWithParamter("GetMoviesRentalList", sp);
            dgWMovieRentalList.DataSource = dt;
        }
    }
}
