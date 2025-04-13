//namespace GUI.Usercontrol
//{
//    partial class UCVoucher
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

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            textBoxApply = new TextBox();
//            label1 = new Label();
//            label2 = new Label();
//            label3 = new Label();
//            textBoxDiscountValue = new TextBox();
//            textBoxMaxApply = new TextBox();
//            radioButtonPercent = new RadioButton();
//            radioButtonVND = new RadioButton();
//            label4 = new Label();
//            button4 = new Button();
//            button5 = new Button();
//            label5 = new Label();
//            btnEdit = new Button();
//            voucherDetails = new GroupBox();
//            voucherDetails.SuspendLayout();
//            SuspendLayout();
//            // 
//            // textBoxApply
//            // 
//            textBoxApply.Location = new Point(153, 14);
//            textBoxApply.Name = "textBoxApply";
//            textBoxApply.Size = new Size(100, 23);
//            textBoxApply.TabIndex = 0;
//            textBoxApply.TextChanged += processInputNumber;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Location = new Point(33, 17);
//            label1.Name = "label1";
//            label1.Size = new Size(114, 15);
//            label1.TabIndex = 1;
//            label1.Text = "Áp dụng cho đơn từ";
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Location = new Point(112, 52);
//            label2.Name = "label2";
//            label2.Size = new Size(35, 15);
//            label2.TabIndex = 2;
//            label2.Text = "Giảm";
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Location = new Point(44, 87);
//            label3.Name = "label3";
//            label3.Size = new Size(103, 15);
//            label3.TabIndex = 3;
//            label3.Text = "Khuyến mãi tối đa";
//            // 
//            // textBoxDiscountValue
//            // 
//            textBoxDiscountValue.Location = new Point(153, 49);
//            textBoxDiscountValue.Name = "textBoxDiscountValue";
//            textBoxDiscountValue.Size = new Size(100, 23);
//            textBoxDiscountValue.TabIndex = 5;
//            // 
//            // textBoxMaxApply
//            // 
//            textBoxMaxApply.Location = new Point(153, 84);
//            textBoxMaxApply.Name = "textBoxMaxApply";
//            textBoxMaxApply.Size = new Size(100, 23);
//            textBoxMaxApply.TabIndex = 6;
//            // 
//            // radioButtonPercent
//            // 
//            radioButtonPercent.AutoSize = true;
//            radioButtonPercent.Location = new Point(270, 50);
//            radioButtonPercent.Name = "radioButtonPercent";
//            radioButtonPercent.Size = new Size(35, 19);
//            radioButtonPercent.TabIndex = 7;
//            radioButtonPercent.TabStop = true;
//            radioButtonPercent.Text = "%";
//            radioButtonPercent.UseVisualStyleBackColor = true;
//            // 
//            // radioButtonVND
//            // 
//            radioButtonVND.AutoSize = true;
//            radioButtonVND.Location = new Point(311, 50);
//            radioButtonVND.Name = "radioButtonVND";
//            radioButtonVND.Size = new Size(49, 19);
//            radioButtonVND.TabIndex = 8;
//            radioButtonVND.TabStop = true;
//            radioButtonVND.Text = "VND";
//            radioButtonVND.UseVisualStyleBackColor = true;
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Location = new Point(270, 87);
//            label4.Name = "label4";
//            label4.Size = new Size(31, 15);
//            label4.TabIndex = 9;
//            label4.Text = "VND";
//            // 
//            // button4
//            // 
//            button4.Location = new Point(374, 151);
//            button4.Name = "button4";
//            button4.Size = new Size(75, 23);
//            button4.TabIndex = 13;
//            button4.Text = "Hủy";
//            button4.UseVisualStyleBackColor = true;
//            button4.Click += btnCancelClick;
//            // 
//            // button5
//            // 
//            button5.Location = new Point(477, 151);
//            button5.Name = "button5";
//            button5.Size = new Size(75, 23);
//            button5.TabIndex = 14;
//            button5.Text = "Lưu";
//            button5.UseVisualStyleBackColor = true;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Location = new Point(270, 17);
//            label5.Name = "label5";
//            label5.Size = new Size(31, 15);
//            label5.TabIndex = 15;
//            label5.Text = "VND";
//            // 
//            // btnEdit
//            // 
//            btnEdit.Location = new Point(279, 151);
//            btnEdit.Name = "btnEdit";
//            btnEdit.Size = new Size(75, 23);
//            btnEdit.TabIndex = 16;
//            btnEdit.Text = "Sửa";
//            btnEdit.UseVisualStyleBackColor = true;
//            btnEdit.Click += btnEdit_Click;
//            // 
//            // voucherDetails
//            // 
//            voucherDetails.Controls.Add(label5);
//            voucherDetails.Controls.Add(label4);
//            voucherDetails.Controls.Add(radioButtonVND);
//            voucherDetails.Controls.Add(radioButtonPercent);
//            voucherDetails.Controls.Add(textBoxMaxApply);
//            voucherDetails.Controls.Add(textBoxDiscountValue);
//            voucherDetails.Controls.Add(label3);
//            voucherDetails.Controls.Add(label2);
//            voucherDetails.Controls.Add(label1);
//            voucherDetails.Controls.Add(textBoxApply);
//            voucherDetails.Location = new Point(207, 10);
//            voucherDetails.Name = "voucherDetails";
//            voucherDetails.Size = new Size(422, 123);
//            voucherDetails.TabIndex = 17;
//            voucherDetails.TabStop = false;
//            voucherDetails.Text = "Voucher Details";
//            // 
//            // UCVoucher
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            Controls.Add(voucherDetails);
//            Controls.Add(btnEdit);
//            Controls.Add(button5);
//            Controls.Add(button4);
//            Name = "UCVoucher";
//            Size = new Size(808, 290);
//            voucherDetails.ResumeLayout(false);
//            voucherDetails.PerformLayout();
//            ResumeLayout(false);
//        }

//        #endregion

//        private TextBox textBoxApply;
//        private Label label1;
//        private Label label2;
//        private Label label3;
//        private TextBox textBoxDiscountValue;
//        private TextBox textBoxMaxApply;
//        private RadioButton radioButtonPercent;
//        private RadioButton radioButtonVND;
//        private Label label4;
//        private Button button4;
//        private Button button5;
//        private Label label5;
//        private Button btnEdit;
//        private GroupBox voucherDetails;
//    }
//}
