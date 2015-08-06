using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void btnServerUpdatePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtServerUpdatePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSteamCMDPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSteamCMDPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void chkAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnonymous.Checked == false)
            {
                chkRememberLogin.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                chkRememberLogin.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void chkRememberLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberLogin.Checked == false)
            {
                chkAnonymous.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                chkAnonymous.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnServerInstall_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (chkAnonymous.Checked == false)
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Indtast brugernavn og adgangskode");
                    error = true;
                }
            }

            if (chkAnonymous.Checked == true && cmbServerProgram.Text == "Counter-Strike: Global Offensive" && error == false)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = txtSteamCMDPath.Text + "\\steamcmd.exe";
                startInfo.Arguments = "+login anonymous +force_install_dir " + "\"" + txtServerUpdatePath.Text + "\"" + " +app_update 740 +quit";
                process.StartInfo = startInfo;

                process.Start();
            }

            if (chkAnonymous.Checked == false && cmbServerProgram.Text == "Counter-Strike: Global Offensive" && error == false)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = txtSteamCMDPath.Text + "\\steamcmd.exe";
                startInfo.Arguments = "+login " + txtUsername.Text + " " + txtPassword.Text + " +force_install_dir " + "\"" + txtServerUpdatePath.Text + "\"" + " +app_update 740 +quit";
                process.StartInfo = startInfo;

                process.Start();
            }

            if (chkAnonymous.Checked == true && cmbServerProgram.Text == "Counter-Strike: Source" && error == false)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = txtSteamCMDPath.Text + "\\steamcmd.exe";
                startInfo.Arguments = "+login anonymous +force_install_dir " + "\"" + txtServerUpdatePath.Text + "\"" + " +app_update 232330 +quit";
                process.StartInfo = startInfo;

                process.Start();
            }

            if (chkAnonymous.Checked == false && cmbServerProgram.Text == "Counter-Strike: Source" && error == false)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = txtSteamCMDPath.Text + "\\steamcmd.exe";
                startInfo.Arguments = "+login " + txtUsername.Text + " " + txtPassword.Text + " +force_install_dir " + "\"" + txtServerUpdatePath.Text + "\"" + " +app_update 232330 +quit";
                process.StartInfo = startInfo;

                process.Start();
            }

            error = false;
        }
    }
}
