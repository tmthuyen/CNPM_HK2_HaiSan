namespace GUI
{
    partial class frmError : Form
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
            lblTitleMsg = new Label();
            lblMsgContent = new Label();
            panel1 = new Panel();
            btnOkMsg = new Button();
            SuspendLayout();
            // 
            // lblTitleMsg
            // 
            lblTitleMsg.Font = new Font("Sitka Banner", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleMsg.Location = new Point(52, 29);
            lblTitleMsg.Name = "lblTitleMsg";
            lblTitleMsg.Size = new Size(471, 63);
            lblTitleMsg.TabIndex = 0;
            lblTitleMsg.Text = "Ten thong bao";
            lblTitleMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMsgContent
            // 
            lblMsgContent.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsgContent.Location = new Point(52, 139);
            lblMsgContent.Name = "lblMsgContent";
            lblMsgContent.Size = new Size(471, 109);
            lblMsgContent.TabIndex = 1;
            lblMsgContent.Text = "Noi dung";
            lblMsgContent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightYellow;
            panel1.Location = new Point(55, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 3);
            panel1.TabIndex = 2;
            // 
            // btnOkMsg
            // 
            btnOkMsg.BackColor = Color.Firebrick;
            btnOkMsg.FlatAppearance.BorderSize = 0;
            btnOkMsg.FlatStyle = FlatStyle.Flat;
            btnOkMsg.Font = new Font("Times New Roman", 16F);
            btnOkMsg.ForeColor = Color.White;
            btnOkMsg.Location = new Point(221, 251);
            btnOkMsg.Name = "btnOkMsg";
            btnOkMsg.Size = new Size(124, 49);
            btnOkMsg.TabIndex = 8;
            btnOkMsg.Text = "OK";
            btnOkMsg.UseVisualStyleBackColor = false;
            btnOkMsg.Click += btnOkMsg_Click;
            // 
            // frmError
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(574, 324);
            Controls.Add(btnOkMsg);
            Controls.Add(panel1);
            Controls.Add(lblMsgContent);
            Controls.Add(lblTitleMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSuccces";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitleMsg;
        private Label lblMsgContent;
        private Panel panel1;
        private Button btnOkMsg;
    }
}