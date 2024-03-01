namespace SalesWinApp.Admin.Product_Management
{
    partial class frmUpdateProduct
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
            txtUnitInStock = new TextBox();
            label5 = new Label();
            txtUnitPrice = new TextBox();
            label3 = new Label();
            txtWeight = new TextBox();
            label4 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtProductID = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(172, 315);
            txtUnitInStock.MaxLength = 15;
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(251, 27);
            txtUnitInStock.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 318);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 34;
            label5.Text = "Units In Stock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(172, 249);
            txtUnitPrice.MaxLength = 15;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(251, 27);
            txtUnitPrice.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 252);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 32;
            label3.Text = "Unit Price";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(172, 183);
            txtWeight.MaxLength = 20;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(251, 27);
            txtWeight.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 186);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 30;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(172, 117);
            txtProductName.MaxLength = 40;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(251, 27);
            txtProductName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 120);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 28;
            label2.Text = "Product Name";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(172, 51);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(251, 27);
            txtProductID.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 26;
            label1.Text = "Product ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(281, 394);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(101, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUpdateProduct
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(496, 472);
            Controls.Add(btnUpdate);
            Controls.Add(txtUnitInStock);
            Controls.Add(label5);
            Controls.Add(txtUnitPrice);
            Controls.Add(label3);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductID);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "frmUpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUpdateProduct";
            FormClosing += frmUpdateProduct_FormClosing;
            Load += frmUpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnitInStock;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtProductID;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}