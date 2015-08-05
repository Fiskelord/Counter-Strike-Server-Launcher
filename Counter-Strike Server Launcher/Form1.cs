using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Strike_Server_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "SteamCMD";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSteamCMDdir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCSGOdirSearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtCSGOdir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCSSdirSearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtCSSdir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSteamCMDdirLock_Click(object sender, EventArgs e)
        {
            if (txtSteamCMDdir.ReadOnly == true)
            {
                txtSteamCMDdir.ReadOnly = false;
                btnSteamCMDdirLock.Text = "Lås";
                btnSteamCMDdirSearch.Enabled = true;
            }
            else
            {
                txtSteamCMDdir.ReadOnly = true;
                btnSteamCMDdirLock.Text = "Lås op";
                btnSteamCMDdirSearch.Enabled = false;
            }
        }

        private void btnCSGOdirLock_Click(object sender, EventArgs e)
        {
            if (txtCSGOdir.ReadOnly == true)
            {
                txtCSGOdir.ReadOnly = false;
                btnCSGOdirLock.Text = "Lås";
                btnCSGOdirSearch.Enabled = true;
            }
            else
            {
                txtCSGOdir.ReadOnly = true;
                btnCSGOdirLock.Text = "Lås op";
                btnCSGOdirSearch.Enabled = false;
            }
        }

        private void btnCSSdirLock_Click(object sender, EventArgs e)
        {
            if (txtCSSdir.ReadOnly == true)
            {
                txtCSSdir.ReadOnly = false;
                btnCSSdirLock.Text = "Lås";
                btnCSSdirSearch.Enabled = true;
            }
            else
            {
                txtCSSdir.ReadOnly = true;
                btnCSSdirLock.Text = "Lås op";
                btnCSSdirSearch.Enabled = false;
            }
        }
    }
}
