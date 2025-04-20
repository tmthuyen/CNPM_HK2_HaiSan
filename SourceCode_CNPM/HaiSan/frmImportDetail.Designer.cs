namespace GUI
{
    partial class frmImportDetail
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
            btnExit = new Button();
            panel1 = new Panel();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            txtImportDate = new TextBox();
            label3 = new Label();
            txtImportId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtQuantityImport = new TextBox();
            label6 = new Label();
            dgvImportList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(823, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 35);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtImportDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtImportId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantityImport);
            panel1.Location = new Point(15, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 120);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.WhiteSmoke;
            txtTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(592, 74);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(214, 34);
            txtTotalAmount.TabIndex = 13;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 77);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 12;
            label4.Text = "Tổng tiền";
            // 
            // txtImportDate
            // 
            txtImportDate.BackColor = Color.WhiteSmoke;
            txtImportDate.Enabled = false;
            txtImportDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportDate.Location = new Point(187, 74);
            txtImportDate.Name = "txtImportDate";
            txtImportDate.ReadOnly = true;
            txtImportDate.Size = new Size(214, 34);
            txtImportDate.TabIndex = 11;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 8;
            label3.Text = "Ngày nhập";
            // 
            // txtImportId
            // 
            txtImportId.BackColor = Color.WhiteSmoke;
            txtImportId.Enabled = false;
            txtImportId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportId.Location = new Point(187, 16);
            txtImportId.Name = "txtImportId";
            txtImportId.ReadOnly = true;
            txtImportId.Size = new Size(214, 34);
            txtImportId.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 10;
            label1.Text = "Mã nhập hàng";
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 19);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 7;
            label2.Text = "Số sản phẩm";
            // 
            // txtQuantityImport
            // 
            txtQuantityImport.BackColor = Color.WhiteSmoke;
            txtQuantityImport.Enabled = false;
            txtQuantityImport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityImport.Location = new Point(592, 16);
            txtQuantityImport.Name = "txtQuantityImport";
            txtQuantityImport.ReadOnly = true;
            txtQuantityImport.Size = new Size(214, 34);
            txtQuantityImport.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 193);
            label6.Name = "label6";
            label6.Size = new Size(411, 38);
            label6.TabIndex = 17;
            label6.Text = "CHI TIẾT NHẬP HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvImportList
            // 
            dgvImportList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportList.Dock = DockStyle.Bottom;
            dgvImportList.GridColor = Color.White;
            dgvImportList.Location = new Point(0, 243);
            dgvImportList.Name = "dgvImportList";
            dgvImportList.RowHeadersWidth = 51;
            dgvImportList.Size = new Size(853, 232);
            dgvImportList.TabIndex = 18;
            // 
            // frmImportDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 475);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(dgvImportList);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmImportDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmImportDetail";
            Load += frmImportDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private TextBox txtImportDate;
        private Label label3;
        private TextBox txtImportId;
        private Label label1;
        private Label label2;
        private TextBox txtQuantityImport;
        private Label label6;
        private DataGridView dgvImportList;
        private TextBox txtTotalAmount;
        private Label label4;
    }
}