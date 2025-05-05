namespace GUI
{
    partial class frmProduct
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
            tabControlProduct = new TabControl();
            tabPagePro = new TabPage();
            groupBox3 = new GroupBox();
            btnDeletePro = new Button();
            btnEditPro = new Button();
            btnAddPro = new Button();
            btnInventory = new Button();
            btnSearchPro = new Button();
            label6 = new Label();
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            cbbSortName = new ComboBox();
            cbbCategory = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtProId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtProName = new TextBox();
            tabPageCate = new TabPage();
            groupBox1 = new GroupBox();
            txtSoSpDm = new TextBox();
            cbbCateList = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            grChucNang = new GroupBox();
            btnSaveCate = new Button();
            btnCancelCate = new Button();
            btnAdd = new Button();
            grInfoCate = new GroupBox();
            txtCateId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtCateName = new TextBox();
            tabPageSupplier = new TabPage();
            label14 = new Label();
            dgvSupplier = new DataGridView();
            groupBox2 = new GroupBox();
            btnSaveSup = new Button();
            btnCancelSup = new Button();
            btnAddSup = new Button();
            grInfoSup = new GroupBox();
            txtSupPhone = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtSupEmail = new TextBox();
            txtSupId = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtSupName = new TextBox();
            tabControlProduct.SuspendLayout();
            tabPagePro.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            tabPageCate.SuspendLayout();
            groupBox1.SuspendLayout();
            grChucNang.SuspendLayout();
            grInfoCate.SuspendLayout();
            tabPageSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            groupBox2.SuspendLayout();
            grInfoSup.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProduct
            // 
            tabControlProduct.Controls.Add(tabPagePro);
            tabControlProduct.Controls.Add(tabPageCate);
            tabControlProduct.Controls.Add(tabPageSupplier);
            tabControlProduct.Dock = DockStyle.Fill;
            tabControlProduct.Location = new Point(0, 0);
            tabControlProduct.Name = "tabControlProduct";
            tabControlProduct.SelectedIndex = 0;
            tabControlProduct.Size = new Size(950, 611);
            tabControlProduct.TabIndex = 0;
            tabControlProduct.SelectedIndexChanged += tabControlProduct_SelectedIndexChanged;
            // 
            // tabPagePro
            // 
            tabPagePro.BackColor = Color.White;
            tabPagePro.Controls.Add(groupBox3);
            tabPagePro.Controls.Add(label6);
            tabPagePro.Controls.Add(dgvProduct);
            tabPagePro.Controls.Add(panel1);
            tabPagePro.Location = new Point(4, 29);
            tabPagePro.Name = "tabPagePro";
            tabPagePro.Padding = new Padding(3);
            tabPagePro.Size = new Size(942, 578);
            tabPagePro.TabIndex = 0;
            tabPagePro.Text = "Sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeletePro);
            groupBox3.Controls.Add(btnEditPro);
            groupBox3.Controls.Add(btnAddPro);
            groupBox3.Controls.Add(btnInventory);
            groupBox3.Controls.Add(btnSearchPro);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(27, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(878, 81);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnDeletePro
            // 
            btnDeletePro.BackColor = Color.DodgerBlue;
            btnDeletePro.Cursor = Cursors.Hand;
            btnDeletePro.FlatAppearance.BorderSize = 0;
            btnDeletePro.FlatStyle = FlatStyle.Flat;
            btnDeletePro.Font = new Font("Times New Roman", 16F);
            btnDeletePro.ForeColor = Color.WhiteSmoke;
            btnDeletePro.Location = new Point(541, 33);
            btnDeletePro.Name = "btnDeletePro";
            btnDeletePro.Size = new Size(145, 39);
            btnDeletePro.TabIndex = 8;
            btnDeletePro.Text = "Xóa";
            btnDeletePro.UseVisualStyleBackColor = false;
            btnDeletePro.Click += btnDeletePro_Click;
            // 
            // btnEditPro
            // 
            btnEditPro.BackColor = Color.DodgerBlue;
            btnEditPro.Cursor = Cursors.Hand;
            btnEditPro.FlatAppearance.BorderSize = 0;
            btnEditPro.FlatStyle = FlatStyle.Flat;
            btnEditPro.Font = new Font("Times New Roman", 16F);
            btnEditPro.ForeColor = Color.WhiteSmoke;
            btnEditPro.Location = new Point(367, 33);
            btnEditPro.Name = "btnEditPro";
            btnEditPro.Size = new Size(145, 39);
            btnEditPro.TabIndex = 7;
            btnEditPro.Text = "Sửa";
            btnEditPro.UseVisualStyleBackColor = false;
            btnEditPro.Click += btnEditPro_Click;
            // 
            // btnAddPro
            // 
            btnAddPro.BackColor = Color.DodgerBlue;
            btnAddPro.Cursor = Cursors.Hand;
            btnAddPro.FlatAppearance.BorderSize = 0;
            btnAddPro.FlatStyle = FlatStyle.Flat;
            btnAddPro.Font = new Font("Times New Roman", 16F);
            btnAddPro.ForeColor = Color.WhiteSmoke;
            btnAddPro.Location = new Point(193, 33);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(145, 39);
            btnAddPro.TabIndex = 6;
            btnAddPro.Text = "Tạo mới";
            btnAddPro.UseVisualStyleBackColor = false;
            btnAddPro.Click += btnAddPro_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.DodgerBlue;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 16F);
            btnInventory.ForeColor = Color.WhiteSmoke;
            btnInventory.Location = new Point(715, 33);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(145, 39);
            btnInventory.TabIndex = 9;
            btnInventory.Text = "Kho hàng";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSearchPro
            // 
            btnSearchPro.BackColor = Color.DodgerBlue;
            btnSearchPro.Cursor = Cursors.Hand;
            btnSearchPro.FlatAppearance.BorderSize = 0;
            btnSearchPro.FlatStyle = FlatStyle.Flat;
            btnSearchPro.Font = new Font("Times New Roman", 16F);
            btnSearchPro.ForeColor = Color.WhiteSmoke;
            btnSearchPro.Location = new Point(19, 33);
            btnSearchPro.Name = "btnSearchPro";
            btnSearchPro.Size = new Size(145, 39);
            btnSearchPro.TabIndex = 5;
            btnSearchPro.Text = "Tìm";
            btnSearchPro.UseVisualStyleBackColor = false;
            btnSearchPro.Click += btnSearchPro_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(243, 267);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 12;
            label6.Text = "DANH SÁCH SẢN PHẨM";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(3, 308);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(936, 267);
            dgvProduct.TabIndex = 12;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbSortName);
            panel1.Controls.Add(cbbCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtProId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtProName);
            panel1.Location = new Point(27, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 144);
            panel1.TabIndex = 0;
            // 
            // cbbSortName
            // 
            cbbSortName.BackColor = Color.WhiteSmoke;
            cbbSortName.FlatStyle = FlatStyle.Flat;
            cbbSortName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbSortName.FormattingEnabled = true;
            cbbSortName.Items.AddRange(new object[] { "Giá tăng dần", "Giá giảm dần", "Ngày tạo mới nhất", "Ngày tạo cũ nhất", "Số lượng tăng dần", "Số lượng giảm dần" });
            cbbSortName.Location = new Point(630, 93);
            cbbSortName.Name = "cbbSortName";
            cbbSortName.Size = new Size(214, 36);
            cbbSortName.TabIndex = 4;
            // 
            // cbbCategory
            // 
            cbbCategory.BackColor = Color.WhiteSmoke;
            cbbCategory.FlatStyle = FlatStyle.Flat;
            cbbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(216, 93);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(214, 36);
            cbbCategory.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 96);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 8;
            label3.Text = "Danh mục:";
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 96);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 9;
            label4.Text = "Sắp xếp";
            // 
            // txtProId
            // 
            txtProId.BackColor = Color.WhiteSmoke;
            txtProId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProId.Location = new Point(216, 23);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(214, 34);
            txtProId.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 10;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 25);
            label2.Name = "label2";
            label2.Size = new Size(156, 31);
            label2.TabIndex = 7;
            label2.Text = "Tên sản phẩm";
            // 
            // txtProName
            // 
            txtProName.BackColor = Color.WhiteSmoke;
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProName.Location = new Point(630, 23);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(214, 34);
            txtProName.TabIndex = 2;
            txtProName.TextChanged += txtProName_TextChanged;
            // 
            // tabPageCate
            // 
            tabPageCate.BackColor = Color.White;
            tabPageCate.Controls.Add(groupBox1);
            tabPageCate.Controls.Add(grChucNang);
            tabPageCate.Controls.Add(grInfoCate);
            tabPageCate.Location = new Point(4, 29);
            tabPageCate.Name = "tabPageCate";
            tabPageCate.Padding = new Padding(3);
            tabPageCate.Size = new Size(942, 578);
            tabPageCate.TabIndex = 1;
            tabPageCate.Text = "Danh mục";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoSpDm);
            groupBox1.Controls.Add(cbbCateList);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 405);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 92);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // txtSoSpDm
            // 
            txtSoSpDm.BackColor = Color.WhiteSmoke;
            txtSoSpDm.Enabled = false;
            txtSoSpDm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoSpDm.Location = new Point(643, 41);
            txtSoSpDm.Name = "txtSoSpDm";
            txtSoSpDm.Size = new Size(174, 34);
            txtSoSpDm.TabIndex = 10;
            // 
            // cbbCateList
            // 
            cbbCateList.FormattingEnabled = true;
            cbbCateList.ItemHeight = 28;
            cbbCateList.Location = new Point(237, 38);
            cbbCateList.Name = "cbbCateList";
            cbbCateList.Size = new Size(169, 36);
            cbbCateList.TabIndex = 8;
            cbbCateList.SelectedIndexChanged += cbbCateList_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(429, 43);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 32;
            label5.Text = "Số sản phẩm";
            // 
            // label9
            // 
            label9.BackColor = Color.LightSkyBlue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 41);
            label9.Name = "label9";
            label9.Size = new Size(157, 31);
            label9.TabIndex = 38;
            label9.Text = "Danh sách";
            // 
            // grChucNang
            // 
            grChucNang.Controls.Add(btnSaveCate);
            grChucNang.Controls.Add(btnCancelCate);
            grChucNang.Controls.Add(btnAdd);
            grChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grChucNang.Location = new Point(13, 225);
            grChucNang.Name = "grChucNang";
            grChucNang.Size = new Size(898, 92);
            grChucNang.TabIndex = 19;
            grChucNang.TabStop = false;
            grChucNang.Text = "Chức năng";
            // 
            // btnSaveCate
            // 
            btnSaveCate.BackColor = Color.DodgerBlue;
            btnSaveCate.Cursor = Cursors.Hand;
            btnSaveCate.FlatAppearance.BorderSize = 0;
            btnSaveCate.FlatStyle = FlatStyle.Flat;
            btnSaveCate.Font = new Font("Times New Roman", 16F);
            btnSaveCate.ForeColor = Color.WhiteSmoke;
            btnSaveCate.Location = new Point(349, 33);
            btnSaveCate.Name = "btnSaveCate";
            btnSaveCate.Size = new Size(214, 39);
            btnSaveCate.TabIndex = 5;
            btnSaveCate.Text = "Lưu";
            btnSaveCate.UseVisualStyleBackColor = false;
            btnSaveCate.Click += btnSaveCate_Click;
            // 
            // btnCancelCate
            // 
            btnCancelCate.BackColor = Color.DodgerBlue;
            btnCancelCate.Cursor = Cursors.Hand;
            btnCancelCate.FlatAppearance.BorderSize = 0;
            btnCancelCate.FlatStyle = FlatStyle.Flat;
            btnCancelCate.Font = new Font("Times New Roman", 16F);
            btnCancelCate.ForeColor = Color.WhiteSmoke;
            btnCancelCate.Location = new Point(622, 33);
            btnCancelCate.Name = "btnCancelCate";
            btnCancelCate.Size = new Size(214, 39);
            btnCancelCate.TabIndex = 6;
            btnCancelCate.Text = "Hủy";
            btnCancelCate.UseVisualStyleBackColor = false;
            btnCancelCate.Click += btnCancelCate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 16F);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(71, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // grInfoCate
            // 
            grInfoCate.Controls.Add(txtCateId);
            grInfoCate.Controls.Add(label7);
            grInfoCate.Controls.Add(label8);
            grInfoCate.Controls.Add(txtCateName);
            grInfoCate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInfoCate.Location = new Point(13, 49);
            grInfoCate.Name = "grInfoCate";
            grInfoCate.Size = new Size(897, 88);
            grInfoCate.TabIndex = 20;
            grInfoCate.TabStop = false;
            grInfoCate.Text = "Thông tin";
            // 
            // txtCateId
            // 
            txtCateId.BackColor = Color.WhiteSmoke;
            txtCateId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCateId.Location = new Point(254, 27);
            txtCateId.Name = "txtCateId";
            txtCateId.Size = new Size(174, 34);
            txtCateId.TabIndex = 1;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 29);
            label7.Name = "label7";
            label7.Size = new Size(174, 31);
            label7.TabIndex = 28;
            label7.Text = "Mã:";
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(468, 29);
            label8.Name = "label8";
            label8.Size = new Size(174, 31);
            label8.TabIndex = 30;
            label8.Text = "Tên danh mục";
            // 
            // txtCateName
            // 
            txtCateName.BackColor = Color.WhiteSmoke;
            txtCateName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCateName.Location = new Point(682, 27);
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(174, 34);
            txtCateName.TabIndex = 2;
            // 
            // tabPageSupplier
            // 
            tabPageSupplier.Controls.Add(label14);
            tabPageSupplier.Controls.Add(dgvSupplier);
            tabPageSupplier.Controls.Add(groupBox2);
            tabPageSupplier.Controls.Add(grInfoSup);
            tabPageSupplier.Location = new Point(4, 29);
            tabPageSupplier.Name = "tabPageSupplier";
            tabPageSupplier.Size = new Size(942, 578);
            tabPageSupplier.TabIndex = 2;
            tabPageSupplier.Text = "Nhà cung cấp";
            tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.BackColor = Color.LightSkyBlue;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(230, 273);
            label14.Name = "label14";
            label14.Size = new Size(441, 38);
            label14.TabIndex = 24;
            label14.Text = "DANH SÁCH NHÀ CUNG CẤP";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Dock = DockStyle.Bottom;
            dgvSupplier.Location = new Point(0, 311);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(942, 267);
            dgvSupplier.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSaveSup);
            groupBox2.Controls.Add(btnCancelSup);
            groupBox2.Controls.Add(btnAddSup);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(8, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(926, 92);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSaveSup
            // 
            btnSaveSup.BackColor = Color.DodgerBlue;
            btnSaveSup.Cursor = Cursors.Hand;
            btnSaveSup.FlatAppearance.BorderSize = 0;
            btnSaveSup.FlatStyle = FlatStyle.Flat;
            btnSaveSup.Font = new Font("Times New Roman", 16F);
            btnSaveSup.ForeColor = Color.WhiteSmoke;
            btnSaveSup.Location = new Point(368, 33);
            btnSaveSup.Name = "btnSaveSup";
            btnSaveSup.Size = new Size(164, 39);
            btnSaveSup.TabIndex = 5;
            btnSaveSup.Text = "Lưu";
            btnSaveSup.UseVisualStyleBackColor = false;
            btnSaveSup.Click += btnSaveSup_Click;
            // 
            // btnCancelSup
            // 
            btnCancelSup.BackColor = Color.DodgerBlue;
            btnCancelSup.Cursor = Cursors.Hand;
            btnCancelSup.FlatAppearance.BorderSize = 0;
            btnCancelSup.FlatStyle = FlatStyle.Flat;
            btnCancelSup.Font = new Font("Times New Roman", 16F);
            btnCancelSup.ForeColor = Color.WhiteSmoke;
            btnCancelSup.Location = new Point(666, 33);
            btnCancelSup.Name = "btnCancelSup";
            btnCancelSup.Size = new Size(164, 39);
            btnCancelSup.TabIndex = 6;
            btnCancelSup.Text = "Hủy";
            btnCancelSup.UseVisualStyleBackColor = false;
            btnCancelSup.Click += btnCancelSup_Click;
            // 
            // btnAddSup
            // 
            btnAddSup.BackColor = Color.DodgerBlue;
            btnAddSup.Cursor = Cursors.Hand;
            btnAddSup.FlatAppearance.BorderSize = 0;
            btnAddSup.FlatStyle = FlatStyle.Flat;
            btnAddSup.Font = new Font("Times New Roman", 16F);
            btnAddSup.ForeColor = Color.WhiteSmoke;
            btnAddSup.Location = new Point(70, 33);
            btnAddSup.Name = "btnAddSup";
            btnAddSup.Size = new Size(164, 39);
            btnAddSup.TabIndex = 4;
            btnAddSup.Text = "Thêm";
            btnAddSup.UseVisualStyleBackColor = false;
            btnAddSup.Click += btnAddSup_Click;
            // 
            // grInfoSup
            // 
            grInfoSup.Controls.Add(txtSupPhone);
            grInfoSup.Controls.Add(label12);
            grInfoSup.Controls.Add(label13);
            grInfoSup.Controls.Add(txtSupEmail);
            grInfoSup.Controls.Add(txtSupId);
            grInfoSup.Controls.Add(label10);
            grInfoSup.Controls.Add(label11);
            grInfoSup.Controls.Add(txtSupName);
            grInfoSup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInfoSup.Location = new Point(8, 22);
            grInfoSup.Name = "grInfoSup";
            grInfoSup.Size = new Size(926, 146);
            grInfoSup.TabIndex = 22;
            grInfoSup.TabStop = false;
            grInfoSup.Text = "Thông tin";
            // 
            // txtSupPhone
            // 
            txtSupPhone.BackColor = Color.WhiteSmoke;
            txtSupPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupPhone.Location = new Point(230, 89);
            txtSupPhone.Name = "txtSupPhone";
            txtSupPhone.Size = new Size(220, 34);
            txtSupPhone.TabIndex = 3;
            // 
            // label12
            // 
            label12.BackColor = Color.LightSkyBlue;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(67, 89);
            label12.Name = "label12";
            label12.Size = new Size(139, 31);
            label12.TabIndex = 33;
            label12.Text = "Số điện thoại";
            // 
            // label13
            // 
            label13.BackColor = Color.LightSkyBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(474, 90);
            label13.Name = "label13";
            label13.Size = new Size(139, 31);
            label13.TabIndex = 34;
            label13.Text = "Email";
            // 
            // txtSupEmail
            // 
            txtSupEmail.BackColor = Color.WhiteSmoke;
            txtSupEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupEmail.Location = new Point(637, 89);
            txtSupEmail.Name = "txtSupEmail";
            txtSupEmail.Size = new Size(220, 34);
            txtSupEmail.TabIndex = 4;
            // 
            // txtSupId
            // 
            txtSupId.BackColor = Color.WhiteSmoke;
            txtSupId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupId.Location = new Point(230, 29);
            txtSupId.Name = "txtSupId";
            txtSupId.Size = new Size(220, 34);
            txtSupId.TabIndex = 1;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(67, 29);
            label10.Name = "label10";
            label10.Size = new Size(139, 31);
            label10.TabIndex = 28;
            label10.Text = "Mã:";
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(474, 30);
            label11.Name = "label11";
            label11.Size = new Size(139, 31);
            label11.TabIndex = 30;
            label11.Text = "Tên";
            // 
            // txtSupName
            // 
            txtSupName.BackColor = Color.WhiteSmoke;
            txtSupName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupName.Location = new Point(637, 29);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(220, 34);
            txtSupName.TabIndex = 2;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 611);
            Controls.Add(tabControlProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            tabControlProduct.ResumeLayout(false);
            tabPagePro.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageCate.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grChucNang.ResumeLayout(false);
            grInfoCate.ResumeLayout(false);
            grInfoCate.PerformLayout();
            tabPageSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            groupBox2.ResumeLayout(false);
            grInfoSup.ResumeLayout(false);
            grInfoSup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProduct;
        private TabPage tabPagePro;
        private TabPage tabPageCate;
        private Label label6;
        private DataGridView dgvProduct;
        private Panel panel1;
        private ComboBox cbbSortName;
        private ComboBox cbbCategory;
        private Label label3;
        private Label label4;
        private TextBox txtProId;
        private Label label1;
        private Label label2;
        private TextBox txtProName;
        private TabPage tabPageSupplier;
        private GroupBox grChucNang;
        private Button btnSaveCate;
        private Button btnCancelCate;
        private Button btnAdd;
        private GroupBox grInfoCate;
        private TextBox txtCateId;
        private Label label7;
        private Label label8;
        private TextBox txtCateName;
        private GroupBox groupBox1;
        private TextBox txtSoSpDm;
        private ComboBox cbbCateList;
        private Label label5;
        private Label label9;
        private GroupBox groupBox2;
        private Button btnSaveSup;
        private Button btnCancelSup;
        private Button btnAddSup;
        private GroupBox grInfoSup;
        private TextBox txtSupPhone;
        private Label label12;
        private Label label13;
        private TextBox txtSupEmail;
        private TextBox txtSupId;
        private Label label10;
        private Label label11;
        private TextBox txtSupName;
        private Label label14;
        private DataGridView dgvSupplier;
        private GroupBox groupBox3;
        private Button btnAddPro;
        private Button btnInventory;
        private Button btnSearchPro;
        private Button btnEditPro;
        private Button btnDeletePro;
    }
}