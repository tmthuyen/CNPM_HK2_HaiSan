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
            pnCTKM = new Panel();
            label3 = new Label();
            pnProTop = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // pnCTKM
            // 
            pnCTKM.Location = new Point(25, 362);
            pnCTKM.Name = "pnCTKM";
            pnCTKM.Size = new Size(900, 220);
            pnCTKM.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(268, 315);
            label3.Name = "label3";
            label3.Size = new Size(421, 44);
            label3.TabIndex = 0;
            label3.Text = "Chương trình khuyến mãi mới";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnProTop
            // 
            pnProTop.Location = new Point(25, 64);
            pnProTop.Name = "pnProTop";
            pnProTop.Size = new Size(900, 220);
            pnProTop.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(421, 44);
            label2.TabIndex = 0;
            label2.Text = "Sản phẩm bán chạy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 610);
            Controls.Add(label3);
            Controls.Add(pnCTKM);
            Controls.Add(label2);
            Controls.Add(pnProTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnCTKM;
        private Label label3;
        private Panel pnProTop;
        private Label label2;
    }
}