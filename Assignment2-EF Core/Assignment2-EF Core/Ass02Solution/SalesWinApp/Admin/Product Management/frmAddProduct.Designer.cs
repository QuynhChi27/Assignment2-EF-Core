namespace SalesWinApp.Admin.Product_Management
{
    partial class frmAddProduct
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
            btnClose = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(174, 266);
            txtUnitInStock.MaxLength = 15;
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(251, 27);
            txtUnitInStock.TabIndex = 33;
            txtUnitInStock.TextChanged += txtUnitInStock_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 269);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 32;
            label5.Text = "Units In Stock";
            label5.Click += label5_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(174, 200);
            txtUnitPrice.MaxLength = 15;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(251, 27);
            txtUnitPrice.TabIndex = 31;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 203);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 30;
            label3.Text = "Unit Price";
            label3.Click += label3_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(174, 134);
            txtWeight.MaxLength = 20;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(251, 27);
            txtWeight.TabIndex = 29;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 137);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 28;
            label4.Text = "Weight";
            label4.Click += label4_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(174, 68);
            txtProductName.MaxLength = 40;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(251, 27);
            txtProductName.TabIndex = 27;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 71);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 26;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(284, 347);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(98, 347);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 35);
            btnCreate.TabIndex = 34;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmAddProduct
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(496, 436);
            Controls.Add(btnCreate);
            Controls.Add(txtUnitInStock);
            Controls.Add(label5);
            Controls.Add(txtUnitPrice);
            Controls.Add(label3);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmAddProduct_FormClosing;
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
        private Button btnClose;
        private Button btnCreate;
    }
}