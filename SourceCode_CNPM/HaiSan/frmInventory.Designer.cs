namespace GUI
{
    partial class frmInventory
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
            tabCtrlInventory = new TabControl();
            tabPageImport = new TabPage();
            tabPageExpire = new TabPage();
            label6 = new Label();
            dgvProduct = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            txtImportId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtQuantityImport = new TextBox();
            txtImportDate = new TextBox();
            btnImportPro = new Button();
            tabCtrlInventory.SuspendLayout();
            tabPageImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(992, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // tabCtrlInventory
            // 
            tabCtrlInventory.Controls.Add(tabPageImport);
            tabCtrlInventory.Controls.Add(tabPageExpire);
            tabCtrlInventory.Dock = DockStyle.Fill;
            tabCtrlInventory.Location = new Point(0, 0);
            tabCtrlInventory.Name = "tabCtrlInventory";
            tabCtrlInventory.SelectedIndex = 0;
            tabCtrlInventory.Size = new Size(1032, 653);
            tabCtrlInventory.TabIndex = 3;
            // 
            // tabPageImport
            // 
            tabPageImport.Controls.Add(btnImportPro);
            tabPageImport.Controls.Add(panel1);
            tabPageImport.Controls.Add(label6);
            tabPageImport.Controls.Add(dgvProduct);
            tabPageImport.Location = new Point(4, 29);
            tabPageImport.Name = "tabPageImport";
            tabPageImport.Padding = new Padding(3);
            tabPageImport.Size = new Size(1024, 620);
            tabPageImport.TabIndex = 0;
            tabPageImport.Text = "Kho hàng";
            tabPageImport.UseVisualStyleBackColor = true;
            // 
            // tabPageExpire
            // 
            tabPageExpire.Location = new Point(4, 29);
            tabPageExpire.Name = "tabPageExpire";
            tabPageExpire.Padding = new Padding(3);
            tabPageExpire.Size = new Size(1024, 620);
            tabPageExpire.TabIndex = 1;
            tabPageExpire.Text = "Hàng hết hạn";
            tabPageExpire.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(255, 224);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 14;
            label6.Text = "DANH SÁCH NHẬP HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(3, 265);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1018, 352);
            dgvProduct.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(588, 94);
            button1.Name = "button1";
            button1.Size = new Size(145, 39);
            button1.TabIndex = 10;
            button1.Text = "Chi tiết";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtImportDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtImportId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantityImport);
            panel1.Location = new Point(8, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 144);
            panel1.TabIndex = 16;
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
            label3.Text = "Ngày nhập";
            // 
            // txtImportId
            // 
            txtImportId.BackColor = Color.WhiteSmoke;
            txtImportId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportId.Location = new Point(216, 23);
            txtImportId.Name = "txtImportId";
            txtImportId.Size = new Size(214, 34);
            txtImportId.TabIndex = 1;
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
            label1.Text = "Mã nhập hàng";
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
            label2.Text = "Số sản phẩm";
            // 
            // txtQuantityImport
            // 
            txtQuantityImport.BackColor = Color.WhiteSmoke;
            txtQuantityImport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityImport.Location = new Point(630, 23);
            txtQuantityImport.Name = "txtQuantityImport";
            txtQuantityImport.Size = new Size(214, 34);
            txtQuantityImport.TabIndex = 2;
            // 
            // txtImportDate
            // 
            txtImportDate.BackColor = Color.WhiteSmoke;
            txtImportDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportDate.Location = new Point(216, 96);
            txtImportDate.Name = "txtImportDate";
            txtImportDate.Size = new Size(214, 34);
            txtImportDate.TabIndex = 11;
            // 
            // btnImportPro
            // 
            btnImportPro.BackColor = Color.DodgerBlue;
            btnImportPro.Cursor = Cursors.Hand;
            btnImportPro.FlatAppearance.BorderSize = 0;
            btnImportPro.FlatStyle = FlatStyle.Flat;
            btnImportPro.Font = new Font("Times New Roman", 16F);
            btnImportPro.ForeColor = Color.WhiteSmoke;
            btnImportPro.Location = new Point(43, 6);
            btnImportPro.Name = "btnImportPro";
            btnImportPro.Size = new Size(145, 39);
            btnImportPro.TabIndex = 17;
            btnImportPro.Text = "Nhập hàng";
            btnImportPro.UseVisualStyleBackColor = false;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 653);
            Controls.Add(tabCtrlInventory);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            Text = "frmInventory";
            tabCtrlInventory.ResumeLayout(false);
            tabPageImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private TabControl tabCtrlInventory;
        private TabPage tabPageImport;
        private TabPage tabPageExpire;
        private Button button1;
        private Label label6;
        private DataGridView dgvProduct;
        private Panel panel1;
        private Label label3;
        private TextBox txtImportId;
        private Label label1;
        private Label label2;
        private TextBox txtQuantityImport;
        private Button btnImportPro;
        private TextBox txtImportDate;
    }
}