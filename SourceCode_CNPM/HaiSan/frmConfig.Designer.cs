namespace GUI
{
    partial class frmConfig
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkWinOrSql = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            textBoxServer = new TextBox();
            textBoxDB = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPass = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên database";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 219);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // chkWinOrSql
            // 
            chkWinOrSql.Location = new Point(125, 269);
            chkWinOrSql.Margin = new Padding(3, 4, 3, 4);
            chkWinOrSql.Name = "chkWinOrSql";
            chkWinOrSql.Size = new Size(193, 32);
            chkWinOrSql.TabIndex = 4;
            chkWinOrSql.Text = "Windows Authentification";
            chkWinOrSql.UseVisualStyleBackColor = true;
            chkWinOrSql.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(17, 312);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += save;
            button1.KeyDown += enterPressed;
            // 
            // button2
            // 
            button2.Location = new Point(283, 312);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancel;
            button2.KeyDown += cancelEnterPressed;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(125, 44);
            textBoxServer.Margin = new Padding(3, 4, 3, 4);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(244, 27);
            textBoxServer.TabIndex = 0;
            textBoxServer.KeyDown += enterPressed;
            // 
            // textBoxDB
            // 
            textBoxDB.Location = new Point(125, 104);
            textBoxDB.Margin = new Padding(3, 4, 3, 4);
            textBoxDB.Name = "textBoxDB";
            textBoxDB.Size = new Size(244, 27);
            textBoxDB.TabIndex = 1;
            textBoxDB.KeyDown += enterPressed;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(125, 159);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(244, 27);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.KeyDown += enterPressed;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(125, 215);
            textBoxPass.Margin = new Padding(3, 4, 3, 4);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(244, 27);
            textBoxPass.TabIndex = 3;
            textBoxPass.KeyDown += enterPressed;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(387, 40);
            label5.TabIndex = 7;
            label5.Text = "Hãy nhập cấu hình cở sở dữ liệu";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 391);
            Controls.Add(label5);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxDB);
            Controls.Add(textBoxServer);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkWinOrSql);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkWinOrSql;
        private Button button1;
        private Button button2;
        private TextBox textBoxServer;
        private TextBox textBoxDB;
        private TextBox textBoxUsername;
        private TextBox textBoxPass;
        private Label label5;
    }
}