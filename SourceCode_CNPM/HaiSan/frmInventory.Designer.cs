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
            btnImportPro = new Button();
            panel1 = new Panel();
            btnSeeImport = new Button();
            txtImportDate = new TextBox();
            label3 = new Label();
            txtImportId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtQuantityImport = new TextBox();
            label6 = new Label();
            dgvImportList = new DataGridView();
            tabPageExpire = new TabPage();
            label4 = new Label();
            dgvExpire = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            txtProId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtProName = new TextBox();
            lblAppName = new Label();
            tabCtrlInventory.SuspendLayout();
            tabPageImport.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).BeginInit();
            tabPageExpire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpire).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1002, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // tabCtrlInventory
            // 
            tabCtrlInventory.Controls.Add(tabPageImport);
            tabCtrlInventory.Controls.Add(tabPageExpire);
            tabCtrlInventory.Dock = DockStyle.Bottom;
            tabCtrlInventory.Location = new Point(0, 40);
            tabCtrlInventory.Name = "tabCtrlInventory";
            tabCtrlInventory.SelectedIndex = 0;
            tabCtrlInventory.Size = new Size(1032, 643);
            tabCtrlInventory.TabIndex = 3;
            tabCtrlInventory.SelectedIndexChanged += tabCtrlInventory_SelectedIndexChanged;
            // 
            // tabPageImport
            // 
            tabPageImport.Controls.Add(btnImportPro);
            tabPageImport.Controls.Add(panel1);
            tabPageImport.Controls.Add(label6);
            tabPageImport.Controls.Add(dgvImportList);
            tabPageImport.Location = new Point(4, 29);
            tabPageImport.Name = "tabPageImport";
            tabPageImport.Padding = new Padding(3);
            tabPageImport.Size = new Size(1024, 610);
            tabPageImport.TabIndex = 0;
            tabPageImport.Text = "Kho hàng";
            tabPageImport.UseVisualStyleBackColor = true;
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
            btnImportPro.Click += btnImportPro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSeeImport);
            panel1.Controls.Add(txtImportDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtImportId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantityImport);
            panel1.Location = new Point(8, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 144);
            panel1.TabIndex = 16;
            // 
            // btnSeeImport
            // 
            btnSeeImport.BackColor = Color.DodgerBlue;
            btnSeeImport.Cursor = Cursors.Hand;
            btnSeeImport.FlatAppearance.BorderSize = 0;
            btnSeeImport.FlatStyle = FlatStyle.Flat;
            btnSeeImport.Font = new Font("Times New Roman", 16F);
            btnSeeImport.ForeColor = Color.WhiteSmoke;
            btnSeeImport.Location = new Point(689, 88);
            btnSeeImport.Name = "btnSeeImport";
            btnSeeImport.Size = new Size(145, 39);
            btnSeeImport.TabIndex = 10;
            btnSeeImport.Text = "Chi tiết";
            btnSeeImport.UseVisualStyleBackColor = false;
            btnSeeImport.Click += btnSeeImport_Click;
            // 
            // txtImportDate
            // 
            txtImportDate.BackColor = Color.WhiteSmoke;
            txtImportDate.Enabled = false;
            txtImportDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportDate.Location = new Point(232, 88);
            txtImportDate.Name = "txtImportDate";
            txtImportDate.ReadOnly = true;
            txtImportDate.Size = new Size(214, 34);
            txtImportDate.TabIndex = 11;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 88);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 8;
            label3.Text = "Ngày nhập";
            // 
            // txtImportId
            // 
            txtImportId.BackColor = Color.WhiteSmoke;
            txtImportId.Enabled = false;
            txtImportId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportId.Location = new Point(232, 25);
            txtImportId.Name = "txtImportId";
            txtImportId.ReadOnly = true;
            txtImportId.Size = new Size(214, 34);
            txtImportId.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 27);
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
            label2.Location = new Point(555, 26);
            label2.Name = "label2";
            label2.Size = new Size(156, 31);
            label2.TabIndex = 7;
            label2.Text = "Số sản phẩm";
            // 
            // txtQuantityImport
            // 
            txtQuantityImport.BackColor = Color.WhiteSmoke;
            txtQuantityImport.Enabled = false;
            txtQuantityImport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityImport.Location = new Point(736, 24);
            txtQuantityImport.Name = "txtQuantityImport";
            txtQuantityImport.ReadOnly = true;
            txtQuantityImport.Size = new Size(214, 34);
            txtQuantityImport.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(292, 214);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 14;
            label6.Text = "DANH SÁCH NHẬP HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvImportList
            // 
            dgvImportList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportList.Dock = DockStyle.Bottom;
            dgvImportList.Location = new Point(3, 255);
            dgvImportList.Name = "dgvImportList";
            dgvImportList.RowHeadersWidth = 51;
            dgvImportList.Size = new Size(1018, 352);
            dgvImportList.TabIndex = 15;
            dgvImportList.CellClick += dgvImportList_CellClick;
            dgvImportList.SelectionChanged += dgvImportList_SelectionChanged;
            // 
            // tabPageExpire
            // 
            tabPageExpire.Controls.Add(label4);
            tabPageExpire.Controls.Add(dgvExpire);
            tabPageExpire.Controls.Add(panel2);
            tabPageExpire.Location = new Point(4, 29);
            tabPageExpire.Name = "tabPageExpire";
            tabPageExpire.Padding = new Padding(3);
            tabPageExpire.Size = new Size(1024, 610);
            tabPageExpire.TabIndex = 1;
            tabPageExpire.Text = "Hàng hết hạn";
            tabPageExpire.UseVisualStyleBackColor = true;
            tabPageExpire.Click += tabPageExpire_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 175);
            label4.Name = "label4";
            label4.Size = new Size(336, 52);
            label4.TabIndex = 21;
            label4.Text = "DANH SÁCH HẾT HẠN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvExpire
            // 
            dgvExpire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpire.Dock = DockStyle.Bottom;
            dgvExpire.GridColor = Color.White;
            dgvExpire.Location = new Point(3, 230);
            dgvExpire.Name = "dgvExpire";
            dgvExpire.RowHeadersWidth = 51;
            dgvExpire.Size = new Size(1018, 377);
            dgvExpire.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtProId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtProName);
            panel2.Location = new Point(23, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 103);
            panel2.TabIndex = 20;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(313, 0);
            label5.Name = "label5";
            label5.Size = new Size(351, 31);
            label5.TabIndex = 11;
            label5.Text = "TÌM KIẾM";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProId
            // 
            txtProId.BackColor = Color.WhiteSmoke;
            txtProId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProId.Location = new Point(264, 52);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(214, 34);
            txtProId.TabIndex = 1;
            txtProId.TextChanged += txtProId_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 55);
            label7.Name = "label7";
            label7.Size = new Size(141, 31);
            label7.TabIndex = 10;
            label7.Text = "Mã sản phẩm";
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(502, 55);
            label8.Name = "label8";
            label8.Size = new Size(141, 31);
            label8.TabIndex = 7;
            label8.Text = "Tên sản phẩm";
            // 
            // txtProName
            // 
            txtProName.BackColor = Color.WhiteSmoke;
            txtProName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProName.Location = new Point(669, 52);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(214, 34);
            txtProName.TabIndex = 2;
            txtProName.TextChanged += txtProName_TextChanged;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Silver;
            lblAppName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(0, -1);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(1032, 40);
            lblAppName.TabIndex = 4;
            lblAppName.Text = "Ứng dụng quản lý cửa hàng hải sản";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 683);
            Controls.Add(tabCtrlInventory);
            Controls.Add(btnExit);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventory";
            Load += frmInventory_Load;
            tabCtrlInventory.ResumeLayout(false);
            tabPageImport.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportList).EndInit();
            tabPageExpire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpire).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private TabControl tabCtrlInventory;
        private TabPage tabPageImport;
        private TabPage tabPageExpire;
        private Button btnSeeImport;
        private Label label6;
        private DataGridView dgvImportList;
        private Panel panel1;
        private Label label3;
        private TextBox txtImportId;
        private Label label1;
        private Label label2;
        private TextBox txtQuantityImport;
        private Button btnImportPro;
        private TextBox txtImportDate;
        private Label lblAppName;
        private Panel panel2;
        private TextBox txtProId;
        private Label label7;
        private Label label8;
        private TextBox txtProName;
        private Label label4;
        private DataGridView dgvExpire;
        private Label label5;
    }
}