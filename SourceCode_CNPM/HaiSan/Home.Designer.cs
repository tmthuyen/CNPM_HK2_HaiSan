using NAudio.Wave;

namespace GUI
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnSideBar = new Panel();
            btnEmp = new Button();
            volumeBar = new TrackBar();
            label1 = new Label();
            btnMute = new Button();
            btnVolUp = new Button();
            btnVolDown = new Button();
            btnPromotion = new Button();
            btnReport = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            btnHome = new Button();
            pnUser = new Panel();
            lblUserName = new Label();
            ptbAvatar = new PictureBox();
            pictureBox1 = new PictureBox();
            pnRight = new Panel();
            pnForm = new Panel();
            pnHead = new Panel();
            lblTitle = new Label();
            panel1 = new Panel();
            lblAppName = new Label();
            btnExit = new Button();
            pnContain = new Panel();
            cmstAccount = new ContextMenuStrip(components);
            profileCmstrItem = new ToolStripMenuItem();
            logoutTooltipMItem = new ToolStripMenuItem();
            pnSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnRight.SuspendLayout();
            pnHead.SuspendLayout();
            panel1.SuspendLayout();
            pnContain.SuspendLayout();
            cmstAccount.SuspendLayout();
            SuspendLayout();
            // 
            // pnSideBar
            // 
            pnSideBar.BackColor = Color.DodgerBlue;
            pnSideBar.Controls.Add(btnEmp);
            pnSideBar.Controls.Add(volumeBar);
            pnSideBar.Controls.Add(label1);
            pnSideBar.Controls.Add(btnMute);
            pnSideBar.Controls.Add(btnVolUp);
            pnSideBar.Controls.Add(btnVolDown);
            pnSideBar.Controls.Add(btnPromotion);
            pnSideBar.Controls.Add(btnReport);
            pnSideBar.Controls.Add(btnCustomer);
            pnSideBar.Controls.Add(btnProduct);
            pnSideBar.Controls.Add(btnOrder);
            pnSideBar.Controls.Add(btnHome);
            pnSideBar.Controls.Add(pnUser);
            pnSideBar.Dock = DockStyle.Left;
            pnSideBar.Location = new Point(0, 0);
            pnSideBar.Name = "pnSideBar";
            pnSideBar.Size = new Size(250, 760);
            pnSideBar.TabIndex = 2;
            // 
            // btnEmp
            // 
            btnEmp.AutoSize = true;
            btnEmp.BackColor = Color.DodgerBlue;
            btnEmp.Dock = DockStyle.Top;
            btnEmp.FlatAppearance.BorderSize = 0;
            btnEmp.FlatStyle = FlatStyle.Flat;
            btnEmp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmp.ForeColor = Color.White;
            btnEmp.Location = new Point(0, 401);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(250, 42);
            btnEmp.TabIndex = 13;
            btnEmp.Text = "Nhân viên";
            btnEmp.UseVisualStyleBackColor = false;
            btnEmp.Click += btnEmp_Click;
            // 
            // volumeBar
            // 
            volumeBar.LargeChange = 10;
            volumeBar.Location = new Point(117, 717);
            volumeBar.Margin = new Padding(3, 4, 3, 4);
            volumeBar.Maximum = 100;
            volumeBar.Name = "volumeBar";
            volumeBar.Size = new Size(98, 56);
            volumeBar.SmallChange = 5;
            volumeBar.TabIndex = 12;
            volumeBar.TickFrequency = 10;
            volumeBar.Value = 50;
            volumeBar.Scroll += VolumeSlider_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 724);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 11;
            label1.Text = "🔊";
            // 
            // btnMute
            // 
            btnMute.AutoSize = true;
            btnMute.Location = new Point(33, 717);
            btnMute.Margin = new Padding(3, 4, 3, 4);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(61, 40);
            btnMute.TabIndex = 10;
            btnMute.Text = "Mute";
            btnMute.UseVisualStyleBackColor = true;
            btnMute.Click += BtnMute_Click;
            // 
            // btnVolUp
            // 
            btnVolUp.AutoSize = true;
            btnVolUp.Location = new Point(222, 717);
            btnVolUp.Margin = new Padding(3, 4, 3, 4);
            btnVolUp.Name = "btnVolUp";
            btnVolUp.Size = new Size(33, 40);
            btnVolUp.TabIndex = 9;
            btnVolUp.Text = "+";
            btnVolUp.UseVisualStyleBackColor = true;
            btnVolUp.Click += BtnIncreaseVol_Click;
            // 
            // btnVolDown
            // 
            btnVolDown.AutoSize = true;
            btnVolDown.Location = new Point(91, 717);
            btnVolDown.Margin = new Padding(3, 4, 3, 4);
            btnVolDown.Name = "btnVolDown";
            btnVolDown.Size = new Size(31, 40);
            btnVolDown.TabIndex = 8;
            btnVolDown.Text = "-";
            btnVolDown.UseVisualStyleBackColor = true;
            btnVolDown.Click += BtnDecreaseVol_Click;
            // 
            // btnPromotion
            // 
            btnPromotion.AutoSize = true;
            btnPromotion.BackColor = Color.DodgerBlue;
            btnPromotion.Dock = DockStyle.Top;
            btnPromotion.FlatAppearance.BorderSize = 0;
            btnPromotion.FlatStyle = FlatStyle.Flat;
            btnPromotion.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromotion.ForeColor = Color.White;
            btnPromotion.Location = new Point(0, 359);
            btnPromotion.Name = "btnPromotion";
            btnPromotion.Size = new Size(250, 42);
            btnPromotion.TabIndex = 6;
            btnPromotion.Text = "Khuyến Mãi";
            btnPromotion.UseVisualStyleBackColor = false;
            btnPromotion.Click += btnPromotion_Click;
            // 
            // btnReport
            // 
            btnReport.AutoSize = true;
            btnReport.BackColor = Color.DodgerBlue;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(0, 317);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 42);
            btnReport.TabIndex = 5;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.AutoSize = true;
            btnCustomer.BackColor = Color.DodgerBlue;
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(0, 275);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(250, 42);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.AutoSize = true;
            btnProduct.BackColor = Color.DodgerBlue;
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(0, 233);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(250, 42);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.AutoSize = true;
            btnOrder.BackColor = Color.DodgerBlue;
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(0, 191);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(250, 42);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Đơn hàng";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnHome
            // 
            btnHome.AutoSize = true;
            btnHome.BackColor = Color.DodgerBlue;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 149);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Trang chủ";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnUser
            // 
            pnUser.Controls.Add(lblUserName);
            pnUser.Controls.Add(ptbAvatar);
            pnUser.Dock = DockStyle.Top;
            pnUser.Location = new Point(0, 0);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(250, 149);
            pnUser.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(8, 105);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(234, 43);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Tran Minh Thuyen";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbAvatar
            // 
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.Location = new Point(48, 0);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(158, 101);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 0;
            ptbAvatar.TabStop = false;
            ptbAvatar.MouseEnter += ptbAvatar_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(747, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnRight
            // 
            pnRight.Controls.Add(pnForm);
            pnRight.Controls.Add(pnHead);
            pnRight.Dock = DockStyle.Right;
            pnRight.Location = new Point(250, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(950, 760);
            pnRight.TabIndex = 3;
            // 
            // pnForm
            // 
            pnForm.BackColor = Color.White;
            pnForm.Dock = DockStyle.Fill;
            pnForm.Location = new Point(0, 149);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(950, 611);
            pnForm.TabIndex = 2;
            // 
            // pnHead
            // 
            pnHead.BackColor = Color.LightCyan;
            pnHead.Controls.Add(pictureBox1);
            pnHead.Controls.Add(lblTitle);
            pnHead.Dock = DockStyle.Top;
            pnHead.Location = new Point(0, 0);
            pnHead.Name = "pnHead";
            pnHead.Size = new Size(950, 149);
            pnHead.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(31, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ten form";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(lblAppName);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 40);
            panel1.TabIndex = 4;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(915, 40);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "Ứng dụng quản lý cửa hàng hải sản";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1160, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnContain
            // 
            pnContain.Controls.Add(pnSideBar);
            pnContain.Controls.Add(pnRight);
            pnContain.Dock = DockStyle.Bottom;
            pnContain.Location = new Point(0, 40);
            pnContain.Name = "pnContain";
            pnContain.Size = new Size(1200, 760);
            pnContain.TabIndex = 5;
            // 
            // cmstAccount
            // 
            cmstAccount.BackColor = Color.DeepSkyBlue;
            cmstAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmstAccount.ImageScalingSize = new Size(20, 20);
            cmstAccount.Items.AddRange(new ToolStripItem[] { profileCmstrItem, logoutTooltipMItem });
            cmstAccount.Name = "cmstAccount";
            cmstAccount.RenderMode = ToolStripRenderMode.System;
            cmstAccount.Size = new Size(231, 64);
            cmstAccount.MouseEnter += cmstAccount_MouseEnter;
            cmstAccount.MouseLeave += cmstAccount_MouseLeave;
            // 
            // profileCmstrItem
            // 
            profileCmstrItem.Name = "profileCmstrItem";
            profileCmstrItem.Size = new Size(230, 30);
            profileCmstrItem.Text = "Hồ sơ tài khoản";
            profileCmstrItem.Click += profileCmstrItem_Click;
            // 
            // logoutTooltipMItem
            // 
            logoutTooltipMItem.Name = "logoutTooltipMItem";
            logoutTooltipMItem.Size = new Size(230, 30);
            logoutTooltipMItem.Text = "Đăng xuất";
            logoutTooltipMItem.Click += logoutTooltipMItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel1);
            Controls.Add(pnContain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHome";
            FormClosing += MainForm_FormClosing;
            Load += Home_Load;
            pnSideBar.ResumeLayout(false);
            pnSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnRight.ResumeLayout(false);
            pnHead.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnContain.ResumeLayout(false);
            cmstAccount.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnSideBar;
        private Panel pnUser;
        private PictureBox pictureBox1;
        private Panel pnRight;
        private Button btnHome;
        private Panel panel1;
        private Button btnExit;
        private Label lblAppName;
        private Panel pnContain;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnOrder;
        private Button btnReport;
        private Label lblTitle;
        private Panel pnHead;
        private PictureBox ptbAvatar;
        private Label lblUserName;
        private ContextMenuStrip cmstAccount;
        private ToolStripMenuItem profileCmstrItem;
        private ToolStripMenuItem logoutTooltipMItem;
        private Panel pnForm;
        private Button btnPromotion;
        private Button btnVolUp;
        private Button btnVolDown;
        private Button btnMute;
        private Label label1;
        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;
        private TrackBar volumeBar;
        private Button btnEmp;
    }
}