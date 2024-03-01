namespace SalesWinApp
{
    partial class frmProducts
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
            btnRead = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            dgvProducts = new DataGridView();
            txtSearch = new TextBox();
            txtSearchCatagory = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 28);
            label1.Name = "label1";
            label1.Size = new Size(335, 45);
            label1.TabIndex = 13;
            label1.Text = "Product Management";
            label1.Click += label1_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(83, 451);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(120, 35);
            btnRead.TabIndex = 12;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(343, 524);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(600, 451);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(433, 451);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(257, 451);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 35);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(36, 170);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(729, 240);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.DataBindingComplete += dgvProducts_DataBindingComplete;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(54, 107);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtSearchCatagory
            // 
            txtSearchCatagory.FormattingEnabled = true;
            txtSearchCatagory.Items.AddRange(new object[] { "By ID", "By Name", "By UnitPrice", "By UnitsInStock" });
            txtSearchCatagory.Location = new Point(461, 106);
            txtSearchCatagory.Name = "txtSearchCatagory";
            txtSearchCatagory.Size = new Size(129, 28);
            txtSearchCatagory.TabIndex = 15;
            txtSearchCatagory.SelectedIndexChanged += txtSearchCatagory_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(626, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 28);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmProducts
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 600);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchCatagory);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            FormClosing += frmProducts_FormClosing;
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRead;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private ComboBox txtSearchCatagory;
        private Button btnSearch;
    }
}