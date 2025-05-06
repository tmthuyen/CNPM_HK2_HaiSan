namespace GUI
{
    partial class frmAddNewProduct
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
            groupBox2 = new GroupBox();
            btnSavePro = new Button();
            btnCancelPro = new Button();
            btnAddPro = new Button();
            grInputPro = new GroupBox();
            label4 = new Label();
            txtRetailPrice = new TextBox();
            cbbUnit = new ComboBox();
            label3 = new Label();
            cbbCategory = new ComboBox();
            label13 = new Label();
            txtProName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtProId = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            groupBox2.SuspendLayout();
            grInputPro.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSavePro);
            groupBox2.Controls.Add(btnCancelPro);
            groupBox2.Controls.Add(btnAddPro);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 92);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSavePro
            // 
            btnSavePro.BackColor = Color.DodgerBlue;
            btnSavePro.Cursor = Cursors.Hand;
            btnSavePro.FlatAppearance.BorderSize = 0;
            btnSavePro.FlatStyle = FlatStyle.Flat;
            btnSavePro.Font = new Font("Times New Roman", 16F);
            btnSavePro.ForeColor = Color.WhiteSmoke;
            btnSavePro.Location = new Point(310, 33);
            btnSavePro.Name = "btnSavePro";
            btnSavePro.Size = new Size(164, 39);
            btnSavePro.TabIndex = 9;
            btnSavePro.Text = "Lưu";
            btnSavePro.UseVisualStyleBackColor = false;
            btnSavePro.Click += btnSavePro_Click;
            // 
            // btnCancelPro
            // 
            btnCancelPro.BackColor = Color.DodgerBlue;
            btnCancelPro.Cursor = Cursors.Hand;
            btnCancelPro.FlatAppearance.BorderSize = 0;
            btnCancelPro.FlatStyle = FlatStyle.Flat;
            btnCancelPro.Font = new Font("Times New Roman", 16F);
            btnCancelPro.ForeColor = Color.WhiteSmoke;
            btnCancelPro.Location = new Point(592, 33);
            btnCancelPro.Name = "btnCancelPro";
            btnCancelPro.Size = new Size(164, 39);
            btnCancelPro.TabIndex = 10;
            btnCancelPro.Text = "Hủy";
            btnCancelPro.UseVisualStyleBackColor = false;
            btnCancelPro.Click += btnCancelPro_Click;
            // 
            // btnAddPro
            // 
            btnAddPro.BackColor = Color.DodgerBlue;
            btnAddPro.Cursor = Cursors.Hand;
            btnAddPro.FlatAppearance.BorderSize = 0;
            btnAddPro.FlatStyle = FlatStyle.Flat;
            btnAddPro.Font = new Font("Times New Roman", 16F);
            btnAddPro.ForeColor = Color.WhiteSmoke;
            btnAddPro.Location = new Point(28, 33);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(164, 39);
            btnAddPro.TabIndex = 8;
            btnAddPro.Text = "Thêm";
            btnAddPro.UseVisualStyleBackColor = false;
            btnAddPro.Click += btnAddPro_Click;
            // 
            // grInputPro
            // 
            grInputPro.Controls.Add(label4);
            grInputPro.Controls.Add(txtRetailPrice);
            grInputPro.Controls.Add(cbbUnit);
            grInputPro.Controls.Add(label3);
            grInputPro.Controls.Add(cbbCategory);
            grInputPro.Controls.Add(label13);
            grInputPro.Controls.Add(txtProName);
            grInputPro.Controls.Add(label10);
            grInputPro.Controls.Add(label11);
            grInputPro.Controls.Add(txtProId);
            grInputPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInputPro.Location = new Point(12, 62);
            grInputPro.Name = "grInputPro";
            grInputPro.Size = new Size(776, 248);
            grInputPro.TabIndex = 24;
            grInputPro.TabStop = false;
            grInputPro.Text = "Thông tin";
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(210, 150);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 43;
            label4.Text = "Giá bán";
            // 
            // txtRetailPrice
            // 
            txtRetailPrice.BackColor = Color.WhiteSmoke;
            txtRetailPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRetailPrice.Location = new Point(365, 147);
            txtRetailPrice.Name = "txtRetailPrice";
            txtRetailPrice.Size = new Size(202, 34);
            txtRetailPrice.TabIndex = 7;
            txtRetailPrice.KeyPress += txtRetailPrice_KeyPress;
            // 
            // cbbUnit
            // 
            cbbUnit.BackColor = Color.WhiteSmoke;
            cbbUnit.FlatStyle = FlatStyle.Flat;
            cbbUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbUnit.FormattingEnabled = true;
            cbbUnit.Items.AddRange(new object[] { "Kg", "Con" });
            cbbUnit.Location = new Point(558, 88);
            cbbUnit.Name = "cbbUnit";
            cbbUnit.Size = new Size(202, 36);
            cbbUnit.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(403, 93);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 39;
            label3.Text = "Đơn vị";
            // 
            // cbbCategory
            // 
            cbbCategory.BackColor = Color.WhiteSmoke;
            cbbCategory.FlatStyle = FlatStyle.Flat;
            cbbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(168, 29);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(214, 36);
            cbbCategory.TabIndex = 1;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.BackColor = Color.LightSkyBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 91);
            label13.Name = "label13";
            label13.Size = new Size(134, 31);
            label13.TabIndex = 34;
            label13.Text = "Tên";
            // 
            // txtProName
            // 
            txtProName.BackColor = Color.WhiteSmoke;
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProName.Location = new Point(168, 89);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(214, 34);
            txtProName.TabIndex = 4;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 32);
            label10.Name = "label10";
            label10.Size = new Size(134, 31);
            label10.TabIndex = 28;
            label10.Text = "Loại:";
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(403, 32);
            label11.Name = "label11";
            label11.Size = new Size(134, 31);
            label11.TabIndex = 30;
            label11.Text = "Mã";
            // 
            // txtProId
            // 
            txtProId.BackColor = Color.WhiteSmoke;
            txtProId.Enabled = false;
            txtProId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProId.Location = new Point(558, 30);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(202, 34);
            txtProId.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, -1);
            label1.Name = "label1";
            label1.Size = new Size(417, 50);
            label1.TabIndex = 35;
            label1.Text = "Tạo sản phẩm mới";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(760, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 36;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmAddNewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(grInputPro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddNewProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddNewProduct";
            Load += frmAddNewProduct_Load;
            groupBox2.ResumeLayout(false);
            grInputPro.ResumeLayout(false);
            grInputPro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnSavePro;
        private Button btnCancelPro;
        private Button btnAddPro;
        private GroupBox grInputPro;
        private Label label13;
        private TextBox txtProName;
        private Label label10;
        private Label label11;
        private TextBox txtProId;
        private Label label1;
        private Button btnExit;
        private ComboBox cbbCategory;
        private Label label4;
        private TextBox txtRetailPrice;
        private ComboBox cbbUnit;
        private Label label3;
    }
}