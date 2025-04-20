namespace GUI
{
    partial class frmImport
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSaveImport = new Button();
            btnCreateImport = new Button();
            grInputPro = new GroupBox();
            label7 = new Label();
            txtTotalDetail = new TextBox();
            btnDeleteDetail = new Button();
            dtpkExprire = new DateTimePicker();
            btnAddProImport = new Button();
            label5 = new Label();
            txtQuantity = new TextBox();
            txtUnit = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtPurchasePrice = new TextBox();
            label3 = new Label();
            cbbPro = new ComboBox();
            label10 = new Label();
            dgvImportList = new DataGridView();
            label9 = new Label();
            label6 = new Label();
            dtpkImportDate = new DateTimePicker();
            label8 = new Label();
            txtImportId = new TextBox();
            groupBox2.SuspendLayout();
            grInputPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(862, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 38;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 40);
            label1.TabIndex = 37;
            label1.Text = "Nhập hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSaveImport);
            groupBox2.Controls.Add(btnCreateImport);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(9, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(884, 81);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSaveImport
            // 
            btnSaveImport.BackColor = Color.DodgerBlue;
            btnSaveImport.Cursor = Cursors.Hand;
            btnSaveImport.FlatAppearance.BorderSize = 0;
            btnSaveImport.FlatStyle = FlatStyle.Flat;
            btnSaveImport.Font = new Font("Times New Roman", 13.8F);
            btnSaveImport.ForeColor = Color.WhiteSmoke;
            btnSaveImport.Location = new Point(508, 33);
            btnSaveImport.Name = "btnSaveImport";
            btnSaveImport.Size = new Size(150, 35);
            btnSaveImport.TabIndex = 9;
            btnSaveImport.Text = "Lưu";
            btnSaveImport.UseVisualStyleBackColor = false;
            btnSaveImport.Click += btnSaveImport_Click;
            // 
            // btnCreateImport
            // 
            btnCreateImport.BackColor = Color.DodgerBlue;
            btnCreateImport.Cursor = Cursors.Hand;
            btnCreateImport.FlatAppearance.BorderSize = 0;
            btnCreateImport.FlatStyle = FlatStyle.Flat;
            btnCreateImport.Font = new Font("Times New Roman", 13.8F);
            btnCreateImport.ForeColor = Color.WhiteSmoke;
            btnCreateImport.Location = new Point(226, 33);
            btnCreateImport.Name = "btnCreateImport";
            btnCreateImport.Size = new Size(150, 35);
            btnCreateImport.TabIndex = 8;
            btnCreateImport.Text = "Tạo đơn";
            btnCreateImport.UseVisualStyleBackColor = false;
            btnCreateImport.Click += btnCreateImport_Click;
            // 
            // grInputPro
            // 
            grInputPro.Controls.Add(label7);
            grInputPro.Controls.Add(txtTotalDetail);
            grInputPro.Controls.Add(btnDeleteDetail);
            grInputPro.Controls.Add(dtpkExprire);
            grInputPro.Controls.Add(btnAddProImport);
            grInputPro.Controls.Add(label5);
            grInputPro.Controls.Add(txtQuantity);
            grInputPro.Controls.Add(txtUnit);
            grInputPro.Controls.Add(label4);
            grInputPro.Controls.Add(label2);
            grInputPro.Controls.Add(txtPurchasePrice);
            grInputPro.Controls.Add(label3);
            grInputPro.Controls.Add(cbbPro);
            grInputPro.Controls.Add(label10);
            grInputPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInputPro.Location = new Point(9, 173);
            grInputPro.Name = "grInputPro";
            grInputPro.Size = new Size(884, 180);
            grInputPro.TabIndex = 40;
            grInputPro.TabStop = false;
            grInputPro.Text = "Thông tin";
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(602, 83);
            label7.Name = "label7";
            label7.Size = new Size(126, 31);
            label7.TabIndex = 49;
            label7.Text = "Tổng";
            // 
            // txtTotalDetail
            // 
            txtTotalDetail.BackColor = Color.WhiteSmoke;
            txtTotalDetail.Enabled = false;
            txtTotalDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalDetail.Location = new Point(748, 83);
            txtTotalDetail.Name = "txtTotalDetail";
            txtTotalDetail.ReadOnly = true;
            txtTotalDetail.Size = new Size(129, 34);
            txtTotalDetail.TabIndex = 48;
            // 
            // btnDeleteDetail
            // 
            btnDeleteDetail.BackColor = Color.DodgerBlue;
            btnDeleteDetail.Cursor = Cursors.Hand;
            btnDeleteDetail.FlatAppearance.BorderSize = 0;
            btnDeleteDetail.FlatStyle = FlatStyle.Flat;
            btnDeleteDetail.Font = new Font("Times New Roman", 13.8F);
            btnDeleteDetail.ForeColor = Color.WhiteSmoke;
            btnDeleteDetail.Location = new Point(503, 131);
            btnDeleteDetail.Name = "btnDeleteDetail";
            btnDeleteDetail.Size = new Size(150, 35);
            btnDeleteDetail.TabIndex = 12;
            btnDeleteDetail.Text = "Xóa";
            btnDeleteDetail.UseVisualStyleBackColor = false;
            btnDeleteDetail.Click += btnDeleteDetail_Click;
            // 
            // dtpkExprire
            // 
            dtpkExprire.CustomFormat = "dd-MM-yyyy";
            dtpkExprire.Format = DateTimePickerFormat.Custom;
            dtpkExprire.Location = new Point(450, 83);
            dtpkExprire.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpkExprire.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpkExprire.Name = "dtpkExprire";
            dtpkExprire.Size = new Size(129, 34);
            dtpkExprire.TabIndex = 47;
            dtpkExprire.Value = new DateTime(2025, 4, 20, 0, 0, 0, 0);
            // 
            // btnAddProImport
            // 
            btnAddProImport.BackColor = Color.DodgerBlue;
            btnAddProImport.Cursor = Cursors.Hand;
            btnAddProImport.FlatAppearance.BorderSize = 0;
            btnAddProImport.FlatStyle = FlatStyle.Flat;
            btnAddProImport.Font = new Font("Times New Roman", 13.8F);
            btnAddProImport.ForeColor = Color.WhiteSmoke;
            btnAddProImport.Location = new Point(221, 131);
            btnAddProImport.Name = "btnAddProImport";
            btnAddProImport.Size = new Size(150, 35);
            btnAddProImport.TabIndex = 11;
            btnAddProImport.Text = "Thêm";
            btnAddProImport.UseVisualStyleBackColor = false;
            btnAddProImport.Click += btnAddProImport_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 80);
            label5.Name = "label5";
            label5.Size = new Size(126, 31);
            label5.TabIndex = 46;
            label5.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.WhiteSmoke;
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(152, 80);
            txtQuantity.MaxLength = 5;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(129, 34);
            txtQuantity.TabIndex = 45;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Enabled = false;
            txtUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnit.Location = new Point(450, 31);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(129, 34);
            txtUnit.TabIndex = 44;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 83);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 43;
            label4.Text = "Ngày hết hạn";
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(599, 33);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 40;
            label2.Text = "Giá nhập";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.BackColor = Color.WhiteSmoke;
            txtPurchasePrice.Enabled = false;
            txtPurchasePrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPurchasePrice.Location = new Point(748, 31);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.ReadOnly = true;
            txtPurchasePrice.Size = new Size(129, 34);
            txtPurchasePrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 33);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 39;
            label3.Text = "Đơn vị";
            // 
            // cbbPro
            // 
            cbbPro.BackColor = Color.WhiteSmoke;
            cbbPro.FlatStyle = FlatStyle.Flat;
            cbbPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbPro.FormattingEnabled = true;
            cbbPro.Location = new Point(152, 30);
            cbbPro.Name = "cbbPro";
            cbbPro.Size = new Size(129, 36);
            cbbPro.TabIndex = 1;
            cbbPro.SelectedIndexChanged += cbbPro_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 33);
            label10.Name = "label10";
            label10.Size = new Size(129, 31);
            label10.TabIndex = 28;
            label10.Text = "Tên";
            // 
            // dgvImportList
            // 
            dgvImportList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportList.Dock = DockStyle.Bottom;
            dgvImportList.Location = new Point(0, 389);
            dgvImportList.Name = "dgvImportList";
            dgvImportList.RowHeadersWidth = 51;
            dgvImportList.Size = new Size(902, 271);
            dgvImportList.TabIndex = 42;
            // 
            // label9
            // 
            label9.BackColor = Color.LightSkyBlue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(289, 355);
            label9.Name = "label9";
            label9.Size = new Size(335, 31);
            label9.TabIndex = 50;
            label9.Text = "Danh sách nhập hàng";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(463, 52);
            label6.Name = "label6";
            label6.Size = new Size(161, 31);
            label6.TabIndex = 56;
            label6.Text = "Ngày nhập";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpkImportDate
            // 
            dtpkImportDate.CustomFormat = "dd-MM-yyyy";
            dtpkImportDate.Font = new Font("Microsoft Sans Serif", 12F);
            dtpkImportDate.Format = DateTimePickerFormat.Custom;
            dtpkImportDate.Location = new Point(648, 52);
            dtpkImportDate.MaxDate = new DateTime(2025, 4, 20, 0, 0, 0, 0);
            dtpkImportDate.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpkImportDate.Name = "dtpkImportDate";
            dtpkImportDate.Size = new Size(161, 30);
            dtpkImportDate.TabIndex = 54;
            dtpkImportDate.Value = new DateTime(2025, 4, 20, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(93, 52);
            label8.Name = "label8";
            label8.Size = new Size(161, 31);
            label8.TabIndex = 55;
            label8.Text = "Mã nhập";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtImportId
            // 
            txtImportId.BackColor = Color.WhiteSmoke;
            txtImportId.Enabled = false;
            txtImportId.Font = new Font("Microsoft Sans Serif", 12F);
            txtImportId.Location = new Point(278, 52);
            txtImportId.Name = "txtImportId";
            txtImportId.ReadOnly = true;
            txtImportId.Size = new Size(161, 30);
            txtImportId.TabIndex = 53;
            // 
            // frmImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(902, 660);
            Controls.Add(label6);
            Controls.Add(dtpkImportDate);
            Controls.Add(label8);
            Controls.Add(txtImportId);
            Controls.Add(label9);
            Controls.Add(dgvImportList);
            Controls.Add(groupBox2);
            Controls.Add(grInputPro);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmImport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmImport";
            Load += frmImport_Load;
            groupBox2.ResumeLayout(false);
            grInputPro.ResumeLayout(false);
            grInputPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnSaveImport;
        private Button btnCreateImport;
        private GroupBox grInputPro;
        private Label label4;
        private Label label2;
        private TextBox txtPurchasePrice;
        private Label label3;
        private ComboBox cbbPro;
        private Label label10;
        private TextBox txtUnit;
        private Label label5;
        private TextBox txtQuantity;
        private DataGridView dgvImportList;
        private DateTimePicker dtpkExprire;
        private Button btnDeleteDetail;
        private Button btnAddProImport;
        private Label label7;
        private TextBox txtTotalDetail;
        private Label label9;
        private Label label6;
        private DateTimePicker dtpkImportDate;
        private Label label8;
        private TextBox txtImportId;
    }
}