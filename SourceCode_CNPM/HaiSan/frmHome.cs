using BUS;
using DTO;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHome : Form
    {
        private OrderBUS orderBUS;
        private ImportBUS importBUS;
        public frmHome()
        {
            orderBUS = new OrderBUS();
            importBUS = new ImportBUS();
            InitializeComponent();
        }

        // load top sp
        private void LoadTopPro(DataGridView dgv, DataTable dt)
        {
            if(dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;

                dgv.Columns["ProductID"].HeaderText = "Mã";
                //dgv.Columns["SupplierId"].HeaderText = "Mã NCC";
                dgv.Columns["CategoryId"].HeaderText = "Mã loại";
                dgv.Columns["ProductName"].HeaderText = "Tên";
                dgv.Columns["RetailPrice"].HeaderText = "Giá bán";
                dgv.Columns["CreatedAt"].HeaderText = "Ngày tạo";
                //dgv.Columns["TotalSold"].HeaderText = "Tổng đã bán";
            }
        }

        // load top sp
        private void LoadProNearExprire(DataGridView dgv, DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;

                dgv.Columns["ProductID"].HeaderText = "Mã"; 
                dgv.Columns["ProductName"].HeaderText = "Tên";
                dgv.Columns["RetailPrice"].HeaderText = "Giá bán"; 
            }
        }

        private void createPanels(Panel pParent, List<Product> l)
        {
            //int numChild = 4;
            ////int numChild = l.Count;

            //pParent.Controls.Clear();
            //pParent.Size = new Size(900, 220);
            //pParent.SuspendLayout();

            //int childWidth = 200;
            //int childHeight = pParent.Height;

            //int space = (pParent.Width - childWidth * numChild) / (numChild - 1);

            //int xParent = pParent.Location.X;

            //int yParent = pParent.Location.Y;

            // Tạo 4 FlowLayoutPanel con
            //for (int i = 1; i <= 4; i++)
            //{
            //    FlowLayoutPanel panelCon = new FlowLayoutPanel
            //    {
            //        Name = "pnProduct" + i,
            //        Size = new Size(childWidth,  childHeight),
            //        BackColor = Color.Red,
            //        BorderStyle = BorderStyle.FixedSingle,
            //        Location = new Point(space * (i-1) + childWidth * (i - 1), 0)
            //    }; 

            //    PictureBox picBox = new PictureBox
            //    {
            //        Name = "picBox" + i,
            //        Size = new Size(childWidth, 180), // Giới hạn kích thước ảnh
            //        SizeMode = PictureBoxSizeMode.StretchImage, // Co dãn hình ảnh vừa với khung
            //        BorderStyle = BorderStyle.None,
            //        Margin = new Padding(0, 0, 0, 0),
            //        Location = new Point(0, 0)

            //    };

            //    if (AppDomain.CurrentDomain != null)
            //    {
            //        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\cuaImg.jpg");

            //        picBox.Image = Image.FromFile(imagePath);
            //    }

            //    // Tạo Label
            //    Label lblName = new Label
            //    {
            //        Text = "Cua hoang de\n" + "Gia: 200.000dd",
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        Size = new Size(childWidth, 40),
            //        Dock = DockStyle.Bottom,
            //        BackColor= Color.Blue,
            //        Margin = new Padding(0, 0, 0, 0)
            //        //AutoSize = true
            //    };

            //    // Thêm PictureBox và Label vào panel con
            //    picBox.Dock = DockStyle.Top;
            //    panelCon.Controls.Add(picBox);
            //    panelCon.Controls.Add(lblName);

            //    UIHelper.ApplyRoundedCorners(panelCon, 20);

            //    pParent.Controls.Add(panelCon); // Thêm vào Panel cha\

            //}


        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // danh sách ban chay thang này
            DateTime now = DateTime.Now;
            DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
            DateTime startOfNextMonth = startOfMonth.AddMonths(1);

            LoadTopPro(dgvTopProduct, orderBUS.GetTopProductWithInfo(startOfMonth, startOfNextMonth, 10));

            if (Session.Role.Trim().Equals("admin"))
            {
                LoadProNearExprire(dgvNearExpire, importBUS.GetProductNearExpire());
            }
            else
            {
                lblSpSapHet.Text = "Admin mới xem thông tin này";
            }
        }
    }
}
