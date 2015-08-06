namespace Counter_Strike_Server_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SteamCMD = new System.Windows.Forms.TabPage();
            this.btnSteamCMDPath = new System.Windows.Forms.Button();
            this.txtSteamCMDPath = new System.Windows.Forms.TextBox();
            this.txtServerUpdatePath = new System.Windows.Forms.TextBox();
            this.chkRememberLogin = new System.Windows.Forms.CheckBox();
            this.chkAnonymous = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnServerInstall = new System.Windows.Forms.Button();
            this.btnServerUpdatePath = new System.Windows.Forms.Button();
            this.btnSteamCMDSave = new System.Windows.Forms.Button();
            this.cmbServerProgram = new System.Windows.Forms.ComboBox();
            this.Source = new System.Windows.Forms.TabPage();
            this.GlobalOffensive = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.SteamCMD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SteamCMD);
            this.tabControl1.Controls.Add(this.Source);
            this.tabControl1.Controls.Add(this.GlobalOffensive);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // SteamCMD
            // 
            this.SteamCMD.Controls.Add(this.btnSteamCMDPath);
            this.SteamCMD.Controls.Add(this.txtSteamCMDPath);
            this.SteamCMD.Controls.Add(this.txtServerUpdatePath);
            this.SteamCMD.Controls.Add(this.chkRememberLogin);
            this.SteamCMD.Controls.Add(this.chkAnonymous);
            this.SteamCMD.Controls.Add(this.txtPassword);
            this.SteamCMD.Controls.Add(this.txtUsername);
            this.SteamCMD.Controls.Add(this.label7);
            this.SteamCMD.Controls.Add(this.label6);
            this.SteamCMD.Controls.Add(this.label9);
            this.SteamCMD.Controls.Add(this.label5);
            this.SteamCMD.Controls.Add(this.label8);
            this.SteamCMD.Controls.Add(this.label4);
            this.SteamCMD.Controls.Add(this.btnServerInstall);
            this.SteamCMD.Controls.Add(this.btnServerUpdatePath);
            this.SteamCMD.Controls.Add(this.btnSteamCMDSave);
            this.SteamCMD.Controls.Add(this.cmbServerProgram);
            this.SteamCMD.Location = new System.Drawing.Point(4, 25);
            this.SteamCMD.Name = "SteamCMD";
            this.SteamCMD.Padding = new System.Windows.Forms.Padding(3);
            this.SteamCMD.Size = new System.Drawing.Size(552, 408);
            this.SteamCMD.TabIndex = 2;
            this.SteamCMD.Text = "SteamCMD";
            this.SteamCMD.UseVisualStyleBackColor = true;
            // 
            // btnSteamCMDPath
            // 
            this.btnSteamCMDPath.Location = new System.Drawing.Point(432, 127);
            this.btnSteamCMDPath.Name = "btnSteamCMDPath";
            this.btnSteamCMDPath.Size = new System.Drawing.Size(114, 23);
            this.btnSteamCMDPath.TabIndex = 10;
            this.btnSteamCMDPath.Text = "Gennemse";
            this.btnSteamCMDPath.UseVisualStyleBackColor = true;
            this.btnSteamCMDPath.Click += new System.EventHandler(this.btnSteamCMDPath_Click);
            // 
            // txtSteamCMDPath
            // 
            this.txtSteamCMDPath.Location = new System.Drawing.Point(9, 127);
            this.txtSteamCMDPath.Name = "txtSteamCMDPath";
            this.txtSteamCMDPath.Size = new System.Drawing.Size(417, 22);
            this.txtSteamCMDPath.TabIndex = 9;
            // 
            // txtServerUpdatePath
            // 
            this.txtServerUpdatePath.Location = new System.Drawing.Point(9, 78);
            this.txtServerUpdatePath.Name = "txtServerUpdatePath";
            this.txtServerUpdatePath.Size = new System.Drawing.Size(417, 22);
            this.txtServerUpdatePath.TabIndex = 8;
            // 
            // chkRememberLogin
            // 
            this.chkRememberLogin.AutoSize = true;
            this.chkRememberLogin.Location = new System.Drawing.Point(424, 249);
            this.chkRememberLogin.Name = "chkRememberLogin";
            this.chkRememberLogin.Size = new System.Drawing.Size(90, 20);
            this.chkRememberLogin.TabIndex = 7;
            this.chkRememberLogin.Text = "Husk login";
            this.chkRememberLogin.UseVisualStyleBackColor = true;
            this.chkRememberLogin.CheckedChanged += new System.EventHandler(this.chkRememberLogin_CheckedChanged);
            // 
            // chkAnonymous
            // 
            this.chkAnonymous.AutoSize = true;
            this.chkAnonymous.Location = new System.Drawing.Point(424, 203);
            this.chkAnonymous.Name = "chkAnonymous";
            this.chkAnonymous.Size = new System.Drawing.Size(122, 20);
            this.chkAnonymous.TabIndex = 6;
            this.chkAnonymous.Text = "Log ind anonym";
            this.chkAnonymous.UseVisualStyleBackColor = true;
            this.chkAnonymous.CheckedChanged += new System.EventHandler(this.chkAnonymous_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 247);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'x';
            this.txtPassword.Size = new System.Drawing.Size(409, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(9, 201);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(409, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adgangskode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Brugernavn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sti til SteamCMD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login til SteamCMD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sti til server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Server program der skal installeres / opdateres";
            // 
            // btnServerInstall
            // 
            this.btnServerInstall.Location = new System.Drawing.Point(424, 378);
            this.btnServerInstall.Name = "btnServerInstall";
            this.btnServerInstall.Size = new System.Drawing.Size(122, 24);
            this.btnServerInstall.TabIndex = 3;
            this.btnServerInstall.Text = "Installer / Opdater";
            this.btnServerInstall.UseVisualStyleBackColor = true;
            this.btnServerInstall.Click += new System.EventHandler(this.btnServerInstall_Click);
            // 
            // btnServerUpdatePath
            // 
            this.btnServerUpdatePath.Location = new System.Drawing.Point(432, 77);
            this.btnServerUpdatePath.Name = "btnServerUpdatePath";
            this.btnServerUpdatePath.Size = new System.Drawing.Size(114, 24);
            this.btnServerUpdatePath.TabIndex = 3;
            this.btnServerUpdatePath.Text = "Gennemse";
            this.btnServerUpdatePath.UseVisualStyleBackColor = true;
            this.btnServerUpdatePath.Click += new System.EventHandler(this.btnServerUpdatePath_Click);
            // 
            // btnSteamCMDSave
            // 
            this.btnSteamCMDSave.Location = new System.Drawing.Point(6, 378);
            this.btnSteamCMDSave.Name = "btnSteamCMDSave";
            this.btnSteamCMDSave.Size = new System.Drawing.Size(75, 24);
            this.btnSteamCMDSave.TabIndex = 3;
            this.btnSteamCMDSave.Text = "Gem";
            this.btnSteamCMDSave.UseVisualStyleBackColor = true;
            // 
            // cmbServerProgram
            // 
            this.cmbServerProgram.FormattingEnabled = true;
            this.cmbServerProgram.Items.AddRange(new object[] {
            "Counter-Strike: Source",
            "Counter-Strike: Global Offensive"});
            this.cmbServerProgram.Location = new System.Drawing.Point(9, 28);
            this.cmbServerProgram.Name = "cmbServerProgram";
            this.cmbServerProgram.Size = new System.Drawing.Size(537, 24);
            this.cmbServerProgram.TabIndex = 2;
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(4, 25);
            this.Source.Name = "Source";
            this.Source.Padding = new System.Windows.Forms.Padding(3);
            this.Source.Size = new System.Drawing.Size(552, 408);
            this.Source.TabIndex = 1;
            this.Source.Text = "Source";
            this.Source.UseVisualStyleBackColor = true;
            // 
            // GlobalOffensive
            // 
            this.GlobalOffensive.Location = new System.Drawing.Point(4, 25);
            this.GlobalOffensive.Name = "GlobalOffensive";
            this.GlobalOffensive.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalOffensive.Size = new System.Drawing.Size(552, 408);
            this.GlobalOffensive.TabIndex = 0;
            this.GlobalOffensive.Text = "Global Offensive";
            this.GlobalOffensive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SteamCMD.ResumeLayout(false);
            this.SteamCMD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GlobalOffensive;
        private System.Windows.Forms.TabPage Source;
        private System.Windows.Forms.TabPage SteamCMD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnServerInstall;
        private System.Windows.Forms.ComboBox cmbServerProgram;
        private System.Windows.Forms.CheckBox chkRememberLogin;
        private System.Windows.Forms.CheckBox chkAnonymous;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerUpdatePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnServerUpdatePath;
        private System.Windows.Forms.Button btnSteamCMDSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSteamCMDPath;
        private System.Windows.Forms.TextBox txtSteamCMDPath;
    }
}

