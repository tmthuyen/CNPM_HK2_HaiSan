namespace GUI
{
    partial class frmEmployee
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
            tabEmployee = new TabControl();
            tabPageListEmp = new TabPage();
            grChucNang = new GroupBox();
            btnSee = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label6 = new Label();
            dgvEmployee = new DataGridView();
            grInfo = new GroupBox();
            txtRole = new TextBox();
            label3 = new Label();
            txtEmpId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmpName = new TextBox();
            tabPageFunc = new TabPage();
            btnCancel = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            grInput = new GroupBox();
            lblImg = new Label();
            btnChooseImg = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbbStatus = new ComboBox();
            label11 = new Label();
            cbbRole = new ComboBox();
            cbbGender = new ComboBox();
            txtMail = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            tabEmployee.SuspendLayout();
            tabPageListEmp.SuspendLayout();
            grChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            grInfo.SuspendLayout();
            tabPageFunc.SuspendLayout();
            grInput.SuspendLayout();
            SuspendLayout();
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(tabPageListEmp);
            tabEmployee.Controls.Add(tabPageFunc);
            tabEmployee.Dock = DockStyle.Fill;
            tabEmployee.Location = new Point(0, 0);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.SelectedIndex = 0;
            tabEmployee.Size = new Size(950, 611);
            tabEmployee.TabIndex = 0;
            // 
            // tabPageListEmp
            // 
            tabPageListEmp.Controls.Add(grChucNang);
            tabPageListEmp.Controls.Add(label6);
            tabPageListEmp.Controls.Add(dgvEmployee);
            tabPageListEmp.Controls.Add(grInfo);
            tabPageListEmp.Location = new Point(4, 29);
            tabPageListEmp.Name = "tabPageListEmp";
            tabPageListEmp.Padding = new Padding(3);
            tabPageListEmp.Size = new Size(942, 578);
            tabPageListEmp.TabIndex = 0;
            tabPageListEmp.Text = "Danh sách";
            tabPageListEmp.UseVisualStyleBackColor = true;
            // 
            // grChucNang
            // 
            grChucNang.Controls.Add(btnSee);
            grChucNang.Controls.Add(btnDelete);
            grChucNang.Controls.Add(btnAdd);
            grChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grChucNang.Location = new Point(18, 113);
            grChucNang.Name = "grChucNang";
            grChucNang.Size = new Size(898, 92);
            grChucNang.TabIndex = 17;
            grChucNang.TabStop = false;
            grChucNang.Text = "Chức năng";
            // 
            // btnSee
            // 
            btnSee.BackColor = Color.DodgerBlue;
            btnSee.Cursor = Cursors.Hand;
            btnSee.FlatAppearance.BorderSize = 0;
            btnSee.FlatStyle = FlatStyle.Flat;
            btnSee.Font = new Font("Times New Roman", 16F);
            btnSee.ForeColor = Color.WhiteSmoke;
            btnSee.Location = new Point(349, 33);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(214, 39);
            btnSee.TabIndex = 30;
            btnSee.Text = "Xem";
            btnSee.UseVisualStyleBackColor = false;
            btnSee.Click += btnSee_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 16F);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(622, 33);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(214, 39);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(237, 237);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 16;
            label6.Text = "DANH SÁCH NHÂN VIÊN";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(3, 297);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(936, 278);
            dgvEmployee.TabIndex = 15;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // grInfo
            // 
            grInfo.Controls.Add(txtRole);
            grInfo.Controls.Add(label3);
            grInfo.Controls.Add(txtEmpId);
            grInfo.Controls.Add(label1);
            grInfo.Controls.Add(label2);
            grInfo.Controls.Add(txtEmpName);
            grInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInfo.Location = new Point(18, 7);
            grInfo.Name = "grInfo";
            grInfo.Size = new Size(897, 88);
            grInfo.TabIndex = 18;
            grInfo.TabStop = false;
            grInfo.Text = "Thông tin";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.WhiteSmoke;
            txtRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(750, 27);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(89, 34);
            txtRole.TabIndex = 32;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(638, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 31;
            label3.Text = "Vai trò";
            // 
            // txtEmpId
            // 
            txtEmpId.BackColor = Color.WhiteSmoke;
            txtEmpId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpId.Location = new Point(175, 27);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(89, 34);
            txtEmpId.TabIndex = 27;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 28;
            label1.Text = "Mã:";
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 29);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 30;
            label2.Text = "Họ tên";
            // 
            // txtEmpName
            // 
            txtEmpName.BackColor = Color.WhiteSmoke;
            txtEmpName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpName.Location = new Point(401, 27);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(214, 34);
            txtEmpName.TabIndex = 29;
            // 
            // tabPageFunc
            // 
            tabPageFunc.BackColor = Color.White;
            tabPageFunc.Controls.Add(btnCancel);
            tabPageFunc.Controls.Add(btnEdit);
            tabPageFunc.Controls.Add(btnSave);
            tabPageFunc.Controls.Add(grInput);
            tabPageFunc.Location = new Point(4, 29);
            tabPageFunc.Name = "tabPageFunc";
            tabPageFunc.Padding = new Padding(3);
            tabPageFunc.Size = new Size(942, 578);
            tabPageFunc.TabIndex = 1;
            tabPageFunc.Text = "Chức năng";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DodgerBlue;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 16F);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(620, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(273, 49);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 16F);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(314, 468);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(273, 49);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 16F);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(24, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(273, 49);
            btnSave.TabIndex = 11;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grInput
            // 
            grInput.Controls.Add(lblImg);
            grInput.Controls.Add(btnChooseImg);
            grInput.Controls.Add(dateTimePicker1);
            grInput.Controls.Add(cbbStatus);
            grInput.Controls.Add(label11);
            grInput.Controls.Add(cbbRole);
            grInput.Controls.Add(cbbGender);
            grInput.Controls.Add(txtMail);
            grInput.Controls.Add(label12);
            grInput.Controls.Add(label13);
            grInput.Controls.Add(txtAddress);
            grInput.Controls.Add(label8);
            grInput.Controls.Add(label9);
            grInput.Controls.Add(label10);
            grInput.Controls.Add(txtPhone);
            grInput.Controls.Add(label4);
            grInput.Controls.Add(txtId);
            grInput.Controls.Add(label5);
            grInput.Controls.Add(label7);
            grInput.Controls.Add(txtName);
            grInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInput.Location = new Point(19, 15);
            grInput.Name = "grInput";
            grInput.Size = new Size(897, 399);
            grInput.TabIndex = 19;
            grInput.TabStop = false;
            grInput.Text = "Thông tin";
            grInput.Enter += groupBox1_Enter;
            // 
            // lblImg
            // 
            lblImg.BackColor = Color.WhiteSmoke;
            lblImg.Location = new Point(275, 333);
            lblImg.Name = "lblImg";
            lblImg.Size = new Size(291, 48);
            lblImg.TabIndex = 50;
            lblImg.Text = "img";
            lblImg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChooseImg
            // 
            btnChooseImg.Location = new Point(275, 282);
            btnChooseImg.Name = "btnChooseImg";
            btnChooseImg.Size = new Size(291, 48);
            btnChooseImg.TabIndex = 10;
            btnChooseImg.Text = "Chọn ảnh";
            btnChooseImg.UseVisualStyleBackColor = true;
            btnChooseImg.Click += btnChooseImg_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 5;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.ItemHeight = 28;
            cbbStatus.Items.AddRange(new object[] { "active", "inactive" });
            cbbStatus.Location = new Point(158, 217);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(122, 36);
            cbbStatus.TabIndex = 7;
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 145);
            label11.Name = "label11";
            label11.Size = new Size(110, 31);
            label11.TabIndex = 45;
            label11.Text = "Ngày sinh";
            label11.Click += label11_Click;
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.ItemHeight = 28;
            cbbRole.Items.AddRange(new object[] { "admin", "sale" });
            cbbRole.Location = new Point(734, 215);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(122, 36);
            cbbRole.TabIndex = 9;
            // 
            // cbbGender
            // 
            cbbGender.FormattingEnabled = true;
            cbbGender.ItemHeight = 28;
            cbbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGender.Location = new Point(446, 217);
            cbbGender.Name = "cbbGender";
            cbbGender.Size = new Size(122, 36);
            cbbGender.TabIndex = 8;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.WhiteSmoke;
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(170, 88);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(250, 34);
            txtMail.TabIndex = 3;
            // 
            // label12
            // 
            label12.BackColor = Color.LightSkyBlue;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 91);
            label12.Name = "label12";
            label12.Size = new Size(110, 31);
            label12.TabIndex = 40;
            label12.Text = "Email";
            // 
            // label13
            // 
            label13.BackColor = Color.LightSkyBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(460, 150);
            label13.Name = "label13";
            label13.Size = new Size(110, 31);
            label13.TabIndex = 42;
            label13.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.WhiteSmoke;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(610, 145);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 34);
            txtAddress.TabIndex = 6;
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(596, 220);
            label8.Name = "label8";
            label8.Size = new Size(110, 31);
            label8.TabIndex = 37;
            label8.Text = "Vai trò";
            // 
            // label9
            // 
            label9.BackColor = Color.LightSkyBlue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 218);
            label9.Name = "label9";
            label9.Size = new Size(110, 31);
            label9.TabIndex = 34;
            label9.Text = "Trạng thái";
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(308, 220);
            label10.Name = "label10";
            label10.Size = new Size(110, 31);
            label10.TabIndex = 36;
            label10.Text = "Giới tính";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(610, 91);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 34);
            txtPhone.TabIndex = 4;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(460, 94);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 31;
            label4.Text = "Điện thoại";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(170, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 34);
            txtId.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 41);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 28;
            label5.Text = "Mã:";
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(460, 40);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 30;
            label7.Text = "Họ tên";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(610, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 34);
            txtName.TabIndex = 2;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 611);
            Controls.Add(tabEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployee";
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            tabEmployee.ResumeLayout(false);
            tabPageListEmp.ResumeLayout(false);
            grChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            grInfo.ResumeLayout(false);
            grInfo.PerformLayout();
            tabPageFunc.ResumeLayout(false);
            grInput.ResumeLayout(false);
            grInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabEmployee;
        private TabPage tabPageListEmp;
        private GroupBox grChucNang;
        private Button btnSee;
        private Button btnDelete;
        private Button btnAdd;
        private Label label6;
        private DataGridView dgvEmployee;
        private GroupBox grInfo;
        private TextBox txtRole;
        private Label label3;
        private TextBox txtEmpId;
        private Label label1;
        private Label label2;
        private TextBox txtEmpName;
        private TabPage tabPageFunc;
        private GroupBox grInput;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtId;
        private Label label5;
        private Label label7;
        private TextBox txtName;
        private TextBox txtMail;
        private Label label12;
        private Label label13;
        private TextBox txtAddress;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbbGender;
        private ComboBox cbbStatus;
        private ComboBox cbbRole;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Button btnChooseImg;
        private Label lblImg;
        private Button btnEdit;
        private Button btnSave;
        private Button btnCancel;
    }
}