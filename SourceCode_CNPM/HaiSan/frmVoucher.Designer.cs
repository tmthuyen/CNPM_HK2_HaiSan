namespace GUI
{
    partial class frmVoucher
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
            voucherDetails = new GroupBox();
            label8 = new Label();
            dateTimePickerTo = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            radioButtonVND = new RadioButton();
            radioButtonPercent = new RadioButton();
            textBoxMaxApply = new TextBox();
            textBoxDiscountValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxApply = new TextBox();
            btnEdit = new Button();
            btnSave = new Button();
            button4 = new Button();
            dataGridViewVoucher = new DataGridView();
            btnAdd = new Button();
            toolTip1 = new ToolTip(components);
            btnDeactivate = new Button();
            toolTip2 = new ToolTip(components);
            btnActivate = new Button();
            voucherDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoucher).BeginInit();
            SuspendLayout();
            // 
            // voucherDetails
            // 
            voucherDetails.Controls.Add(label8);
            voucherDetails.Controls.Add(dateTimePickerTo);
            voucherDetails.Controls.Add(label7);
            voucherDetails.Controls.Add(label6);
            voucherDetails.Controls.Add(dateTimePickerFrom);
            voucherDetails.Controls.Add(textBoxName);
            voucherDetails.Controls.Add(label5);
            voucherDetails.Controls.Add(label4);
            voucherDetails.Controls.Add(radioButtonVND);
            voucherDetails.Controls.Add(radioButtonPercent);
            voucherDetails.Controls.Add(textBoxMaxApply);
            voucherDetails.Controls.Add(textBoxDiscountValue);
            voucherDetails.Controls.Add(label3);
            voucherDetails.Controls.Add(label2);
            voucherDetails.Controls.Add(label1);
            voucherDetails.Controls.Add(textBoxApply);
            voucherDetails.Location = new Point(12, 12);
            voucherDetails.Name = "voucherDetails";
            voucherDetails.Size = new Size(776, 119);
            voucherDetails.TabIndex = 21;
            voucherDetails.TabStop = false;
            voucherDetails.Text = "Voucher Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 88);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 21;
            label8.Text = "Áp dụng đến";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(500, 82);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(243, 23);
            dateTimePickerTo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 91);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Áp dụng từ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 22);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 18;
            label6.Text = "Tên Voucher";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(88, 85);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(243, 23);
            dateTimePickerFrom.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(243, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(712, 21);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 15;
            label5.Text = "VND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(712, 54);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "VND";
            // 
            // radioButtonVND
            // 
            radioButtonVND.AutoSize = true;
            radioButtonVND.Location = new Point(282, 54);
            radioButtonVND.Name = "radioButtonVND";
            radioButtonVND.Size = new Size(49, 19);
            radioButtonVND.TabIndex = 4;
            radioButtonVND.TabStop = true;
            radioButtonVND.Text = "VND";
            radioButtonVND.UseVisualStyleBackColor = true;
            // 
            // radioButtonPercent
            // 
            radioButtonPercent.AutoSize = true;
            radioButtonPercent.Location = new Point(241, 54);
            radioButtonPercent.Name = "radioButtonPercent";
            radioButtonPercent.Size = new Size(35, 19);
            radioButtonPercent.TabIndex = 3;
            radioButtonPercent.TabStop = true;
            radioButtonPercent.Text = "%";
            radioButtonPercent.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxApply
            // 
            textBoxMaxApply.Location = new Point(500, 51);
            textBoxMaxApply.Name = "textBoxMaxApply";
            textBoxMaxApply.Size = new Size(206, 23);
            textBoxMaxApply.TabIndex = 5;
            textBoxMaxApply.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(textBoxMaxApply, "Chỉ nhập số, không nhập % hay chữ");
            textBoxMaxApply.TextChanged += processInputNumber;
            textBoxMaxApply.KeyPress += processNumber_KeyPress;
            // 
            // textBoxDiscountValue
            // 
            textBoxDiscountValue.AcceptsReturn = true;
            textBoxDiscountValue.Location = new Point(88, 53);
            textBoxDiscountValue.Name = "textBoxDiscountValue";
            textBoxDiscountValue.Size = new Size(147, 23);
            textBoxDiscountValue.TabIndex = 2;
            textBoxDiscountValue.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(textBoxDiscountValue, "Chỉ nhập số, không nhập % hay chữ");
            textBoxDiscountValue.TextChanged += textBoxDiscountValue_TextChanged;
            textBoxDiscountValue.KeyPress += processNumber_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 55);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Giảm tối đa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 56);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Giảm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 21);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Áp dụng cho đơn từ";
            // 
            // textBoxApply
            // 
            textBoxApply.Location = new Point(500, 18);
            textBoxApply.Name = "textBoxApply";
            textBoxApply.Size = new Size(206, 23);
            textBoxApply.TabIndex = 1;
            textBoxApply.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(textBoxApply, "Chỉ nhập số, không nhập % hay chữ");
            textBoxApply.TextChanged += processInputNumber;
            textBoxApply.KeyPress += processNumber_KeyPress;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(449, 137);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            toolTip1.SetToolTip(btnEdit, "Các voucher đã ra mắt sẽ bị vô hiệu hóa nếu còn hạn sử dụng và thêm 1 voucher mới.\r\nCác voucher chưa ra  mắt sẽ được thay đổi.");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(680, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSaveClick;
            // 
            // button4
            // 
            button4.Location = new Point(567, 137);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnCancelClick;
            // 
            // dataGridViewVoucher
            // 
            dataGridViewVoucher.AllowUserToAddRows = false;
            dataGridViewVoucher.AllowUserToDeleteRows = false;
            dataGridViewVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridViewVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoucher.Location = new Point(12, 182);
            dataGridViewVoucher.Name = "dataGridViewVoucher";
            dataGridViewVoucher.ReadOnly = true;
            dataGridViewVoucher.Size = new Size(776, 256);
            dataGridViewVoucher.TabIndex = 22;
            dataGridViewVoucher.RowEnter += dataGridViewVoucher_RowEnter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(100, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Enabled = false;
            btnDeactivate.Location = new Point(227, 137);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(71, 23);
            btnDeactivate.TabIndex = 9;
            btnDeactivate.Text = "Thu hồi";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnActivate
            // 
            btnActivate.Enabled = false;
            btnActivate.Location = new Point(342, 137);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(66, 23);
            btnActivate.TabIndex = 23;
            btnActivate.Text = "Ra mắt";
            btnActivate.UseVisualStyleBackColor = true;
            btnActivate.Click += btnActivate_Click;
            // 
            // frmVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActivate);
            Controls.Add(btnDeactivate);
            Controls.Add(btnAdd);
            Controls.Add(voucherDetails);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(button4);
            Controls.Add(dataGridViewVoucher);
            Name = "frmVoucher";
            Text = "frmVoucher";
            voucherDetails.ResumeLayout(false);
            voucherDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoucher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox voucherDetails;
        private Label label5;
        private Label label4;
        private RadioButton radioButtonVND;
        private RadioButton radioButtonPercent;
        private TextBox textBoxMaxApply;
        private TextBox textBoxDiscountValue;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxApply;
        private Button btnEdit;
        private Button btnSave;
        private Button button4;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxName;
        private Label label8;
        private DateTimePicker dateTimePickerTo;
        private DataGridView dataGridViewVoucher;
        private Button btnAdd;
        private ToolTip toolTip1;
        private Button btnDeactivate;
        private ToolTip toolTip2;
        private Button btnActivate;

    }
}