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
            panel1 = new Panel();
            cbbSortName = new ComboBox();
            cbbCategory = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtCusId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCusPhone = new TextBox();
            dgvProduct = new DataGridView();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbSortName);
            panel1.Controls.Add(cbbCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCusId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCusPhone);
            panel1.Location = new Point(27, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 166);
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
            cbbSortName.TabIndex = 11;
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
            cbbCategory.TabIndex = 10;
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
            // txtCusId
            // 
            txtCusId.BackColor = Color.WhiteSmoke;
            txtCusId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusId.Location = new Point(216, 23);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(214, 34);
            txtCusId.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 5;
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
            // txtCusPhone
            // 
            txtCusPhone.BackColor = Color.WhiteSmoke;
            txtCusPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusPhone.Location = new Point(630, 23);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(214, 34);
            txtCusPhone.TabIndex = 6;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(0, 256);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(932, 307);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(241, 215);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 9;
            label6.Text = "DANH SÁCH SẢN PHẨM";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 563);
            Controls.Add(label6);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbbCategory;
        private Label label3;
        private Label label4;
        private TextBox txtCusId;
        private Label label1;
        private Label label2;
        private TextBox txtCusPhone;
        private ComboBox cbbSortName;
        private DataGridView dgvProduct;
        private Label label6;
    }
}