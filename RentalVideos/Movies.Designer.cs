namespace RentalVideos
{
    partial class Movies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRentalCost = new System.Windows.Forms.TextBox();
            this.textBoxPlot = new System.Windows.Forms.TextBox();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dGWMoviesList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMoviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(510, 12);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(171, 37);
            this.textBoxGenre.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(208, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(171, 37);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(12, 12);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(57, 37);
            this.textBoxMovieID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rental Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plot";
            // 
            // textBoxRentalCost
            // 
            this.textBoxRentalCost.Location = new System.Drawing.Point(208, 63);
            this.textBoxRentalCost.Name = "textBoxRentalCost";
            this.textBoxRentalCost.Size = new System.Drawing.Size(171, 37);
            this.textBoxRentalCost.TabIndex = 9;
            // 
            // textBoxPlot
            // 
            this.textBoxPlot.Location = new System.Drawing.Point(510, 63);
            this.textBoxPlot.Name = "textBoxPlot";
            this.textBoxPlot.Size = new System.Drawing.Size(171, 37);
            this.textBoxPlot.TabIndex = 10;
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(82, 149);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(176, 41);
            this.buttonAddMovie.TabIndex = 11;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.Location = new System.Drawing.Point(286, 149);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(176, 41);
            this.buttonUpdateMovie.TabIndex = 12;
            this.buttonUpdateMovie.Text = "Update Movie";
            this.buttonUpdateMovie.UseVisualStyleBackColor = true;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(510, 149);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(176, 41);
            this.buttonDeleteMovie.TabIndex = 13;
            this.buttonDeleteMovie.Text = "Delete Movie";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Movies List";
            // 
            // dGWMoviesList
            // 
            this.dGWMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMoviesList.Location = new System.Drawing.Point(12, 242);
            this.dGWMoviesList.Name = "dGWMoviesList";
            this.dGWMoviesList.Size = new System.Drawing.Size(674, 278);
            this.dGWMoviesList.TabIndex = 15;
            this.dGWMoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWMoviesList_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(611, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(693, 523);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dGWMoviesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.textBoxPlot);
            this.Controls.Add(this.textBoxRentalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxGenre);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Movies";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dGWMoviesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.TextBox textBoxPlot;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGWMoviesList;
        private System.Windows.Forms.Button btnBack;
    }
}