namespace GUI
{
    partial class frmOrderHistory
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
            txtCusId = new TextBox();
            txtPayment = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCreatedDate = new TextBox();
            txtOrderId = new TextBox();
            label4 = new Label();
            pnCusInfo = new Panel();
            txtChangeAmount = new TextBox();
            label11 = new Label();
            txtReceivedAmount = new TextBox();
            label8 = new Label();
            txtFinalAmount = new TextBox();
            label9 = new Label();
            txtToatalAmount = new TextBox();
            label10 = new Label();
            txtUsedPoint = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtEmpId = new TextBox();
            label6 = new Label();
            dgvCusList = new DataGridView();
            btnExit = new Button();
            pnCusInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCusList).BeginInit();
            SuspendLayout();
            // 
            // txtCusId
            // 
            txtCusId.BackColor = Color.WhiteSmoke;
            txtCusId.Font = new Font("Segoe UI", 10.2F);
            txtCusId.Location = new Point(195, 21);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(138, 30);
            txtCusId.TabIndex = 1;
            // 
            // txtPayment
            // 
            txtPayment.BackColor = Color.WhiteSmoke;
            txtPayment.Enabled = false;
            txtPayment.Font = new Font("Segoe UI", 10.2F);
            txtPayment.Location = new Point(511, 77);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(138, 30);
            txtPayment.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã đơn hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(353, 76);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 7;
            label3.Text = "Thanh toán";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(353, 21);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 3;
            label2.Text = "Mã khách hàng";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.BackColor = Color.WhiteSmoke;
            txtCreatedDate.Enabled = false;
            txtCreatedDate.Font = new Font("Segoe UI", 10.2F);
            txtCreatedDate.Location = new Point(195, 76);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.Size = new Size(138, 30);
            txtCreatedDate.TabIndex = 2;
            // 
            // txtOrderId
            // 
            txtOrderId.BackColor = Color.WhiteSmoke;
            txtOrderId.Font = new Font("Segoe UI", 10.2F);
            txtOrderId.Location = new Point(511, 21);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(138, 30);
            txtOrderId.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(37, 75);
            label4.Name = "label4";
            label4.Size = new Size(138, 31);
            label4.TabIndex = 5;
            label4.Text = "Ngày lập";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnCusInfo
            // 
            pnCusInfo.Controls.Add(txtChangeAmount);
            pnCusInfo.Controls.Add(label11);
            pnCusInfo.Controls.Add(txtReceivedAmount);
            pnCusInfo.Controls.Add(label8);
            pnCusInfo.Controls.Add(txtFinalAmount);
            pnCusInfo.Controls.Add(label9);
            pnCusInfo.Controls.Add(txtToatalAmount);
            pnCusInfo.Controls.Add(label10);
            pnCusInfo.Controls.Add(txtUsedPoint);
            pnCusInfo.Controls.Add(label7);
            pnCusInfo.Controls.Add(label5);
            pnCusInfo.Controls.Add(txtEmpId);
            pnCusInfo.Controls.Add(txtCusId);
            pnCusInfo.Controls.Add(txtPayment);
            pnCusInfo.Controls.Add(label1);
            pnCusInfo.Controls.Add(label3);
            pnCusInfo.Controls.Add(label2);
            pnCusInfo.Controls.Add(txtCreatedDate);
            pnCusInfo.Controls.Add(txtOrderId);
            pnCusInfo.Controls.Add(label4);
            pnCusInfo.Location = new Point(0, 40);
            pnCusInfo.Name = "pnCusInfo";
            pnCusInfo.Size = new Size(1000, 238);
            pnCusInfo.TabIndex = 10;
            // 
            // txtChangeAmount
            // 
            txtChangeAmount.BackColor = Color.WhiteSmoke;
            txtChangeAmount.Enabled = false;
            txtChangeAmount.Font = new Font("Segoe UI", 10.2F);
            txtChangeAmount.Location = new Point(669, 178);
            txtChangeAmount.Name = "txtChangeAmount";
            txtChangeAmount.Size = new Size(138, 30);
            txtChangeAmount.TabIndex = 18;
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(511, 177);
            label11.Name = "label11";
            label11.Size = new Size(138, 31);
            label11.TabIndex = 19;
            label11.Text = "Tiền thừa";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.BackColor = Color.WhiteSmoke;
            txtReceivedAmount.Enabled = false;
            txtReceivedAmount.Font = new Font("Segoe UI", 10.2F);
            txtReceivedAmount.Location = new Point(353, 178);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(138, 30);
            txtReceivedAmount.TabIndex = 16;
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(195, 177);
            label8.Name = "label8";
            label8.Size = new Size(138, 31);
            label8.TabIndex = 17;
            label8.Text = "Khách đưa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFinalAmount
            // 
            txtFinalAmount.BackColor = Color.WhiteSmoke;
            txtFinalAmount.Enabled = false;
            txtFinalAmount.Font = new Font("Segoe UI", 10.2F);
            txtFinalAmount.Location = new Point(669, 129);
            txtFinalAmount.Name = "txtFinalAmount";
            txtFinalAmount.Size = new Size(138, 30);
            txtFinalAmount.TabIndex = 13;
            // 
            // label9
            // 
            label9.BackColor = Color.LightSkyBlue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(511, 128);
            label9.Name = "label9";
            label9.Size = new Size(138, 31);
            label9.TabIndex = 15;
            label9.Text = "Phải trả";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtToatalAmount
            // 
            txtToatalAmount.BackColor = Color.WhiteSmoke;
            txtToatalAmount.Enabled = false;
            txtToatalAmount.Font = new Font("Segoe UI", 10.2F);
            txtToatalAmount.Location = new Point(353, 128);
            txtToatalAmount.Name = "txtToatalAmount";
            txtToatalAmount.Size = new Size(138, 30);
            txtToatalAmount.TabIndex = 12;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(195, 127);
            label10.Name = "label10";
            label10.Size = new Size(138, 31);
            label10.TabIndex = 14;
            label10.Text = "Tổng tiền";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsedPoint
            // 
            txtUsedPoint.BackColor = Color.WhiteSmoke;
            txtUsedPoint.Enabled = false;
            txtUsedPoint.Font = new Font("Segoe UI", 10.2F);
            txtUsedPoint.Location = new Point(827, 78);
            txtUsedPoint.Name = "txtUsedPoint";
            txtUsedPoint.Size = new Size(138, 30);
            txtUsedPoint.TabIndex = 10;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(669, 77);
            label7.Name = "label7";
            label7.Size = new Size(138, 31);
            label7.TabIndex = 11;
            label7.Text = "Điểm sử dụng";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(669, 21);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 9;
            label5.Text = "Mã nhân viên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmpId
            // 
            txtEmpId.BackColor = Color.WhiteSmoke;
            txtEmpId.Font = new Font("Segoe UI", 10.2F);
            txtEmpId.Location = new Point(827, 21);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(138, 30);
            txtEmpId.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(279, 367);
            label6.Name = "label6";
            label6.Size = new Size(441, 38);
            label6.TabIndex = 11;
            label6.Text = "CHI TIẾT ĐƠN HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCusList
            // 
            dgvCusList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCusList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusList.Dock = DockStyle.Bottom;
            dgvCusList.Location = new Point(0, 408);
            dgvCusList.Name = "dgvCusList";
            dgvCusList.RowHeadersWidth = 51;
            dgvCusList.Size = new Size(1000, 292);
            dgvCusList.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(970, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 12;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmOrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(btnExit);
            Controls.Add(dgvCusList);
            Controls.Add(pnCusInfo);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrderHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrderHistory";
            pnCusInfo.ResumeLayout(false);
            pnCusInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCusList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCusId;
        private TextBox txtPayment;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtCreatedDate;
        private TextBox txtOrderId;
        private Label label4;
        private Panel pnCusInfo;
        private Label label6;
        private DataGridView dgvCusList;
        private Label label5;
        private TextBox txtEmpId;
        private TextBox txtUsedPoint;
        private Label label7;
        private TextBox txtChangeAmount;
        private Label label11;
        private TextBox txtReceivedAmount;
        private Label label8;
        private TextBox txtFinalAmount;
        private Label label9;
        private TextBox txtToatalAmount;
        private Label label10;
        private Button btnExit;
    }
}