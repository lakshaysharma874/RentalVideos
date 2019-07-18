using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideos
{
    public partial class Tabs : Form
    {
        public Tabs()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show Customer Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.ShowDialog();
        }
        /// <summary>
        /// Show Movies Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMovies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies _movies = new Movies();
            _movies.ShowDialog();
        }

        /// <summary>
        /// Show Movies Rental Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRentalMovies_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieRental movieRental = new MovieRental();
            movieRental.ShowDialog();
        }
    }
}
