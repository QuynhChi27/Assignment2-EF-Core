namespace SalesWinApp.Normal_User
{
    partial class frmUserOrders
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
            dgvOrders = new DataGridView();
            label1 = new Label();
            btnClose = new Button();
            btnRead = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(36, 105);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new Size(729, 240);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellClick += dgvOrders_CellClick;
            dgvOrders.DataBindingComplete += dgvOrders_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(307, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 2;
            label1.Text = "Your Orders";
            label1.Click += label1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(461, 385);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(227, 385);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(120, 35);
            btnRead.TabIndex = 13;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // frmUserOrders
            // 
            AcceptButton = btnRead;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 458);
            Controls.Add(btnRead);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Name = "frmUserOrders";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            FormClosing += frmUserOrders_FormClosing;
            Load += frmUserOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Label label1;
        private Button btnClose;
        private Button btnRead;
    }
}