namespace GUI
{
    partial class frmOrderDetail
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
            txtOrderId = new TextBox();
            txtPayment = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCreatedDate = new TextBox();
            txtPhone = new TextBox();
            label4 = new Label();
            pnCusInfo = new Panel();
            txtChangeAmount = new TextBox();
            label11 = new Label();
            txtReceivedAmount = new TextBox();
            label8 = new Label();
            txtTotalAmount = new TextBox();
            label9 = new Label();
            txtRawAmount = new TextBox();
            label10 = new Label();
            txtUsedPoint = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtEmpId = new TextBox();
            label6 = new Label();
            dgvOrderDetail = new DataGridView();
            btnExit = new Button();
            pnCusInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // txtOrderId
            // 
            txtOrderId.BackColor = Color.WhiteSmoke;
            txtOrderId.Enabled = false;
            txtOrderId.Font = new Font("Segoe UI", 10.2F);
            txtOrderId.Location = new Point(171, 16);
            txtOrderId.Margin = new Padding(3, 2, 3, 2);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(121, 26);
            txtOrderId.TabIndex = 1;
            // 
            // txtPayment
            // 
            txtPayment.BackColor = Color.WhiteSmoke;
            txtPayment.Enabled = false;
            txtPayment.Font = new Font("Segoe UI", 10.2F);
            txtPayment.Location = new Point(447, 58);
            txtPayment.Margin = new Padding(3, 2, 3, 2);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(121, 26);
            txtPayment.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã đơn hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(309, 57);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 7;
            label3.Text = "Thanh toán";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(309, 16);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 3;
            label2.Text = "SĐT Khách";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.BackColor = Color.WhiteSmoke;
            txtCreatedDate.Enabled = false;
            txtCreatedDate.Font = new Font("Segoe UI", 10.2F);
            txtCreatedDate.Location = new Point(171, 57);
            txtCreatedDate.Margin = new Padding(3, 2, 3, 2);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.Size = new Size(121, 26);
            txtCreatedDate.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Segoe UI", 10.2F);
            txtPhone.Location = new Point(447, 16);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 26);
            txtPhone.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSkyBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(32, 56);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
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
            pnCusInfo.Controls.Add(txtTotalAmount);
            pnCusInfo.Controls.Add(label9);
            pnCusInfo.Controls.Add(txtRawAmount);
            pnCusInfo.Controls.Add(label10);
            pnCusInfo.Controls.Add(txtUsedPoint);
            pnCusInfo.Controls.Add(label7);
            pnCusInfo.Controls.Add(label5);
            pnCusInfo.Controls.Add(txtEmpId);
            pnCusInfo.Controls.Add(txtOrderId);
            pnCusInfo.Controls.Add(txtPayment);
            pnCusInfo.Controls.Add(label1);
            pnCusInfo.Controls.Add(label3);
            pnCusInfo.Controls.Add(label2);
            pnCusInfo.Controls.Add(txtCreatedDate);
            pnCusInfo.Controls.Add(txtPhone);
            pnCusInfo.Controls.Add(label4);
            pnCusInfo.Location = new Point(0, 30);
            pnCusInfo.Margin = new Padding(3, 2, 3, 2);
            pnCusInfo.Name = "pnCusInfo";
            pnCusInfo.Size = new Size(875, 178);
            pnCusInfo.TabIndex = 10;
            // 
            // txtChangeAmount
            // 
            txtChangeAmount.BackColor = Color.WhiteSmoke;
            txtChangeAmount.Enabled = false;
            txtChangeAmount.Font = new Font("Segoe UI", 10.2F);
            txtChangeAmount.Location = new Point(585, 134);
            txtChangeAmount.Margin = new Padding(3, 2, 3, 2);
            txtChangeAmount.Name = "txtChangeAmount";
            txtChangeAmount.Size = new Size(121, 26);
            txtChangeAmount.TabIndex = 18;
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(447, 133);
            label11.Name = "label11";
            label11.Size = new Size(121, 23);
            label11.TabIndex = 19;
            label11.Text = "Tiền thừa";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.BackColor = Color.WhiteSmoke;
            txtReceivedAmount.Enabled = false;
            txtReceivedAmount.Font = new Font("Segoe UI", 10.2F);
            txtReceivedAmount.Location = new Point(309, 134);
            txtReceivedAmount.Margin = new Padding(3, 2, 3, 2);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(121, 26);
            txtReceivedAmount.TabIndex = 16;
            // 
            // label8
            // 
            label8.BackColor = Color.LightSkyBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(171, 133);
            label8.Name = "label8";
            label8.Size = new Size(121, 23);
            label8.TabIndex = 17;
            label8.Text = "Khách đưa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.WhiteSmoke;
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F);
            txtTotalAmount.Location = new Point(585, 97);
            txtTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(121, 26);
            txtTotalAmount.TabIndex = 13;
            // 
            // label9
            // 
            label9.BackColor = Color.LightSkyBlue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(447, 96);
            label9.Name = "label9";
            label9.Size = new Size(121, 23);
            label9.TabIndex = 15;
            label9.Text = "Phải trả";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRawAmount
            // 
            txtRawAmount.BackColor = Color.WhiteSmoke;
            txtRawAmount.Enabled = false;
            txtRawAmount.Font = new Font("Segoe UI", 10.2F);
            txtRawAmount.Location = new Point(309, 96);
            txtRawAmount.Margin = new Padding(3, 2, 3, 2);
            txtRawAmount.Name = "txtRawAmount";
            txtRawAmount.Size = new Size(121, 26);
            txtRawAmount.TabIndex = 12;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSkyBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(171, 95);
            label10.Name = "label10";
            label10.Size = new Size(121, 23);
            label10.TabIndex = 14;
            label10.Text = "Tiền trước giảm";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsedPoint
            // 
            txtUsedPoint.BackColor = Color.WhiteSmoke;
            txtUsedPoint.Enabled = false;
            txtUsedPoint.Font = new Font("Segoe UI", 10.2F);
            txtUsedPoint.Location = new Point(724, 58);
            txtUsedPoint.Margin = new Padding(3, 2, 3, 2);
            txtUsedPoint.Name = "txtUsedPoint";
            txtUsedPoint.Size = new Size(121, 26);
            txtUsedPoint.TabIndex = 10;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(585, 58);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 11;
            label7.Text = "Điểm sử dụng";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.LightSkyBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(585, 16);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 9;
            label5.Text = "Mã nhân viên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmpId
            // 
            txtEmpId.BackColor = Color.WhiteSmoke;
            txtEmpId.Enabled = false;
            txtEmpId.Font = new Font("Segoe UI", 10.2F);
            txtEmpId.Location = new Point(724, 16);
            txtEmpId.Margin = new Padding(3, 2, 3, 2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(121, 26);
            txtEmpId.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSkyBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(244, 275);
            label6.Name = "label6";
            label6.Size = new Size(386, 28);
            label6.TabIndex = 11;
            label6.Text = "CHI TIẾT ĐƠN HÀNG";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Dock = DockStyle.Bottom;
            dgvOrderDetail.Enabled = false;
            dgvOrderDetail.Location = new Point(0, 306);
            dgvOrderDetail.Margin = new Padding(3, 2, 3, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(875, 219);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(849, 0);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 22);
            btnExit.TabIndex = 12;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 525);
            Controls.Add(btnExit);
            Controls.Add(dgvOrderDetail);
            Controls.Add(pnCusInfo);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrderHistory";
            pnCusInfo.ResumeLayout(false);
            pnCusInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtOrderId;
        private TextBox txtPayment;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtCreatedDate;
        private TextBox txtPhone;
        private Label label4;
        private Panel pnCusInfo;
        private Label label6;
        private DataGridView dgvOrderDetail;
        private Label label5;
        private TextBox txtEmpId;
        private TextBox txtUsedPoint;
        private Label label7;
        private TextBox txtChangeAmount;
        private Label label11;
        private TextBox txtReceivedAmount;
        private Label label8;
        private TextBox txtTotalAmount;
        private Label label9;
        private TextBox txtRawAmount;
        private Label label10;
        private Button btnExit;
    }
}