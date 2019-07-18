namespace RentalVideos
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.dGWCustomerList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(427, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(436, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(185, 6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(206, 37);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(561, 9);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(206, 37);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(561, 73);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(206, 37);
            this.textBoxPhoneNumber.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(185, 73);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(206, 37);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(12, 6);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(49, 37);
            this.textBoxCustID.TabIndex = 8;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(185, 139);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(178, 73);
            this.buttonAddCustomer.TabIndex = 9;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // dGWCustomerList
            // 
            this.dGWCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWCustomerList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGWCustomerList.Location = new System.Drawing.Point(12, 242);
            this.dGWCustomerList.Name = "dGWCustomerList";
            this.dGWCustomerList.Size = new System.Drawing.Size(755, 269);
            this.dGWCustomerList.TabIndex = 10;
            this.dGWCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWCustomerList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customers List";
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(389, 139);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(178, 73);
            this.buttonUpdateCustomer.TabIndex = 12;
            this.buttonUpdateCustomer.Text = "Update Customer";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(589, 139);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(178, 73);
            this.buttonDeleteCustomer.TabIndex = 13;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(692, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(792, 515);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonUpdateCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGWCustomerList);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.DataGridView dGWCustomerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button btnBack;
    }
}