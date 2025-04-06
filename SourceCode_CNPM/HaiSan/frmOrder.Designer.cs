namespace GUI
{
    partial class frmOrder
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
            tabControl1 = new TabControl();
            tabPageCreateOrder = new TabPage();
            tabPageSeeOrder = new TabPage();
            pnFilter = new Panel();
            btnFilter = new Button();
            txtFromPrice = new TextBox();
            label7 = new Label();
            txtToPrice = new TextBox();
            label3 = new Label();
            cbbSortName = new ComboBox();
            label4 = new Label();
            dgvOrderList = new DataGridView();
            pnCusInfo = new Panel();
            label5 = new Label();
            txtEmpId = new TextBox();
            txtCusId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPageSeeOrder.SuspendLayout();
            pnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            pnCusInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCreateOrder);
            tabControl1.Controls.Add(tabPageSeeOrder);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 610);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCreateOrder
            // 
            tabPageCreateOrder.Location = new Point(4, 29);
            tabPageCreateOrder.Name = "tabPageCreateOrder";
            tabPageCreateOrder.Padding = new Padding(3);
            tabPageCreateOrder.Size = new Size(942, 577);
            tabPageCreateOrder.TabIndex = 0;
            tabPageCreateOrder.Text = "Tạo đơn hàng";
            tabPageCreateOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageSeeOrder
            // 
            tabPageSeeOrder.BackColor = Color.White;
            tabPageSeeOrder.Controls.Add(pnFilter);
            tabPageSeeOrder.Controls.Add(dgvOrderList);
            tabPageSeeOrder.Controls.Add(pnCusInfo);
            tabPageSeeOrder.Controls.Add(label6);
            tabPageSeeOrder.Location = new Point(4, 29);
            tabPageSeeOrder.Name = "tabPageSeeOrder";
            tabPageSeeOrder.Padding = new Padding(3);
            tabPageSeeOrder.Size = new Size(942, 577);
            tabPageSeeOrder.TabIndex = 1;
            tabPageSeeOrder.Text = "Xem đơn hàng";
            // 
            // pnFilter
            // 
            pnFilter.Controls.Add(btnFilter);
            pnFilter.Controls.Add(txtFromPrice);
            pnFilter.Controls.Add(label7);
            pnFilter.Controls.Add(txtToPrice);
            pnFilter.Controls.Add(label3);
            pnFilter.Controls.Add(cbbSortName);
            pnFilter.Controls.Add(label4);
            pnFilter.Location = new Point(0, 119);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(939, 125);
            pnFilter.TabIndex = 15;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.DodgerBlue;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Times New Roman", 16F);
            btnFilter.ForeColor = Color.WhiteSmoke;
            btnFilter.Location = new Point(362, 86);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(214, 39);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // txtFromPrice
            // 
            txtFromPrice.BackColor = Color.WhiteSmoke;
            txtFromPrice.Font = new Font("Segoe UI", 10.2F);
            txtFromPrice.Location = new Point(31, 47);
            txtFromPrice.Name = "txtFromPrice";
            txtFromPrice.Size = new Size(214, 30);
            txtFromPrice.TabIndex = 10;
            txtFromPrice.TextChanged += txtFromPrice_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(362, 10);
            label7.Name = "label7";
            label7.Size = new Size(214, 31);
            label7.TabIndex = 17;
            label7.Text = "Đến giá";
            // 
            // txtToPrice
            // 
            txtToPrice.BackColor = Color.WhiteSmoke;
            txtToPrice.Font = new Font("Segoe UI", 10.2F);
            txtToPrice.Location = new Point(362, 47);
            txtToPrice.Name = "txtToPrice";
            txtToPrice.Size = new Size(214, 30);
            txtToPrice.TabIndex = 11;
            txtToPrice.TextChanged += txtToPrice_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 10);
            label3.Name = "label3";
            label3.Size = new Size(214, 31);
            label3.TabIndex = 16;
            label3.Text = "Giá từ";
            // 
            // cbbSortName
            // 
            cbbSortName.BackColor = Color.WhiteSmoke;
            cbbSortName.FlatStyle = FlatStyle.Flat;
            cbbSortName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbSortName.FormattingEnabled = true;
            cbbSortName.Items.AddRange(new object[] { "Giá tăng dần", "Giá giảm dần", "Ngày tạo mới nhất", "Ngày tạo cũ nhất", "Số lượng tăng dần", "Số lượng giảm dần" });
            cbbSortName.Location = new Point(693, 47);
            cbbSortName.Name = "cbbSortName";
            cbbSortName.Size = new Size(214, 36);
            cbbSortName.TabIndex = 15;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(693, 10);
            label4.Name = "label4";
            label4.Size = new Size(214, 31);
            label4.TabIndex = 14;
            label4.Text = "Sắp xếp";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Dock = DockStyle.Bottom;
            dgvOrderList.Location = new Point(3, 332);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(936, 242);
            dgvOrderList.TabIndex = 12;
            // 
            // pnCusInfo
            // 
            pnCusInfo.Controls.Add(label5);
            pnCusInfo.Controls.Add(txtEmpId);
            pnCusInfo.Controls.Add(txtCusId);
            pnCusInfo.Controls.Add(label1);
            pnCusInfo.Controls.Add(label2);
            pnCusInfo.Controls.Add(txtPhone);
            pnCusInfo.Dock = DockStyle.Top;
            pnCusInfo.Location = new Point(3, 3);
            pnCusInfo.Name = "pnCusInfo";
            pnCusInfo.Size = new Size(936, 66);
            pnCusInfo.TabIndex = 13;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(636, 21);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 9;
            label5.Text = "Mã nhân viên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmpId
            // 
            txtEmpId.BackColor = Color.WhiteSmoke;
            txtEmpId.Font = new Font("Segoe UI", 10.2F);
            txtEmpId.Location = new Point(794, 21);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(138, 30);
            txtEmpId.TabIndex = 8;
            // 
            // txtCusId
            // 
            txtCusId.BackColor = Color.WhiteSmoke;
            txtCusId.Font = new Font("Segoe UI", 10.2F);
            txtCusId.Location = new Point(162, 21);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(138, 30);
            txtCusId.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(4, 21);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã đơn hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(320, 21);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Font = new Font("Segoe UI", 10.2F);
            txtPhone.Location = new Point(478, 21);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(138, 30);
            txtPhone.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 279);
            label6.Name = "label6";
            label6.Size = new Size(384, 50);
            label6.TabIndex = 14;
            label6.Text = "DÁNH SÁCH ĐƠN HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 610);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrder";
            Text = "frmOrder";
            tabControl1.ResumeLayout(false);
            tabPageSeeOrder.ResumeLayout(false);
            pnFilter.ResumeLayout(false);
            pnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            pnCusInfo.ResumeLayout(false);
            pnCusInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCreateOrder;
        private TabPage tabPageSeeOrder;
        private DataGridView dgvOrderList;
        private Panel pnCusInfo;
        private Label label5;
        private TextBox txtEmpId;
        private TextBox txtCusId;
        private Label label1;
        private Label label2;
        private TextBox txtPhone;
        private Label label6;
        private Panel pnFilter;
        private ComboBox cbbSortName;
        private Label label4;
        private TextBox txtFromPrice;
        private Label label7;
        private TextBox txtToPrice;
        private Label label3;
        private Button btnFilter;
    }
}