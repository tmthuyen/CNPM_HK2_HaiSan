using System.Data;

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
            dataGridView2 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            textBoxPrice = new TextBox();
            label13 = new Label();
            textBoxRemaining = new TextBox();
            label12 = new Label();
            label8 = new Label();
            cancelBtn = new Button();
            label10 = new Label();
            editBtn = new Button();
            label11 = new Label();
            delBtn = new Button();
            comboBoxProductID = new ComboBox();
            addBtn = new Button();
            comboBoxProductName = new ComboBox();
            textBoxUnit = new TextBox();
            soLuongTextBox = new TextBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
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
            tabPageCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(831, 458);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCreateOrder
            // 
            tabPageCreateOrder.Controls.Add(dataGridView2);
            tabPageCreateOrder.Controls.Add(panel2);
            tabPageCreateOrder.Controls.Add(panel1);
            tabPageCreateOrder.Controls.Add(dataGridView1);
            tabPageCreateOrder.Location = new Point(4, 24);
            tabPageCreateOrder.Margin = new Padding(3, 2, 3, 2);
            tabPageCreateOrder.Name = "tabPageCreateOrder";
            tabPageCreateOrder.Padding = new Padding(3, 2, 3, 2);
            tabPageCreateOrder.Size = new Size(823, 430);
            tabPageCreateOrder.TabIndex = 0;
            tabPageCreateOrder.Text = "Tạo đơn hàng";
            tabPageCreateOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, Price, Unit, Discount, Total });
            dataGridView2.Location = new Point(2, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(818, 150);
            dataGridView2.TabIndex = 18;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Tên sản phẩm";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Giá/Đơn vị";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.HeaderText = "Đơn vị";
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.HeaderText = "Giảm";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Tổng";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 70);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBoxRemaining);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(editBtn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(delBtn);
            panel1.Controls.Add(comboBoxProductID);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(comboBoxProductName);
            panel1.Controls.Add(textBoxUnit);
            panel1.Controls.Add(soLuongTextBox);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 58);
            panel1.TabIndex = 16;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Enabled = false;
            textBoxPrice.Location = new Point(540, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(62, 23);
            textBoxPrice.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(515, 7);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 18;
            label13.Text = "Giá";
            // 
            // textBoxRemaining
            // 
            textBoxRemaining.Enabled = false;
            textBoxRemaining.Location = new Point(759, 3);
            textBoxRemaining.Name = "textBoxRemaining";
            textBoxRemaining.Size = new Size(55, 23);
            textBoxRemaining.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(710, 8);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 16;
            label12.Text = "Tồn kho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 0;
            label8.Text = "ID sản phẩm";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(449, 33);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Location = new Point(141, 8);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 2;
            label10.Text = "Tên sản phẩm";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(320, 33);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 14;
            editBtn.Text = "Sửa đổi";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(405, 7);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 3;
            label11.Text = "Số lượng";
            // 
            // delBtn
            // 
            delBtn.Location = new Point(161, 33);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(96, 23);
            delBtn.TabIndex = 13;
            delBtn.Text = "Xóa sản phẩm";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // comboBoxProductID
            // 
            comboBoxProductID.FormattingEnabled = true;
            comboBoxProductID.Location = new Point(76, 3);
            comboBoxProductID.Name = "comboBoxProductID";
            comboBoxProductID.Size = new Size(59, 23);
            comboBoxProductID.TabIndex = 6;
            comboBoxProductID.SelectedIndexChanged += comboBoxProductID_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(7, 33);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(103, 23);
            addBtn.TabIndex = 12;
            addBtn.Text = "Thêm vào đơn";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Location = new Point(221, 3);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(184, 23);
            comboBoxProductName.TabIndex = 7;
            comboBoxProductName.SelectedIndexChanged += comboBoxProductName_SelectedIndexChanged;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Enabled = false;
            textBoxUnit.Location = new Point(655, 3);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(55, 23);
            textBoxUnit.TabIndex = 11;
            // 
            // soLuongTextBox
            // 
            soLuongTextBox.Location = new Point(459, 3);
            soLuongTextBox.Name = "soLuongTextBox";
            soLuongTextBox.Size = new Size(55, 23);
            soLuongTextBox.TabIndex = 8;
            soLuongTextBox.TextChanged += soLuongTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 8);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 10;
            label9.Text = "Đơn vị";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(814, 124);
            dataGridView1.TabIndex = 9;
            // 
            // tabPageSeeOrder
            // 
            tabPageSeeOrder.BackColor = Color.White;
            tabPageSeeOrder.Controls.Add(pnFilter);
            tabPageSeeOrder.Controls.Add(dgvOrderList);
            tabPageSeeOrder.Controls.Add(pnCusInfo);
            tabPageSeeOrder.Controls.Add(label6);
            tabPageSeeOrder.Location = new Point(4, 24);
            tabPageSeeOrder.Margin = new Padding(3, 2, 3, 2);
            tabPageSeeOrder.Name = "tabPageSeeOrder";
            tabPageSeeOrder.Padding = new Padding(3, 2, 3, 2);
            tabPageSeeOrder.Size = new Size(823, 430);
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
            pnFilter.Location = new Point(0, 89);
            pnFilter.Margin = new Padding(3, 2, 3, 2);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(822, 94);
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
            btnFilter.Location = new Point(317, 64);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(187, 29);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // txtFromPrice
            // 
            txtFromPrice.BackColor = Color.WhiteSmoke;
            txtFromPrice.Font = new Font("Segoe UI", 10.2F);
            txtFromPrice.Location = new Point(27, 35);
            txtFromPrice.Margin = new Padding(3, 2, 3, 2);
            txtFromPrice.Name = "txtFromPrice";
            txtFromPrice.Size = new Size(188, 26);
            txtFromPrice.TabIndex = 10;
            txtFromPrice.TextChanged += txtFromPrice_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(317, 8);
            label7.Name = "label7";
            label7.Size = new Size(187, 23);
            label7.TabIndex = 17;
            label7.Text = "Đến giá";
            // 
            // txtToPrice
            // 
            txtToPrice.BackColor = Color.WhiteSmoke;
            txtToPrice.Font = new Font("Segoe UI", 10.2F);
            txtToPrice.Location = new Point(317, 35);
            txtToPrice.Margin = new Padding(3, 2, 3, 2);
            txtToPrice.Name = "txtToPrice";
            txtToPrice.Size = new Size(188, 26);
            txtToPrice.TabIndex = 11;
            txtToPrice.TextChanged += txtToPrice_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 8);
            label3.Name = "label3";
            label3.Size = new Size(187, 23);
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
            cbbSortName.Location = new Point(606, 35);
            cbbSortName.Margin = new Padding(3, 2, 3, 2);
            cbbSortName.Name = "cbbSortName";
            cbbSortName.Size = new Size(188, 29);
            cbbSortName.TabIndex = 15;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(606, 8);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 14;
            label4.Text = "Sắp xếp";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Dock = DockStyle.Bottom;
            dgvOrderList.Location = new Point(3, 246);
            dgvOrderList.Margin = new Padding(3, 2, 3, 2);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(817, 182);
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
            pnCusInfo.Location = new Point(3, 2);
            pnCusInfo.Margin = new Padding(3, 2, 3, 2);
            pnCusInfo.Name = "pnCusInfo";
            pnCusInfo.Size = new Size(817, 50);
            pnCusInfo.TabIndex = 13;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(556, 16);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 9;
            label5.Text = "Mã nhân viên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmpId
            // 
            txtEmpId.BackColor = Color.WhiteSmoke;
            txtEmpId.Font = new Font("Segoe UI", 10.2F);
            txtEmpId.Location = new Point(695, 16);
            txtEmpId.Margin = new Padding(3, 2, 3, 2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(121, 26);
            txtEmpId.TabIndex = 8;
            // 
            // txtCusId
            // 
            txtCusId.BackColor = Color.WhiteSmoke;
            txtCusId.Font = new Font("Segoe UI", 10.2F);
            txtCusId.Location = new Point(142, 16);
            txtCusId.Margin = new Padding(3, 2, 3, 2);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(121, 26);
            txtCusId.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(4, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã đơn hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(280, 16);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Font = new Font("Segoe UI", 10.2F);
            txtPhone.Location = new Point(418, 16);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 26);
            txtPhone.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(227, 209);
            label6.Name = "label6";
            label6.Size = new Size(336, 38);
            label6.TabIndex = 14;
            label6.Text = "DÁNH SÁCH ĐƠN HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 458);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrder";
            Text = "frmOrder";
            tabControl1.ResumeLayout(false);
            tabPageCreateOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label11;
        private Label label10;
        private Label label8;
        private DataGridView dataGridView1;
        private TextBox soLuongTextBox;
        private ComboBox comboBoxProductName;
        private ComboBox comboBoxProductID;
        private TextBox textBoxUnit;
        private Label label9;
        private Panel panel1;
        private Button cancelBtn;
        private Button editBtn;
        private Button delBtn;
        private Button addBtn;
        private Panel panel2;
        private TextBox textBoxRemaining;
        private Label label12;
        private TextBox textBoxPrice;
        private Label label13;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Price;
    }
}