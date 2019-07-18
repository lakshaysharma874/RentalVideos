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
    public partial class Movies : Form
    {
        BAL bal = new BAL();
        public Movies()
        {
            InitializeComponent();
            GetMovieList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// Get Movies List
        /// </summary>
        private void GetMovieList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("SPGetMovieList");
            dGWMoviesList.DataSource = dt;

        }
        /// <summary>
        /// Add movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[4];
            sqlparameter[0] = new SqlParameter("@Title", textBoxTitle.Text);
            sqlparameter[1] = new SqlParameter("@Rental_Cost", textBoxRentalCost.Text);
            sqlparameter[2] = new SqlParameter("@Genre", textBoxGenre.Text);
            sqlparameter[3] = new SqlParameter("@Plot", textBoxPlot.Text);
            bal.geDataTableWithParamter("SPInsertUpdateMovies", sqlparameter);
            GetMovieList();
            MessageBox.Show("Movie saved successfully");
        }
        /// <summary>
        /// update movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[5];
            sqlparameter[0] = new SqlParameter("@Title", textBoxTitle.Text);
            sqlparameter[1] = new SqlParameter("@Rental_Cost", textBoxRentalCost.Text);
            sqlparameter[2] = new SqlParameter("@Genre", textBoxGenre.Text);
            sqlparameter[3] = new SqlParameter("@Plot", textBoxPlot.Text);
            sqlparameter[4] = new SqlParameter("@MovieID", textBoxMovieID.Text);
            bal.geDataTableWithParamter("SPInsertUpdateMovies", sqlparameter);
            GetMovieList();
            MessageBox.Show("Movie updated successfully");
        }
        /// <summary>
        /// delete movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlparameter = new SqlParameter[1];
            sqlparameter[0] = new SqlParameter("@movieID", textBoxMovieID.Text);
            bal.geDataTableWithParamter("SPDeleteMovies", sqlparameter);
            GetMovieList();
            MessageBox.Show("Movie deleted successfully");
        }
        /// <summary>
        /// populate Movie Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWMoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMoviesList.Rows[e.RowIndex];
            textBoxMovieID.Text = row.Cells[0].Value.ToString();
            textBoxTitle.Text = row.Cells[1].Value.ToString();
            textBoxGenre.Text = row.Cells[2].Value.ToString();
            textBoxRentalCost.Text = row.Cells[3].Value.ToString();
            textBoxPlot.Text = row.Cells[4].Value.ToString();
        }
    }
}
