namespace GUI
{
    partial class frmCustomer
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
            dgvCusList = new DataGridView();
            label1 = new Label();
            txtCusId = new TextBox();
            txtCusPhone = new TextBox();
            label2 = new Label();
            txtCusPoint = new TextBox();
            label3 = new Label();
            txtCusName = new TextBox();
            label4 = new Label();
            pnCusInfo = new Panel();
            btnCancel = new Button();
            btnSearch = new Button();
            label6 = new Label();
            cbbOrderCusList = new ComboBox();
            grbCusHistory = new GroupBox();
            label5 = new Label();
            btnSeeOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCusList).BeginInit();
            pnCusInfo.SuspendLayout();
            grbCusHistory.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCusList
            // 
            dgvCusList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCusList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusList.Dock = DockStyle.Bottom;
            dgvCusList.Location = new Point(0, 302);
            dgvCusList.Name = "dgvCusList";
            dgvCusList.RowHeadersWidth = 51;
            dgvCusList.Size = new Size(950, 308);
            dgvCusList.TabIndex = 15;
            dgvCusList.CellClick += dgvCusList_CellClick;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 14);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng:";
            // 
            // txtCusId
            // 
            txtCusId.BackColor = Color.WhiteSmoke;
            txtCusId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusId.Location = new Point(224, 12);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(214, 34);
            txtCusId.TabIndex = 0;
            txtCusId.TextChanged += txtCusId_TextChanged;
            // 
            // txtCusPhone
            // 
            txtCusPhone.BackColor = Color.WhiteSmoke;
            txtCusPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusPhone.Location = new Point(638, 12);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(214, 34);
            txtCusPhone.TabIndex = 1;
            txtCusPhone.TextChanged += txtCusPhone_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(457, 14);
            label2.Name = "label2";
            label2.Size = new Size(156, 31);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại:";
            // 
            // txtCusPoint
            // 
            txtCusPoint.BackColor = Color.WhiteSmoke;
            txtCusPoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusPoint.Location = new Point(638, 68);
            txtCusPoint.Name = "txtCusPoint";
            txtCusPoint.Size = new Size(214, 34);
            txtCusPoint.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 70);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 7;
            label3.Text = "Điểm tích lũy:";
            // 
            // txtCusName
            // 
            txtCusName.BackColor = Color.WhiteSmoke;
            txtCusName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(224, 68);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(214, 34);
            txtCusName.TabIndex = 2;
            txtCusName.TextChanged += txtCusName_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 70);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 5;
            label4.Text = "Họ tên:";
            // 
            // pnCusInfo
            // 
            pnCusInfo.Controls.Add(btnCancel);
            pnCusInfo.Controls.Add(btnSearch);
            pnCusInfo.Controls.Add(txtCusId);
            pnCusInfo.Controls.Add(txtCusPoint);
            pnCusInfo.Controls.Add(label1);
            pnCusInfo.Controls.Add(label3);
            pnCusInfo.Controls.Add(label2);
            pnCusInfo.Controls.Add(txtCusName);
            pnCusInfo.Controls.Add(txtCusPhone);
            pnCusInfo.Controls.Add(label4);
            pnCusInfo.Location = new Point(38, 12);
            pnCusInfo.Name = "pnCusInfo";
            pnCusInfo.Size = new Size(875, 153);
            pnCusInfo.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DodgerBlue;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 16F);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(451, 108);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 16F);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(267, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(262, 261);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 8;
            label6.Text = "DANH SÁCH KHÁCH HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbOrderCusList
            // 
            cbbOrderCusList.BackColor = Color.Gainsboro;
            cbbOrderCusList.FlatStyle = FlatStyle.Flat;
            cbbOrderCusList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbOrderCusList.FormattingEnabled = true;
            cbbOrderCusList.Location = new Point(326, 26);
            cbbOrderCusList.Name = "cbbOrderCusList";
            cbbOrderCusList.Size = new Size(214, 36);
            cbbOrderCusList.TabIndex = 6;
            // 
            // grbCusHistory
            // 
            grbCusHistory.Controls.Add(label5);
            grbCusHistory.Controls.Add(btnSeeOrder);
            grbCusHistory.Controls.Add(cbbOrderCusList);
            grbCusHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbCusHistory.Location = new Point(38, 171);
            grbCusHistory.Margin = new Padding(0);
            grbCusHistory.Name = "grbCusHistory";
            grbCusHistory.Padding = new Padding(0);
            grbCusHistory.Size = new Size(875, 71);
            grbCusHistory.TabIndex = 9;
            grbCusHistory.TabStop = false;
            grbCusHistory.Text = "Lịch sử mua hàng";
            // 
            // label5
            // 
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 16F);
            label5.Location = new Point(88, 25);
            label5.Name = "label5";
            label5.Size = new Size(214, 39);
            label5.TabIndex = 12;
            label5.Text = "Đơn đã mua";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // btnSeeOrder
            // 
            btnSeeOrder.BackColor = Color.DodgerBlue;
            btnSeeOrder.Cursor = Cursors.Hand;
            btnSeeOrder.FlatAppearance.BorderSize = 0;
            btnSeeOrder.FlatStyle = FlatStyle.Flat;
            btnSeeOrder.Font = new Font("Times New Roman", 16F);
            btnSeeOrder.ForeColor = Color.WhiteSmoke;
            btnSeeOrder.Location = new Point(564, 25);
            btnSeeOrder.Name = "btnSeeOrder";
            btnSeeOrder.Size = new Size(214, 39);
            btnSeeOrder.TabIndex = 7;
            btnSeeOrder.Text = "Xem đơn";
            btnSeeOrder.UseVisualStyleBackColor = false;
            btnSeeOrder.Click += btnSeeOrder_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 610);
            Controls.Add(grbCusHistory);
            Controls.Add(dgvCusList);
            Controls.Add(label6);
            Controls.Add(pnCusInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomer";
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCusList).EndInit();
            pnCusInfo.ResumeLayout(false);
            pnCusInfo.PerformLayout();
            grbCusHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCusList;
        private Label label1;
        private TextBox txtCusId;
        private TextBox txtCusPhone;
        private Label label2;
        private TextBox txtCusPoint;
        private Label label3;
        private TextBox txtCusName;
        private Label label4;
        private Panel pnCusInfo;
        private Label label6;
        private Button btnSearch;
        private ComboBox cbbOrderCusList;
        private GroupBox grbCusHistory;
        private Button btnSeeOrder;
        private Label label5;
        private Button btnCancel;
    }
}