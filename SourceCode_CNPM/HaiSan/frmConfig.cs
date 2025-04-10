﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxServer.Enabled)
            {
                textBoxUsername.Enabled = false;
                textBoxUsername.Clear();

                textBoxPass.Enabled = false;
                textBoxPass.Clear();
            }
            else
            {
                textBoxUsername.Enabled = true;
                textBoxPass.Enabled = true;
            }

        }
        private Boolean validate()
        {
            if (checkBox1.Checked)
            {
                return !(textBoxDB.Text.IsNullOrEmpty() || textBoxServer.Text.IsNullOrEmpty());
            }
            else
            {
                return !(textBoxDB.Text.IsNullOrEmpty() || textBoxServer.Text.IsNullOrEmpty() || textBoxUsername.Text.IsNullOrEmpty() || textBoxPass.Text.IsNullOrEmpty());
            }
        }
        private void enterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save(sender, e);
            }
        }

        private void writeToFile()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
                string[] lines = {
                        checkBox1.Checked?"windows":"server",                  // "server" hay "windows")
                        textBoxServer.Text,  // Server name
                        textBoxDB.Text,             // Database name
                        textBoxUsername.Text,               // Username
                        textBoxPass.Text                // Password
                    };

                // ... same as before
                File.WriteAllText(path, string.Join(Environment.NewLine, lines));
                this.DialogResult = DialogResult.OK; // success
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing config: " + ex.Message);
            }
        }

        
        private void save(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                writeToFile();
            }
        }
        private void cancelEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cancel(sender, e);
            }
        }
        private void cancel(object sender, EventArgs e)
        {
            textBoxServer.Clear();
            textBoxDB.Clear();
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxServer.Focus();
        }

    }
}
