namespace GUI
{
    partial class frmHome
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
            label2 = new Label();
            dgvTopProduct = new DataGridView();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTopProduct).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(268, 208);
            label2.Name = "label2";
            label2.Size = new Size(421, 44);
            label2.TabIndex = 0;
            label2.Text = "Sản phẩm bán chạy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTopProduct
            // 
            dgvTopProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopProduct.BackgroundColor = Color.WhiteSmoke;
            dgvTopProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopProduct.Dock = DockStyle.Bottom;
            dgvTopProduct.Location = new Point(0, 255);
            dgvTopProduct.Name = "dgvTopProduct";
            dgvTopProduct.RowHeadersWidth = 51;
            dgvTopProduct.Size = new Size(950, 355);
            dgvTopProduct.TabIndex = 1;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Top;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Tomato;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(950, 62);
            label11.TabIndex = 52;
            label11.Text = "CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ CỬA HÀNG HẢI SẢN";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 610);
            Controls.Add(label11);
            Controls.Add(dgvTopProduct);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTopProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private DataGridView dgvTopProduct;
        private Label label11;
    }
}