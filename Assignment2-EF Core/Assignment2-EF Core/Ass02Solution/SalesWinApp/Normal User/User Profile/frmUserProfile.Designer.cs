namespace SalesWinApp.Normal_User
{
    partial class frmUserProfile
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            label2 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnClose = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(375, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(206, 228);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(375, 27);
            txtCity.TabIndex = 3;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 231);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "City";
            label2.Click += label2_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(206, 289);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(375, 27);
            txtCountry.TabIndex = 5;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 292);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(206, 169);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(375, 27);
            txtCompanyName.TabIndex = 7;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 172);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Company Name";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(206, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(225, 27);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 112);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(240, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 39);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(426, 359);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 39);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(453, 106);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(128, 33);
            btnShowPassword.TabIndex = 12;
            btnShowPassword.Text = "Show Password";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // frmUserProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(672, 438);
            Controls.Add(btnShowPassword);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "frmUserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            FormClosing += frmUserProfile_FormClosing;
            Load += frmUserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnShowPassword;
    }
}