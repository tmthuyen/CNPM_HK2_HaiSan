using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Gui;
using Infrastructure;
using BUS;

namespace GUI
{
    public partial class Home : Form
    {
        private float currentVolume = 0.5f;
        private float previousVolume = 0.5f; // for unmute
        private ExpireProductBUS expBUS;
        private Employee emp;
        public Home(Employee e)
        {
            this.emp = e;
            expBUS = new ExpireProductBUS();
            InitializeComponent();
            customControl();
            // PlayBackgroundMusic();

        }

        // thay doi button dieu huong form
        private void customControl()
        {
            for (int i = 0; i < pnSideBar.Controls.Count; i++)
            {
                if (pnSideBar.Controls[i] != null && pnSideBar.Controls[i] is Button b)
                {
                    UIHelper.ApplyRoundedCorners(b, 30);
                    UIHelper.UIMouseEvent(b, new List<Color> { Color.Aqua, Color.Transparent, Color.Red });

                    //b.MouseClick += (o, e) => b.BackColor = Color.Red;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbAvatar_MouseEnter(object sender, EventArgs e)
        {

            cmstAccount.Show(ptbAvatar.PointToScreen(new Point(ptbAvatar.Location.X, ptbAvatar.Height - 2)));
        }

        private void ptbAvatar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cmstAccount_MouseEnter(object sender, EventArgs e)
        {
            cmstAccount.Show();
        }

        private void profileCmstrItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(emp);
            f.ShowDialog();
        }

        private void logoutTooltipMItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session.Username;
            btnHome_Click(sender, e);

            int numExp = expBUS.UpdateInventory();
            if (numExp > 0)
            {
                new frmError("Lô hàng", "Có " + numExp + " sản phẩm bị hết hạn").ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(home, btnHome);
        }


        // hien thi form con len panel form
        private void showForm(Form f, Button btn)
        {
            if (btn != null)
            {

                lblTitle.Text = btn.Text;
                this.pnForm.Controls.Clear();
                f.Width = pnForm.Width;
                f.Height = pnForm.Height;
                f.FormBorderStyle = FormBorderStyle.None;
                this.pnForm.Controls.Add(f);
                f.Show();
            }
        }


        private void cmstAccount_MouseLeave(object sender, EventArgs e)
        {
            cmstAccount.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnOrder);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnCustomer);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct f = new frmProduct()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnProduct);
        }
        private void btnPromotion_Click(object sender, EventArgs e)
        {
            frmVoucher f = new frmVoucher()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnPromotion);
        }





        //music lol
        private void PlayBackgroundMusic()
        {
            string path = Path.Combine(Application.StartupPath, "Images", "bg.mp3");

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(path);

            // Optional: Set volume (0.0 to 1.0)
            audioFile.Volume = 0.5f;

            // Wrap in loop stream
            var loop = new LoopStream(audioFile);
            outputDevice.Init(loop);
            outputDevice.Play();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice?.Stop();
            audioFile?.Dispose();
            outputDevice?.Dispose();
        }
        private void BtnIncreaseVol_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                currentVolume = Math.Min(1.0f, currentVolume + 0.1f);
                audioFile.Volume = currentVolume;
                volumeBar.Value = (int)(currentVolume * 100);

            }
        }
        private void BtnDecreaseVol_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                currentVolume = Math.Max(0.0f, currentVolume - 0.1f);
                audioFile.Volume = currentVolume;
                volumeBar.Value = (int)(currentVolume * 100);

            }
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            if (audioFile != null && audioFile.Volume > 0f)
            {
                previousVolume = currentVolume;
                currentVolume = 0f;
                audioFile.Volume = 0f;
                btnMute.Text = "Unmute";
                volumeBar.Value = 0;
            }
            else if (audioFile != null && currentVolume == 0f)
            {
                currentVolume = previousVolume;
                audioFile.Volume = currentVolume;
                btnMute.Text = "Mute";
                volumeBar.Value = (int)(currentVolume * 100);

            }
        }
        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                currentVolume = volumeBar.Value / 100f;
                audioFile.Volume = currentVolume;
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            frmEmployee f = new frmEmployee()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnEmp);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnReport);
        }
    }
}
