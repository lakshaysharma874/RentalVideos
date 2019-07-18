namespace RentalVideos
{
    partial class Tabs
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRentalMovies = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(103, 52);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(189, 75);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRentalMovies
            // 
            this.btnRentalMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalMovies.Location = new System.Drawing.Point(295, 220);
            this.btnRentalMovies.Name = "btnRentalMovies";
            this.btnRentalMovies.Size = new System.Drawing.Size(189, 75);
            this.btnRentalMovies.TabIndex = 1;
            this.btnRentalMovies.Text = "Rental Movies";
            this.btnRentalMovies.UseVisualStyleBackColor = true;
            this.btnRentalMovies.Click += new System.EventHandler(this.btnRentalMovies_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(480, 52);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(189, 75);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnRentalMovies);
            this.Controls.Add(this.btnCustomers);
            this.Name = "Tabs";
            this.Text = "Tabs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnRentalMovies;
        private System.Windows.Forms.Button btnMovies;
    }
}