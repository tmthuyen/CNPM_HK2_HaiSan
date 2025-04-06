namespace GUI.Usercontrol
{
    partial class UCDiscount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBoxProductName = new ComboBox();
            groupBoxItem = new GroupBox();
            button8 = new Button();
            textBoxCategory = new TextBox();
            textBoxPrice = new TextBox();
            label7 = new Label();
            button7 = new Button();
            button6 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox3 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBoxAddCat = new ComboBox();
            label2 = new Label();
            button3 = new Button();
            overlayPanel = new Panel();
            button11 = new Button();
            button10 = new Button();
            textBoxSearchName = new TextBox();
            label12 = new Label();
            textBoxPriceEnd = new TextBox();
            label11 = new Label();
            textBoxPriceBegin = new TextBox();
            label9 = new Label();
            button9 = new Button();
            comboBoxFilterCateogry = new ComboBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            comboBoxDelCat = new ComboBox();
            label5 = new Label();
            button5 = new Button();
            textBox2 = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxItem.SuspendLayout();
            groupBox1.SuspendLayout();
            overlayPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(808, 177);
            dataGridView1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 15;
            label10.Text = "Tên";
            // 
            // button2
            // 
            button2.Location = new Point(80, 89);
            button2.Name = "button2";
            button2.Size = new Size(70, 23);
            button2.TabIndex = 19;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 89);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 18;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Location = new Point(40, 17);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(249, 23);
            comboBoxProductName.TabIndex = 17;
            comboBoxProductName.SelectedIndexChanged += comboBoxProductName_SelectedIndexChanged;
            // 
            // groupBoxItem
            // 
            groupBoxItem.Controls.Add(button8);
            groupBoxItem.Controls.Add(textBoxCategory);
            groupBoxItem.Controls.Add(textBoxPrice);
            groupBoxItem.Controls.Add(label7);
            groupBoxItem.Controls.Add(button7);
            groupBoxItem.Controls.Add(button6);
            groupBoxItem.Controls.Add(radioButton3);
            groupBoxItem.Controls.Add(radioButton4);
            groupBoxItem.Controls.Add(textBox3);
            groupBoxItem.Controls.Add(label6);
            groupBoxItem.Controls.Add(button4);
            groupBoxItem.Controls.Add(comboBoxProductName);
            groupBoxItem.Controls.Add(label1);
            groupBoxItem.Controls.Add(label10);
            groupBoxItem.Controls.Add(button1);
            groupBoxItem.Controls.Add(button2);
            groupBoxItem.Location = new Point(3, 0);
            groupBoxItem.Name = "groupBoxItem";
            groupBoxItem.Size = new Size(397, 112);
            groupBoxItem.TabIndex = 20;
            groupBoxItem.TabStop = false;
            groupBoxItem.Text = "Thêm sản phẩm";
            // 
            // button8
            // 
            button8.Location = new Point(123, 50);
            button8.Name = "button8";
            button8.Size = new Size(35, 23);
            button8.TabIndex = 36;
            button8.Text = "Lọc";
            toolTip1.SetToolTip(button8, "Lọc các lựa chọn xuất hiện ở thanh \"tên\" trên");
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonShowOverlay_Click;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Enabled = false;
            textBoxCategory.Location = new Point(41, 50);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(76, 23);
            textBoxCategory.TabIndex = 35;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Enabled = false;
            textBoxPrice.Location = new Point(313, 16);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(80, 23);
            textBoxPrice.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.Location = new Point(289, 19);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 33;
            label7.Text = "Giá";
            // 
            // button7
            // 
            button7.Location = new Point(235, 89);
            button7.Name = "button7";
            button7.Size = new Size(70, 23);
            button7.TabIndex = 32;
            button7.Text = "Hủy";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(311, 89);
            button6.Name = "button6";
            button6.Size = new Size(70, 23);
            button6.TabIndex = 31;
            button6.Text = "Lưu";
            button6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(330, 51);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "VND";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(295, 51);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(35, 19);
            radioButton4.TabIndex = 29;
            radioButton4.TabStop = true;
            radioButton4.Text = "%";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Location = new Point(164, 54);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 27;
            label6.Text = "Giảm";
            // 
            // button4
            // 
            button4.Location = new Point(158, 89);
            button4.Name = "button4";
            button4.Size = new Size(70, 23);
            button4.TabIndex = 19;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 20;
            label1.Text = "Loại";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxAddCat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(405, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 112);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm nhóm";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(161, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "VND";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(126, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(35, 19);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "%";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 23);
            textBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Location = new Point(1, 55);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 22;
            label3.Text = "Giảm";
            // 
            // comboBoxAddCat
            // 
            comboBoxAddCat.FormattingEnabled = true;
            comboBoxAddCat.Location = new Point(36, 22);
            comboBoxAddCat.Name = "comboBoxAddCat";
            comboBoxAddCat.Size = new Size(174, 23);
            comboBoxAddCat.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Location = new Point(1, 25);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 20;
            label2.Text = "Loại";
            // 
            // button3
            // 
            button3.Location = new Point(6, 89);
            button3.Name = "button3";
            button3.Size = new Size(204, 23);
            button3.TabIndex = 18;
            button3.Text = "Thêm vào đơn";
            button3.UseVisualStyleBackColor = true;
            // 
            // overlayPanel
            // 
            overlayPanel.Controls.Add(button11);
            overlayPanel.Controls.Add(button10);
            overlayPanel.Controls.Add(textBoxSearchName);
            overlayPanel.Controls.Add(label12);
            overlayPanel.Controls.Add(textBoxPriceEnd);
            overlayPanel.Controls.Add(label11);
            overlayPanel.Controls.Add(textBoxPriceBegin);
            overlayPanel.Controls.Add(label9);
            overlayPanel.Controls.Add(button9);
            overlayPanel.Controls.Add(comboBoxFilterCateogry);
            overlayPanel.Controls.Add(label8);
            overlayPanel.Location = new Point(406, 142);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new Size(215, 132);
            overlayPanel.TabIndex = 23;
            // 
            // button11
            // 
            button11.Location = new Point(109, 94);
            button11.Name = "button11";
            button11.Size = new Size(101, 23);
            button11.TabIndex = 42;
            button11.Text = "Hủy";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(7, 94);
            button10.Name = "button10";
            button10.Size = new Size(96, 23);
            button10.TabIndex = 41;
            button10.Text = "Lọc";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBoxSearchName
            // 
            textBoxSearchName.Location = new Point(40, 65);
            textBoxSearchName.Name = "textBoxSearchName";
            textBoxSearchName.Size = new Size(170, 23);
            textBoxSearchName.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoEllipsis = true;
            label12.AutoSize = true;
            label12.Location = new Point(7, 68);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 39;
            label12.Text = "Tên";
            // 
            // textBoxPriceEnd
            // 
            textBoxPriceEnd.Location = new Point(135, 34);
            textBoxPriceEnd.Name = "textBoxPriceEnd";
            textBoxPriceEnd.Size = new Size(75, 23);
            textBoxPriceEnd.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.Location = new Point(120, 37);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 37;
            label11.Text = "-";
            // 
            // textBoxPriceBegin
            // 
            textBoxPriceBegin.Location = new Point(40, 34);
            textBoxPriceBegin.Name = "textBoxPriceBegin";
            textBoxPriceBegin.Size = new Size(75, 23);
            textBoxPriceBegin.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            label9.AutoSize = true;
            label9.Location = new Point(7, 37);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 35;
            label9.Text = "Giá";
            // 
            // button9
            // 
            button9.Location = new Point(189, 3);
            button9.Name = "button9";
            button9.Size = new Size(23, 23);
            button9.TabIndex = 20;
            button9.Text = "x";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // comboBoxFilterCateogry
            // 
            comboBoxFilterCateogry.FormattingEnabled = true;
            comboBoxFilterCateogry.Location = new Point(40, 5);
            comboBoxFilterCateogry.Name = "comboBoxFilterCateogry";
            comboBoxFilterCateogry.Size = new Size(143, 23);
            comboBoxFilterCateogry.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.Location = new Point(7, 7);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 18;
            label8.Text = "Loại";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxDelCat);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(627, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 112);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xóa nhóm";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 23;
            label4.Text = "Số sản phẩm";
            // 
            // comboBoxDelCat
            // 
            comboBoxDelCat.FormattingEnabled = true;
            comboBoxDelCat.Location = new Point(47, 22);
            comboBoxDelCat.Name = "comboBoxDelCat";
            comboBoxDelCat.Size = new Size(122, 23);
            comboBoxDelCat.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Location = new Point(12, 25);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 20;
            label5.Text = "Loại";
            // 
            // button5
            // 
            button5.Location = new Point(12, 89);
            button5.Name = "button5";
            button5.Size = new Size(157, 23);
            button5.TabIndex = 18;
            button5.Text = "Xóa nhóm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(89, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 23);
            textBox2.TabIndex = 25;
            // 
            // UCDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(overlayPanel);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxItem);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Name = "UCDiscount";
            Size = new Size(808, 337);
            Load += UCDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxItem.ResumeLayout(false);
            groupBoxItem.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            overlayPanel.ResumeLayout(false);
            overlayPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label10;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxProductName;
        private GroupBox groupBoxItem;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBoxAddCat;
        private Label label2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private ComboBox comboBoxDelCat;
        private Label label5;
        private Button button5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Button button6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Button button7;
        private TextBox textBoxPrice;
        private Label label7;
        private TextBox textBoxCategory;
        private Button button8;
        private Panel overlayPanel;
        private ComboBox comboBoxFilterCateogry;
        private Label label8;
        private Button button9;
        private Button button10;
        private TextBox textBoxSearchName;
        private Label label12;
        private TextBox textBoxPriceEnd;
        private Label label11;
        private TextBox textBoxPriceBegin;
        private Label label9;
        private Button button11;
        private ToolTip toolTip1;
    }
}
