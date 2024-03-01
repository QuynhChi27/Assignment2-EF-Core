namespace SalesWinApp.Admin.Member_Management
{
    partial class frmAddMember
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
            btnClose = new Button();
            txtPassword = new TextBox();
            label5 = new Label();
            txtCountry = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(309, 372);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(195, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(289, 27);
            txtPassword.TabIndex = 23;
            txtPassword.Text = "123";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 115);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 22;
            label5.Text = "Password";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(195, 299);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(289, 27);
            txtCountry.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 301);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 20;
            label6.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(195, 237);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(289, 27);
            txtCity.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 240);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 18;
            label3.Text = "City";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(195, 175);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(289, 27);
            txtCompanyName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 179);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 16;
            label4.Text = "Company Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 51);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 27);
            txtEmail.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 53);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 373);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 40);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddMember
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(531, 460);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Name = "frmAddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Member";
            FormClosing += frmAddMember_FormClosing;
            Load += frmAddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtCountry;
        private Label label6;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private Button btnAdd;
    }
}