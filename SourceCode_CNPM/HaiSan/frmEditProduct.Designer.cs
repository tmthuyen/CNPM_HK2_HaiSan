namespace GUI
{
    partial class frmEditProduct
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSavePro = new Button();
            btnCancelPro = new Button();
            btnEditPro = new Button();
            grInputPro = new GroupBox();
            label2 = new Label();
            txtPurchase = new TextBox();
            label4 = new Label();
            txtRetailPrice = new TextBox();
            cbbProId = new ComboBox();
            label13 = new Label();
            txtProName = new TextBox();
            label10 = new Label();
            btnExit = new Button();
            groupBox2.SuspendLayout();
            grInputPro.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label1.Location = new Point(182, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 50);
            label1.TabIndex = 38;
            label1.Text = "Sửa sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSavePro);
            groupBox2.Controls.Add(btnCancelPro);
            groupBox2.Controls.Add(btnEditPro);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(14, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 92);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSavePro
            // 
            btnSavePro.BackColor = Color.DodgerBlue;
            btnSavePro.Cursor = Cursors.Hand;
            btnSavePro.FlatAppearance.BorderSize = 0;
            btnSavePro.FlatStyle = FlatStyle.Flat;
            btnSavePro.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnSavePro.ForeColor = Color.WhiteSmoke;
            btnSavePro.Location = new Point(310, 33);
            btnSavePro.Name = "btnSavePro";
            btnSavePro.Size = new Size(164, 39);
            btnSavePro.TabIndex = 4;
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
            btnCancelPro.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnCancelPro.ForeColor = Color.WhiteSmoke;
            btnCancelPro.Location = new Point(592, 33);
            btnCancelPro.Name = "btnCancelPro";
            btnCancelPro.Size = new Size(164, 39);
            btnCancelPro.TabIndex = 5;
            btnCancelPro.Text = "Hủy";
            btnCancelPro.UseVisualStyleBackColor = false;
            btnCancelPro.Click += btnCancelPro_Click;
            // 
            // btnEditPro
            // 
            btnEditPro.BackColor = Color.DodgerBlue;
            btnEditPro.Cursor = Cursors.Hand;
            btnEditPro.FlatAppearance.BorderSize = 0;
            btnEditPro.FlatStyle = FlatStyle.Flat;
            btnEditPro.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnEditPro.ForeColor = Color.WhiteSmoke;
            btnEditPro.Location = new Point(28, 33);
            btnEditPro.Name = "btnEditPro";
            btnEditPro.Size = new Size(164, 39);
            btnEditPro.TabIndex = 3;
            btnEditPro.Text = "Sửa";
            btnEditPro.UseVisualStyleBackColor = false;
            btnEditPro.Click += btnEditPro_Click;
            // 
            // grInputPro
            // 
            grInputPro.Controls.Add(label2);
            grInputPro.Controls.Add(txtPurchase);
            grInputPro.Controls.Add(label4);
            grInputPro.Controls.Add(txtRetailPrice);
            grInputPro.Controls.Add(cbbProId);
            grInputPro.Controls.Add(label13);
            grInputPro.Controls.Add(txtProName);
            grInputPro.Controls.Add(label10);
            grInputPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grInputPro.Location = new Point(14, 72);
            grInputPro.Name = "grInputPro";
            grInputPro.Size = new Size(776, 171);
            grInputPro.TabIndex = 37;
            grInputPro.TabStop = false;
            grInputPro.Text = "Thông tin";
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 95);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 45;
            label2.Text = "Giá nhập";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPurchase
            // 
            txtPurchase.BackColor = Color.WhiteSmoke;
            txtPurchase.Enabled = false;
            txtPurchase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPurchase.Location = new Point(168, 93);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(214, 34);
            txtPurchase.TabIndex = 44;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(400, 97);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 43;
            label4.Text = "Giá bán";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRetailPrice
            // 
            txtRetailPrice.BackColor = Color.WhiteSmoke;
            txtRetailPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRetailPrice.Location = new Point(555, 95);
            txtRetailPrice.Name = "txtRetailPrice";
            txtRetailPrice.Size = new Size(202, 34);
            txtRetailPrice.TabIndex = 2;
            txtRetailPrice.KeyPress += txtRetailPrice_KeyPress;
            // 
            // cbbProId
            // 
            cbbProId.BackColor = Color.WhiteSmoke;
            cbbProId.FlatStyle = FlatStyle.Flat;
            cbbProId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbProId.FormattingEnabled = true;
            cbbProId.Location = new Point(168, 29);
            cbbProId.Name = "cbbProId";
            cbbProId.Size = new Size(214, 36);
            cbbProId.TabIndex = 1;
            cbbProId.SelectedIndexChanged += cbbProId_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.BackColor = Color.LightSkyBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label13.Location = new Point(400, 32);
            label13.Name = "label13";
            label13.Size = new Size(134, 31);
            label13.TabIndex = 34;
            label13.Text = "Tên";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProName
            // 
            txtProName.BackColor = Color.WhiteSmoke;
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProName.Location = new Point(555, 30);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(202, 34);
            txtProName.TabIndex = 1;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(13, 32);
            label10.Name = "label10";
            label10.Size = new Size(134, 31);
            label10.TabIndex = 28;
            label10.Text = "Mã:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(760, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 39;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 397);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(grInputPro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditProduct";
            Load += frmEditProduct_Load;
            groupBox2.ResumeLayout(false);
            grInputPro.ResumeLayout(false);
            grInputPro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnSavePro;
        private Button btnCancelPro;
        private Button btnEditPro;
        private GroupBox grInputPro;
        private Label label4;
        private TextBox txtRetailPrice;
        private ComboBox cbbProId;
        private Label label13;
        private TextBox txtProName;
        private Label label10;
        private Button btnExit;
        private Label label2;
        private TextBox txtPurchase;
    }
}