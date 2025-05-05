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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPageCreateOrder = new TabPage();
            dataGridViewOrderDetail = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            cancelCustomer = new Button();
            label23 = new Label();
            comboBoxPayment = new ComboBox();
            btnFindCustomer = new Button();
            textBoxCusPoint = new TextBox();
            label16 = new Label();
            textBoxPoint = new TextBox();
            voucherAmount = new TextBox();
            label17 = new Label();
            label22 = new Label();
            textBoxGiven = new TextBox();
            label15 = new Label();
            label21 = new Label();
            textBoxRawSum = new TextBox();
            textBoxChange = new TextBox();
            label20 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBoxCustomerName = new TextBox();
            label19 = new Label();
            textBoxPhone = new TextBox();
            label18 = new Label();
            btnCreate = new Button();
            comboBoxVoucher = new ComboBox();
            textBoxRealSum = new TextBox();
            label14 = new Label();
            panel1 = new Panel();
            textBoxPrice = new TextBox();
            label13 = new Label();
            textBoxRemaining = new TextBox();
            label12 = new Label();
            cancelBtn = new Button();
            label10 = new Label();
            editBtn = new Button();
            label11 = new Label();
            delBtn = new Button();
            addBtn = new Button();
            comboBoxProductName = new ComboBox();
            textBoxUnit = new TextBox();
            soLuongTextBox = new TextBox();
            label9 = new Label();
            dataGridViewVouchers = new DataGridView();
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
            Discount = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPageCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVouchers).BeginInit();
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
            tabPageCreateOrder.Controls.Add(dataGridViewOrderDetail);
            tabPageCreateOrder.Controls.Add(panel2);
            tabPageCreateOrder.Controls.Add(panel1);
            tabPageCreateOrder.Controls.Add(dataGridViewVouchers);
            tabPageCreateOrder.Location = new Point(4, 24);
            tabPageCreateOrder.Margin = new Padding(3, 2, 3, 2);
            tabPageCreateOrder.Name = "tabPageCreateOrder";
            tabPageCreateOrder.Padding = new Padding(3, 2, 3, 2);
            tabPageCreateOrder.Size = new Size(823, 430);
            tabPageCreateOrder.TabIndex = 0;
            tabPageCreateOrder.Text = "Tạo đơn hàng";
            tabPageCreateOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderDetail
            // 
            dataGridViewOrderDetail.AllowUserToAddRows = false;
            dataGridViewOrderDetail.AllowUserToDeleteRows = false;
            dataGridViewOrderDetail.AllowUserToOrderColumns = true;
            dataGridViewOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetail.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, Price, Unit, Total });
            dataGridViewOrderDetail.Location = new Point(0, 64);
            dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            dataGridViewOrderDetail.ReadOnly = true;
            dataGridViewOrderDetail.Size = new Size(823, 171);
            dataGridViewOrderDetail.TabIndex = 18;
            dataGridViewOrderDetail.RowEnter += dataGridViewOrderDetail_RowEnter;
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
            // Total
            // 
            Total.HeaderText = "Tổng";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cancelCustomer);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(comboBoxPayment);
            panel2.Controls.Add(btnFindCustomer);
            panel2.Controls.Add(textBoxCusPoint);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(textBoxPoint);
            panel2.Controls.Add(voucherAmount);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(textBoxGiven);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(textBoxRawSum);
            panel2.Controls.Add(textBoxChange);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxCustomerName);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(textBoxPhone);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(comboBoxVoucher);
            panel2.Controls.Add(textBoxRealSum);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(3, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 92);
            panel2.TabIndex = 17;
            // 
            // cancelCustomer
            // 
            cancelCustomer.Location = new Point(363, 64);
            cancelCustomer.Name = "cancelCustomer";
            cancelCustomer.Size = new Size(98, 24);
            cancelCustomer.TabIndex = 30;
            cancelCustomer.Text = "Bỏ chọn khách";
            cancelCustomer.UseVisualStyleBackColor = true;
            cancelCustomer.Click += cancelCustomer_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 69);
            label23.Name = "label23";
            label23.Size = new Size(51, 15);
            label23.TabIndex = 29;
            label23.Text = "Cách trả";
            // 
            // comboBoxPayment
            // 
            comboBoxPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPayment.FormattingEnabled = true;
            comboBoxPayment.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            comboBoxPayment.Location = new Point(73, 65);
            comboBoxPayment.Name = "comboBoxPayment";
            comboBoxPayment.Size = new Size(121, 23);
            comboBoxPayment.TabIndex = 11;
            // 
            // btnFindCustomer
            // 
            btnFindCustomer.Location = new Point(292, 65);
            btnFindCustomer.Name = "btnFindCustomer";
            btnFindCustomer.Size = new Size(55, 23);
            btnFindCustomer.TabIndex = 13;
            btnFindCustomer.Text = "Tra SĐT";
            btnFindCustomer.UseVisualStyleBackColor = true;
            btnFindCustomer.Click += btnFindCustomer_Click;
            // 
            // textBoxCusPoint
            // 
            textBoxCusPoint.Enabled = false;
            textBoxCusPoint.Location = new Point(573, 35);
            textBoxCusPoint.Name = "textBoxCusPoint";
            textBoxCusPoint.Size = new Size(54, 23);
            textBoxCusPoint.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(532, 9);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 11;
            label16.Text = "Điểm";
            // 
            // textBoxPoint
            // 
            textBoxPoint.Enabled = false;
            textBoxPoint.Location = new Point(573, 6);
            textBoxPoint.Name = "textBoxPoint";
            textBoxPoint.Size = new Size(54, 23);
            textBoxPoint.TabIndex = 7;
            textBoxPoint.TextChanged += textBoxPoint_TextChanged;
            textBoxPoint.KeyPress += NumberOnly_KeyPress;
            // 
            // voucherAmount
            // 
            voucherAmount.Enabled = false;
            voucherAmount.Location = new Point(426, 6);
            voucherAmount.Name = "voucherAmount";
            voucherAmount.Size = new Size(92, 23);
            voucherAmount.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(340, 9);
            label17.Name = "label17";
            label17.Size = new Size(80, 15);
            label17.TabIndex = 13;
            label17.Text = "Voucher giảm";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(480, 39);
            label22.Name = "label22";
            label22.Size = new Size(87, 15);
            label22.TabIndex = 26;
            label22.Text = "Điểm Khách có";
            // 
            // textBoxGiven
            // 
            textBoxGiven.Location = new Point(700, 36);
            textBoxGiven.Name = "textBoxGiven";
            textBoxGiven.Size = new Size(114, 23);
            textBoxGiven.TabIndex = 10;
            textBoxGiven.TextChanged += textBoxGiven_TextChanged;
            textBoxGiven.KeyPress += ProcessNumber_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(196, 9);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 8;
            label15.Text = "Tổng";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(647, 69);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 24;
            label21.Text = "Thối lại";
            // 
            // textBoxRawSum
            // 
            textBoxRawSum.Enabled = false;
            textBoxRawSum.Location = new Point(236, 7);
            textBoxRawSum.Name = "textBoxRawSum";
            textBoxRawSum.Size = new Size(100, 23);
            textBoxRawSum.TabIndex = 9;
            // 
            // textBoxChange
            // 
            textBoxChange.Enabled = false;
            textBoxChange.Location = new Point(700, 65);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.Size = new Size(114, 23);
            textBoxChange.TabIndex = 23;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(631, 39);
            label20.Name = "label20";
            label20.Size = new Size(63, 15);
            label20.TabIndex = 22;
            label20.Text = "Khách đưa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 9);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 21;
            label8.Text = "Voucher";
            // 
            // button2
            // 
            button2.Location = new Point(467, 64);
            button2.Name = "button2";
            button2.Size = new Size(48, 23);
            button2.TabIndex = 14;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(521, 65);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 15;
            button1.Text = "Xem trước hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPreview_Click;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(73, 36);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(231, 23);
            textBoxCustomerName.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 42);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 17;
            label19.Text = "Tên Khách";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(389, 36);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(81, 23);
            textBoxPhone.TabIndex = 9;
            textBoxPhone.KeyPress += NumberOnly_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(320, 39);
            label18.Name = "label18";
            label18.Size = new Size(63, 15);
            label18.TabIndex = 15;
            label18.Text = "SĐT Khách";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(200, 65);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Tạo đơn";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // comboBoxVoucher
            // 
            comboBoxVoucher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoucher.FormattingEnabled = true;
            comboBoxVoucher.Location = new Point(74, 6);
            comboBoxVoucher.Name = "comboBoxVoucher";
            comboBoxVoucher.Size = new Size(121, 23);
            comboBoxVoucher.TabIndex = 6;
            comboBoxVoucher.SelectedIndexChanged += comboBoxVoucher_SelectedIndexChanged;
            // 
            // textBoxRealSum
            // 
            textBoxRealSum.Enabled = false;
            textBoxRealSum.Location = new Point(700, 6);
            textBoxRealSum.Name = "textBoxRealSum";
            textBoxRealSum.Size = new Size(114, 23);
            textBoxRealSum.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(647, 9);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 6;
            label14.Text = "Phải trả";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBoxRemaining);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(editBtn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(delBtn);
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
            textBoxPrice.Location = new Point(467, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(87, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(437, 5);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 18;
            label13.Text = "Giá";
            // 
            // textBoxRemaining
            // 
            textBoxRemaining.Enabled = false;
            textBoxRemaining.Location = new Point(750, 3);
            textBoxRemaining.Name = "textBoxRemaining";
            textBoxRemaining.Size = new Size(55, 23);
            textBoxRemaining.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(694, 6);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 16;
            label12.Text = "Tồn kho";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(449, 33);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Location = new Point(7, 6);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 2;
            label10.Text = "Sản phẩm";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(320, 33);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 4;
            editBtn.Text = "Sửa đổi";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 7);
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
            delBtn.TabIndex = 3;
            delBtn.Text = "Xóa khỏi đơn";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(7, 33);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(103, 23);
            addBtn.TabIndex = 2;
            addBtn.Text = "Thêm vào đơn";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Location = new Point(73, 3);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(184, 23);
            comboBoxProductName.TabIndex = 0;
            comboBoxProductName.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Enabled = false;
            textBoxUnit.Location = new Point(611, 3);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(77, 23);
            textBoxUnit.TabIndex = 3;
            // 
            // soLuongTextBox
            // 
            soLuongTextBox.Location = new Point(320, 3);
            soLuongTextBox.Name = "soLuongTextBox";
            soLuongTextBox.Size = new Size(100, 23);
            soLuongTextBox.TabIndex = 1;
            soLuongTextBox.TextChanged += soLuongTextBox_TextChanged;
            soLuongTextBox.KeyDown += soLuongTextBox_KeyDown;
            soLuongTextBox.KeyPress += ProcessNumber_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(564, 5);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 10;
            label9.Text = "Đơn vị";
            // 
            // dataGridViewVouchers
            // 
            dataGridViewVouchers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVouchers.Location = new Point(0, 329);
            dataGridViewVouchers.Name = "dataGridViewVouchers";
            dataGridViewVouchers.Size = new Size(823, 101);
            dataGridViewVouchers.TabIndex = 9;
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
            btnFilter.Click += btnFilter_Click;
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
            txtFromPrice.TextChanged += NumberOnly_TextChanged;
            txtFromPrice.KeyPress += NumberOnly_KeyPress;
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
            txtToPrice.TextChanged += NumberOnly_TextChanged;
            txtToPrice.KeyPress += NumberOnly_KeyPress;
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
            cbbSortName.Items.AddRange(new object[] { "Giá tăng dần", "Giá giảm dần", "Ngày tạo mới nhất", "Ngày tạo cũ nhất" });
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
            dgvOrderList.CellClick += dgvOrderList_CellClick;
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
            // Discount
            // 
            Discount.HeaderText = "Giảm";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVouchers).EndInit();
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
        private DataGridView dataGridViewVouchers;
        private TextBox soLuongTextBox;
        private ComboBox comboBoxProductName;
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
        private DataGridView dataGridViewOrderDetail;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Price;
        private Button btnCreate;
        private ComboBox comboBoxVoucher;
        private TextBox textBoxRawSum;
        private Label label15;
        private TextBox textBoxRealSum;
        private Label label14;
        private TextBox textBoxPoint;
        private Label label16;
        private TextBox voucherAmount;
        private Label label17;
        private Button button2;
        private Button button1;
        private TextBox textBoxCustomerName;
        private Label label19;
        private TextBox textBoxPhone;
        private Label label18;
        private Label label8;
        private TextBox textBoxGiven;
        private Label label21;
        private TextBox textBoxChange;
        private Label label20;
        private TextBox textBox1;
        private Label label22;
        private Button btnFindCustomer;
        private TextBox textBoxCusPoint;
        private Label label23;
        private ComboBox comboBoxPayment;
        private Button cancelCustomer;
        private ToolTip toolTip1;
    }
}