namespace GUI
{
    partial class frmProfile
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
            panel1 = new Panel();
            richtbProfile = new RichTextBox();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(778, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richtbProfile);
            panel1.Location = new Point(10, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 224);
            panel1.TabIndex = 5;
            // 
            // richtbProfile
            // 
            richtbProfile.Dock = DockStyle.Bottom;
            richtbProfile.Location = new Point(0, 43);
            richtbProfile.Name = "richtbProfile";
            richtbProfile.Size = new Size(789, 181);
            richtbProfile.TabIndex = 6;
            richtbProfile.Text = "";
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 9);
            label4.Name = "label4";
            label4.Size = new Size(296, 31);
            label4.TabIndex = 13;
            label4.Text = "Thông tin cá nhân";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtOldPass);
            panel2.Controls.Add(txtNewPass);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 167);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 31);
            label1.TabIndex = 14;
            label1.Text = "Thay đổi mật khẩu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOldPass
            // 
            txtOldPass.BackColor = Color.WhiteSmoke;
            txtOldPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPass.Location = new Point(153, 55);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(222, 34);
            txtOldPass.TabIndex = 15;
            // 
            // txtNewPass
            // 
            txtNewPass.BackColor = Color.WhiteSmoke;
            txtNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(562, 55);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(222, 34);
            txtNewPass.TabIndex = 16;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 18;
            label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(398, 57);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 17;
            label3.Text = "Mật khẩu mới";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 16F);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(289, 107);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 37);
            btnSave.TabIndex = 19;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 534);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProfile";
            Load += frmProfile_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private RichTextBox richtbProfile;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private Label label2;
        private Label label3;
        private Button btnSave;
    }
}