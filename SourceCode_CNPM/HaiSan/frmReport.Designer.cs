namespace GUI
{
    partial class frmReport
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
            groupBox3 = new GroupBox();
            dtpkToDate = new DateTimePicker();
            label13 = new Label();
            dtpkFromDate = new DateTimePicker();
            btnStatistic = new Button();
            label12 = new Label();
            btnExportFile = new Button();
            label6 = new Label();
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            txtNumCus = new TextBox();
            label10 = new Label();
            txtRevenueAfter = new TextBox();
            label3 = new Label();
            txtRevenueBefore = new TextBox();
            label2 = new Label();
            txtNumOrder = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            txtProfit = new TextBox();
            label8 = new Label();
            txtTotalLoss = new TextBox();
            label4 = new Label();
            txtTotalImp = new TextBox();
            label5 = new Label();
            txtNumImp = new TextBox();
            label7 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpkToDate);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(dtpkFromDate);
            groupBox3.Controls.Add(btnStatistic);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnExportFile);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(924, 81);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // dtpkToDate
            // 
            dtpkToDate.CustomFormat = "dd-MM-yyyy";
            dtpkToDate.Format = DateTimePickerFormat.Custom;
            dtpkToDate.Location = new Point(494, 36);
            dtpkToDate.MaxDate = new DateTime(2025, 4, 22, 0, 0, 0, 0);
            dtpkToDate.MinDate = new DateTime(2025, 1, 2, 0, 0, 0, 0);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(129, 34);
            dtpkToDate.TabIndex = 51;
            dtpkToDate.Value = new DateTime(2025, 4, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.BackColor = Color.LightSkyBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(336, 38);
            label13.Name = "label13";
            label13.Size = new Size(129, 31);
            label13.TabIndex = 50;
            label13.Text = "Từ ngày:";
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.CustomFormat = "dd-MM-yyyy";
            dtpkFromDate.Format = DateTimePickerFormat.Custom;
            dtpkFromDate.Location = new Point(178, 36);
            dtpkFromDate.MaxDate = new DateTime(2025, 4, 22, 0, 0, 0, 0);
            dtpkFromDate.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(129, 34);
            dtpkFromDate.TabIndex = 49;
            dtpkFromDate.Value = new DateTime(2025, 4, 22, 0, 0, 0, 0);
            // 
            // btnStatistic
            // 
            btnStatistic.BackColor = Color.DodgerBlue;
            btnStatistic.Cursor = Cursors.Hand;
            btnStatistic.FlatAppearance.BorderSize = 0;
            btnStatistic.FlatStyle = FlatStyle.Flat;
            btnStatistic.Font = new Font("Times New Roman", 12F);
            btnStatistic.ForeColor = Color.WhiteSmoke;
            btnStatistic.Location = new Point(652, 36);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(110, 34);
            btnStatistic.TabIndex = 8;
            btnStatistic.Text = "Thống kê";
            btnStatistic.UseVisualStyleBackColor = false;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.LightSkyBlue;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 38);
            label12.Name = "label12";
            label12.Size = new Size(129, 31);
            label12.TabIndex = 48;
            label12.Text = "Từ ngày:";
            // 
            // btnExportFile
            // 
            btnExportFile.BackColor = Color.DodgerBlue;
            btnExportFile.Cursor = Cursors.Hand;
            btnExportFile.FlatAppearance.BorderSize = 0;
            btnExportFile.FlatStyle = FlatStyle.Flat;
            btnExportFile.Font = new Font("Times New Roman", 12F);
            btnExportFile.ForeColor = Color.WhiteSmoke;
            btnExportFile.Location = new Point(789, 36);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.Size = new Size(112, 34);
            btnExportFile.TabIndex = 9;
            btnExportFile.Text = "Xuất file";
            btnExportFile.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(238, 337);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 15;
            label6.Text = "DANH SÁCH SẢN PHẨM";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(0, 378);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(950, 232);
            dgvProduct.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNumCus);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtRevenueAfter);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRevenueBefore);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNumOrder);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 103);
            panel1.TabIndex = 13;
            // 
            // txtNumCus
            // 
            txtNumCus.BackColor = Color.WhiteSmoke;
            txtNumCus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCus.Location = new Point(682, 47);
            txtNumCus.Name = "txtNumCus";
            txtNumCus.Size = new Size(207, 34);
            txtNumCus.TabIndex = 16;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(683, 13);
            label10.Name = "label10";
            label10.Size = new Size(207, 31);
            label10.TabIndex = 15;
            label10.Text = "Số khách hàng";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRevenueAfter
            // 
            txtRevenueAfter.BackColor = Color.WhiteSmoke;
            txtRevenueAfter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRevenueAfter.Location = new Point(466, 47);
            txtRevenueAfter.Name = "txtRevenueAfter";
            txtRevenueAfter.Size = new Size(207, 34);
            txtRevenueAfter.TabIndex = 14;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(467, 13);
            label3.Name = "label3";
            label3.Size = new Size(207, 31);
            label3.TabIndex = 13;
            label3.Text = "Doanh thu sau giảm";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRevenueBefore
            // 
            txtRevenueBefore.BackColor = Color.WhiteSmoke;
            txtRevenueBefore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRevenueBefore.Location = new Point(250, 47);
            txtRevenueBefore.Name = "txtRevenueBefore";
            txtRevenueBefore.Size = new Size(207, 34);
            txtRevenueBefore.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 13);
            label2.Name = "label2";
            label2.Size = new Size(207, 31);
            label2.TabIndex = 12;
            label2.Text = "Doanh thu trước giảm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumOrder
            // 
            txtNumOrder.BackColor = Color.WhiteSmoke;
            txtNumOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumOrder.Location = new Point(34, 47);
            txtNumOrder.Name = "txtNumOrder";
            txtNumOrder.Size = new Size(207, 34);
            txtNumOrder.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 10;
            label1.Text = "Số đơn hàng:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtProfit);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtTotalLoss);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTotalImp);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNumImp);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(14, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 113);
            panel2.TabIndex = 17;
            // 
            // label9
            // 
            label9.BackColor = Color.Tomato;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(282, 0);
            label9.Name = "label9";
            label9.Size = new Size(358, 31);
            label9.TabIndex = 15;
            label9.Text = "Chỉ admin được xem";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProfit
            // 
            txtProfit.BackColor = Color.WhiteSmoke;
            txtProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfit.Location = new Point(672, 74);
            txtProfit.Name = "txtProfit";
            txtProfit.Size = new Size(155, 34);
            txtProfit.TabIndex = 28;
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(672, 40);
            label8.Name = "label8";
            label8.Size = new Size(155, 30);
            label8.TabIndex = 27;
            label8.Text = "Tổng lãi";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalLoss
            // 
            txtTotalLoss.BackColor = Color.WhiteSmoke;
            txtTotalLoss.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalLoss.Location = new Point(480, 74);
            txtTotalLoss.Name = "txtTotalLoss";
            txtTotalLoss.Size = new Size(155, 34);
            txtTotalLoss.TabIndex = 26;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(480, 40);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 25;
            label4.Text = "Tổng lỗ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalImp
            // 
            txtTotalImp.BackColor = Color.WhiteSmoke;
            txtTotalImp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalImp.Location = new Point(288, 74);
            txtTotalImp.Name = "txtTotalImp";
            txtTotalImp.Size = new Size(155, 34);
            txtTotalImp.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(288, 40);
            label5.Name = "label5";
            label5.Size = new Size(155, 30);
            label5.TabIndex = 24;
            label5.Text = "Tổng nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumImp
            // 
            txtNumImp.BackColor = Color.WhiteSmoke;
            txtNumImp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumImp.Location = new Point(96, 74);
            txtNumImp.Name = "txtNumImp";
            txtNumImp.Size = new Size(155, 34);
            txtNumImp.TabIndex = 21;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(96, 40);
            label7.Name = "label7";
            label7.Size = new Size(155, 30);
            label7.TabIndex = 22;
            label7.Text = "Số đơn nhập";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 610);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(label6);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReport";
            Load += frmReport_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnDeletePro;
        private Button btnInventory;
        private Label label6;
        private DataGridView dgvProduct;
        private Panel panel1;
        private TextBox txtRevenueAfter;
        private Label label3;
        private TextBox txtRevenueBefore;
        private Label label2;
        private TextBox txtNumOrder;
        private Label label1;
        private Panel panel2;
        private TextBox txtTotalLoss;
        private Label label4;
        private TextBox txtTotalImp;
        private Label label5;
        private TextBox txtNumImp;
        private Label label7;
        private TextBox txtProfit;
        private Label label8;
        private TextBox txtNumCus;
        private Label label10;
        private Label label9;
        private TextBox textBox8;
        private Label label11;
        private DateTimePicker dtpkToDate;
        private Label label13;
        private DateTimePicker dtpkFromDate;
        private Label label12;
        Button btnStatistic;
        Button btnExportFile;
    }
}