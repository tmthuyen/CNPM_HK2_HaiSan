namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnExit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtTK = new TextBox();
            lblTK = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            txtMK = new TextBox();
            lblMK = new Label();
            ptbMK = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMK).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(513, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 191);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 1;
            label1.Text = "Seafood Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTK);
            panel1.Controls.Add(lblTK);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(109, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 73);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(52, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 2);
            panel2.TabIndex = 4;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.FromArgb(192, 255, 255);
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(52, 43);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(262, 27);
            txtTK.TabIndex = 0;
            // 
            // lblTK
            // 
            lblTK.AutoSize = true;
            lblTK.Cursor = Cursors.Hand;
            lblTK.Font = new Font("Times New Roman", 14F);
            lblTK.Location = new Point(52, 13);
            lblTK.Name = "lblTK";
            lblTK.Size = new Size(108, 27);
            lblTK.TabIndex = 1;
            lblTK.Text = "Tài khoản";
            lblTK.Click += lblTK_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtMK);
            panel3.Controls.Add(lblMK);
            panel3.Controls.Add(ptbMK);
            panel3.Location = new Point(109, 359);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 73);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Location = new Point(52, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 2);
            panel4.TabIndex = 4;
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.FromArgb(192, 255, 255);
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(52, 43);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(262, 27);
            txtMK.TabIndex = 1;
            txtMK.UseSystemPasswordChar = true;
            txtMK.TextChanged += txtMK_TextChanged;
            txtMK.KeyUp += txtMK_KeyUp;
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Cursor = Cursors.Hand;
            lblMK.Font = new Font("Times New Roman", 14F);
            lblMK.Location = new Point(52, 13);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(104, 27);
            lblMK.TabIndex = 1;
            lblMK.Text = "Mật khẩu";
            lblMK.Click += lblMK_Click;
            // 
            // ptbMK
            // 
            ptbMK.Cursor = Cursors.Hand;
            ptbMK.Image = (Image)resources.GetObject("ptbMK.Image");
            ptbMK.Location = new Point(0, 36);
            ptbMK.Name = "ptbMK";
            ptbMK.Size = new Size(41, 37);
            ptbMK.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMK.TabIndex = 0;
            ptbMK.TabStop = false;
            ptbMK.Click += pictureBox3_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 16F);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(135, 472);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(273, 49);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(543, 579);
            Controls.Add(btnLogin);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTK;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txtTK;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtMK;
        private Label lblMK;
        private PictureBox ptbMK;
        private Button btnLogin;
    }
}