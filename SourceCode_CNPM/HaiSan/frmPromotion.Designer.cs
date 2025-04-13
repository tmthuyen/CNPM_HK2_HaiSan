//namespace GUI
//{
//    partial class frmPromotion
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            addBtn = new Button();
//            EditBtn = new Button();
//            label2 = new Label();
//            label3 = new Label();
//            txtBoxPromotionName = new TextBox();
//            comboBoxType = new ComboBox();
//            dataGridView1 = new DataGridView();
//            panel1 = new Panel();
//            button1 = new Button();
//            label4 = new Label();
//            dateTimePickerExpire = new DateTimePicker();
//            txtBoxUsePoint = new TextBox();
//            label5 = new Label();
//            dateTimePickerDailyStart = new DateTimePicker();
//            dateTimePickerDailyEnd = new DateTimePicker();
//            label6 = new Label();
//            txtBoxID = new TextBox();
//            label7 = new Label();
//            button2 = new Button();
//            groupBoxPrm = new GroupBox();
//            checkBox1 = new CheckBox();
//            btnSave = new Button();
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
//            groupBoxPrm.SuspendLayout();
//            SuspendLayout();
//            // 
//            // addBtn
//            // 
//            addBtn.Location = new Point(12, 72);
//            addBtn.Name = "addBtn";
//            addBtn.Size = new Size(75, 23);
//            addBtn.TabIndex = 0;
//            addBtn.Text = "Thêm";
//            addBtn.UseVisualStyleBackColor = true;
//            addBtn.Click += addBtn_Click;
//            // 
//            // EditBtn
//            // 
//            EditBtn.Enabled = false;
//            EditBtn.Location = new Point(108, 72);
//            EditBtn.Name = "EditBtn";
//            EditBtn.Size = new Size(75, 23);
//            EditBtn.TabIndex = 1;
//            EditBtn.Text = "Sửa";
//            EditBtn.UseVisualStyleBackColor = true;
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Location = new Point(6, 18);
//            label2.Name = "label2";
//            label2.Size = new Size(90, 15);
//            label2.TabIndex = 3;
//            label2.Text = "Tên khuyến mãi";
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Location = new Point(343, 18);
//            label3.Name = "label3";
//            label3.Size = new Size(29, 15);
//            label3.TabIndex = 4;
//            label3.Text = "Loại";
//            // 
//            // txtBoxPromotionName
//            // 
//            txtBoxPromotionName.Location = new Point(102, 15);
//            txtBoxPromotionName.Name = "txtBoxPromotionName";
//            txtBoxPromotionName.Size = new Size(235, 23);
//            txtBoxPromotionName.TabIndex = 6;
//            // 
//            // comboBoxType
//            // 
//            comboBoxType.FormattingEnabled = true;
//            comboBoxType.Items.AddRange(new object[] { "Giảm giá", "Combo", "Voucher toàn đơn", "Combo cho loại sản phẩm", "Mua n tặng n" });
//            comboBoxType.Location = new Point(398, 15);
//            comboBoxType.Name = "comboBoxType";
//            comboBoxType.Size = new Size(178, 23);
//            comboBoxType.TabIndex = 7;
//            comboBoxType.SelectedIndexChanged += changeType;
//            // 
//            // dataGridView1
//            // 
//            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridView1.Location = new Point(12, 99);
//            dataGridView1.Name = "dataGridView1";
//            dataGridView1.Size = new Size(776, 102);
//            dataGridView1.TabIndex = 8;
//            dataGridView1.RowEnter += dataGridView1_RowEnter;
//            // 
//            // panel1
//            // 
//            panel1.Dock = DockStyle.Bottom;
//            panel1.Location = new Point(0, 207);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(800, 243);
//            panel1.TabIndex = 9;
//            panel1.Visible = false;
//            // 
//            // button1
//            // 
//            button1.Location = new Point(211, 72);
//            button1.Name = "button1";
//            button1.Size = new Size(113, 23);
//            button1.TabIndex = 10;
//            button1.Text = "Xem Khuyến Mãi";
//            button1.UseVisualStyleBackColor = true;
//            button1.Click += button1_Click;
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Location = new Point(343, 47);
//            label4.Name = "label4";
//            label4.Size = new Size(78, 15);
//            label4.TabIndex = 13;
//            label4.Text = "Ngày hết hạn";
//            // 
//            // dateTimePickerExpire
//            // 
//            dateTimePickerExpire.Format = DateTimePickerFormat.Short;
//            dateTimePickerExpire.Location = new Point(445, 44);
//            dateTimePickerExpire.Name = "dateTimePickerExpire";
//            dateTimePickerExpire.Size = new Size(131, 23);
//            dateTimePickerExpire.TabIndex = 14;
//            // 
//            // txtBoxUsePoint
//            // 
//            txtBoxUsePoint.Location = new Point(680, 44);
//            txtBoxUsePoint.Name = "txtBoxUsePoint";
//            txtBoxUsePoint.Size = new Size(102, 23);
//            txtBoxUsePoint.TabIndex = 16;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Location = new Point(582, 47);
//            label5.Name = "label5";
//            label5.Size = new Size(92, 15);
//            label5.TabIndex = 15;
//            label5.Text = "Điểm phải dùng";
//            // 
//            // dateTimePickerDailyStart
//            // 
//            dateTimePickerDailyStart.Format = DateTimePickerFormat.Time;
//            dateTimePickerDailyStart.Location = new Point(102, 41);
//            dateTimePickerDailyStart.Name = "dateTimePickerDailyStart";
//            dateTimePickerDailyStart.Size = new Size(101, 23);
//            dateTimePickerDailyStart.TabIndex = 17;
//            // 
//            // dateTimePickerDailyEnd
//            // 
//            dateTimePickerDailyEnd.Format = DateTimePickerFormat.Time;
//            dateTimePickerDailyEnd.Location = new Point(227, 41);
//            dateTimePickerDailyEnd.Name = "dateTimePickerDailyEnd";
//            dateTimePickerDailyEnd.Size = new Size(110, 23);
//            dateTimePickerDailyEnd.TabIndex = 18;
//            // 
//            // label6
//            // 
//            label6.AutoSize = true;
//            label6.Location = new Point(209, 44);
//            label6.Name = "label6";
//            label6.Size = new Size(12, 15);
//            label6.TabIndex = 19;
//            label6.Text = "-";
//            // 
//            // txtBoxID
//            // 
//            txtBoxID.Enabled = false;
//            txtBoxID.Location = new Point(617, 15);
//            txtBoxID.Name = "txtBoxID";
//            txtBoxID.Size = new Size(165, 23);
//            txtBoxID.TabIndex = 21;
//            // 
//            // label7
//            // 
//            label7.AutoSize = true;
//            label7.Location = new Point(582, 18);
//            label7.Name = "label7";
//            label7.Size = new Size(18, 15);
//            label7.TabIndex = 20;
//            label7.Text = "ID";
//            // 
//            // button2
//            // 
//            button2.Location = new Point(349, 72);
//            button2.Name = "button2";
//            button2.Size = new Size(75, 23);
//            button2.TabIndex = 22;
//            button2.Text = "Hủy";
//            button2.UseVisualStyleBackColor = true;
//            button2.Click += button2_Click;
//            // 
//            // groupBoxPrm
//            // 
//            groupBoxPrm.Controls.Add(checkBox1);
//            groupBoxPrm.Controls.Add(txtBoxID);
//            groupBoxPrm.Controls.Add(label7);
//            groupBoxPrm.Controls.Add(label6);
//            groupBoxPrm.Controls.Add(dateTimePickerDailyEnd);
//            groupBoxPrm.Controls.Add(dateTimePickerDailyStart);
//            groupBoxPrm.Controls.Add(txtBoxUsePoint);
//            groupBoxPrm.Controls.Add(label5);
//            groupBoxPrm.Controls.Add(dateTimePickerExpire);
//            groupBoxPrm.Controls.Add(label4);
//            groupBoxPrm.Controls.Add(comboBoxType);
//            groupBoxPrm.Controls.Add(txtBoxPromotionName);
//            groupBoxPrm.Controls.Add(label3);
//            groupBoxPrm.Controls.Add(label2);
//            groupBoxPrm.Location = new Point(6, -1);
//            groupBoxPrm.Name = "groupBoxPrm";
//            groupBoxPrm.Size = new Size(791, 70);
//            groupBoxPrm.TabIndex = 23;
//            groupBoxPrm.TabStop = false;
//            groupBoxPrm.Text = "Chi tiết khuyến mãi";
//            // 
//            // checkBox1
//            // 
//            checkBox1.AutoSize = true;
//            checkBox1.Location = new Point(6, 43);
//            checkBox1.Name = "checkBox1";
//            checkBox1.Size = new Size(75, 19);
//            checkBox1.TabIndex = 25;
//            checkBox1.Text = "Thời gian";
//            checkBox1.UseVisualStyleBackColor = true;
//            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
//            // 
//            // btnSave
//            // 
//            btnSave.Location = new Point(451, 72);
//            btnSave.Name = "btnSave";
//            btnSave.Size = new Size(75, 23);
//            btnSave.TabIndex = 24;
//            btnSave.Text = "Lưu";
//            btnSave.UseVisualStyleBackColor = true;
//            // 
//            // frmPromotion
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Controls.Add(btnSave);
//            Controls.Add(groupBoxPrm);
//            Controls.Add(button2);
//            Controls.Add(button1);
//            Controls.Add(panel1);
//            Controls.Add(dataGridView1);
//            Controls.Add(EditBtn);
//            Controls.Add(addBtn);
//            Name = "frmPromotion";
//            Text = "Form1";
//            Load += Form1_Load;
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
//            groupBoxPrm.ResumeLayout(false);
//            groupBoxPrm.PerformLayout();
//            ResumeLayout(false);
//        }

//        #endregion

//        private Button addBtn;
//        private Button EditBtn;
//        private Label label2;
//        private Label label3;
//        private TextBox txtBoxPromotionName;
//        private ComboBox comboBoxType;
//        private DataGridView dataGridView1;
//        private Panel panel1;
//        private Button button1;
//        private Label label4;
//        private DateTimePicker dateTimePickerExpire;
//        private TextBox txtBoxUsePoint;
//        private Label label5;
//        private DateTimePicker dateTimePickerDailyStart;
//        private DateTimePicker dateTimePickerDailyEnd;
//        private Label label6;
//        private TextBox txtBoxID;
//        private Label label7;
//        private Button button2;
//        private GroupBox groupBoxPrm;
//        private Button btnSave;
//        private CheckBox checkBox1;
//    }
//}