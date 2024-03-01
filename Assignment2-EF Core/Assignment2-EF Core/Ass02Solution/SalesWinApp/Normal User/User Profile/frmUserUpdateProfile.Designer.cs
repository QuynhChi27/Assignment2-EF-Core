namespace SalesWinApp.Normal_User
{
    partial class frmUserUpdateProfile
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
            txtSubmitPassword = new TextBox();
            label5 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtSubmitPassword
            // 
            txtSubmitPassword.Location = new Point(206, 109);
            txtSubmitPassword.Name = "txtSubmitPassword";
            txtSubmitPassword.PasswordChar = '*';
            txtSubmitPassword.Size = new Size(375, 27);
            txtSubmitPassword.TabIndex = 19;
            txtSubmitPassword.TextChanged += txtSubmitPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 112);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 18;
            label5.Text = "Submit Password";
            label5.Click += label5_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(206, 169);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(375, 27);
            txtCompanyName.TabIndex = 17;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 172);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 16;
            label4.Text = "Company Name";
            label4.Click += label4_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(206, 289);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(375, 27);
            txtCountry.TabIndex = 15;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 292);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 14;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(206, 228);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(375, 27);
            txtCity.TabIndex = 13;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 231);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 12;
            label2.Text = "City";
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(206, 49);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(375, 27);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 10;
            label1.Text = "New Password";
            label1.Click += label1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(426, 359);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 39);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(240, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 39);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUserUpdateProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(672, 438);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtSubmitPassword);
            Controls.Add(label5);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "frmUserUpdateProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Profile";
            FormClosing += frmUserUpdateProfile_FormClosing;
            Load += frmUserUpdateProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubmitPassword;
        private Label label5;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}