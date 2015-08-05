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
            this.Source = new System.Windows.Forms.TabPage();
            this.GlobalOffensive = new System.Windows.Forms.TabPage();
            this.Indstillinger = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCSSdirSearch = new System.Windows.Forms.Button();
            this.btnCSGOdirSearch = new System.Windows.Forms.Button();
            this.btnSteamCMDdirSearch = new System.Windows.Forms.Button();
            this.btnCSSdirLock = new System.Windows.Forms.Button();
            this.btnCSGOdirLock = new System.Windows.Forms.Button();
            this.btnSteamCMDdirLock = new System.Windows.Forms.Button();
            this.txtCSSdir = new System.Windows.Forms.TextBox();
            this.txtCSGOdir = new System.Windows.Forms.TextBox();
            this.txtSteamCMDdir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.Indstillinger.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.Indstillinger);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // SteamCMD
            // 
            this.SteamCMD.Location = new System.Drawing.Point(4, 25);
            this.SteamCMD.Name = "SteamCMD";
            this.SteamCMD.Padding = new System.Windows.Forms.Padding(3);
            this.SteamCMD.Size = new System.Drawing.Size(773, 528);
            this.SteamCMD.TabIndex = 2;
            this.SteamCMD.Text = "SteamCMD";
            this.SteamCMD.UseVisualStyleBackColor = true;
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(4, 25);
            this.Source.Name = "Source";
            this.Source.Padding = new System.Windows.Forms.Padding(3);
            this.Source.Size = new System.Drawing.Size(773, 528);
            this.Source.TabIndex = 1;
            this.Source.Text = "Source";
            this.Source.UseVisualStyleBackColor = true;
            // 
            // GlobalOffensive
            // 
            this.GlobalOffensive.Location = new System.Drawing.Point(4, 25);
            this.GlobalOffensive.Name = "GlobalOffensive";
            this.GlobalOffensive.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalOffensive.Size = new System.Drawing.Size(773, 528);
            this.GlobalOffensive.TabIndex = 0;
            this.GlobalOffensive.Text = "Global Offensive";
            this.GlobalOffensive.UseVisualStyleBackColor = true;
            // 
            // Indstillinger
            // 
            this.Indstillinger.Controls.Add(this.label3);
            this.Indstillinger.Controls.Add(this.label2);
            this.Indstillinger.Controls.Add(this.label1);
            this.Indstillinger.Controls.Add(this.btnCSSdirSearch);
            this.Indstillinger.Controls.Add(this.btnCSGOdirSearch);
            this.Indstillinger.Controls.Add(this.btnSteamCMDdirSearch);
            this.Indstillinger.Controls.Add(this.btnCSSdirLock);
            this.Indstillinger.Controls.Add(this.btnCSGOdirLock);
            this.Indstillinger.Controls.Add(this.btnSteamCMDdirLock);
            this.Indstillinger.Controls.Add(this.txtCSSdir);
            this.Indstillinger.Controls.Add(this.txtCSGOdir);
            this.Indstillinger.Controls.Add(this.txtSteamCMDdir);
            this.Indstillinger.Location = new System.Drawing.Point(4, 25);
            this.Indstillinger.Name = "Indstillinger";
            this.Indstillinger.Padding = new System.Windows.Forms.Padding(3);
            this.Indstillinger.Size = new System.Drawing.Size(773, 528);
            this.Indstillinger.TabIndex = 3;
            this.Indstillinger.Text = "Indstillinger";
            this.Indstillinger.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CS:S";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CS:GO";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SteamCMD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCSSdirSearch
            // 
            this.btnCSSdirSearch.Location = new System.Drawing.Point(595, 62);
            this.btnCSSdirSearch.Name = "btnCSSdirSearch";
            this.btnCSSdirSearch.Size = new System.Drawing.Size(91, 23);
            this.btnCSSdirSearch.TabIndex = 1;
            this.btnCSSdirSearch.Text = "Gennemse";
            this.btnCSSdirSearch.UseVisualStyleBackColor = true;
            this.btnCSSdirSearch.Click += new System.EventHandler(this.btnCSSdirSearch_Click);
            // 
            // btnCSGOdirSearch
            // 
            this.btnCSGOdirSearch.Location = new System.Drawing.Point(595, 34);
            this.btnCSGOdirSearch.Name = "btnCSGOdirSearch";
            this.btnCSGOdirSearch.Size = new System.Drawing.Size(91, 23);
            this.btnCSGOdirSearch.TabIndex = 1;
            this.btnCSGOdirSearch.Text = "Gennemse";
            this.btnCSGOdirSearch.UseVisualStyleBackColor = true;
            this.btnCSGOdirSearch.Click += new System.EventHandler(this.btnCSGOdirSearch_Click);
            // 
            // btnSteamCMDdirSearch
            // 
            this.btnSteamCMDdirSearch.Location = new System.Drawing.Point(595, 6);
            this.btnSteamCMDdirSearch.Name = "btnSteamCMDdirSearch";
            this.btnSteamCMDdirSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSteamCMDdirSearch.TabIndex = 1;
            this.btnSteamCMDdirSearch.Text = "Gennemse";
            this.btnSteamCMDdirSearch.UseVisualStyleBackColor = true;
            this.btnSteamCMDdirSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCSSdirLock
            // 
            this.btnCSSdirLock.Location = new System.Drawing.Point(692, 62);
            this.btnCSSdirLock.Name = "btnCSSdirLock";
            this.btnCSSdirLock.Size = new System.Drawing.Size(75, 23);
            this.btnCSSdirLock.TabIndex = 1;
            this.btnCSSdirLock.Text = "Lås";
            this.btnCSSdirLock.UseVisualStyleBackColor = true;
            this.btnCSSdirLock.Click += new System.EventHandler(this.btnCSSdirLock_Click);
            // 
            // btnCSGOdirLock
            // 
            this.btnCSGOdirLock.Location = new System.Drawing.Point(692, 34);
            this.btnCSGOdirLock.Name = "btnCSGOdirLock";
            this.btnCSGOdirLock.Size = new System.Drawing.Size(75, 23);
            this.btnCSGOdirLock.TabIndex = 1;
            this.btnCSGOdirLock.Text = "Lås";
            this.btnCSGOdirLock.UseVisualStyleBackColor = true;
            this.btnCSGOdirLock.Click += new System.EventHandler(this.btnCSGOdirLock_Click);
            // 
            // btnSteamCMDdirLock
            // 
            this.btnSteamCMDdirLock.Location = new System.Drawing.Point(692, 6);
            this.btnSteamCMDdirLock.Name = "btnSteamCMDdirLock";
            this.btnSteamCMDdirLock.Size = new System.Drawing.Size(75, 23);
            this.btnSteamCMDdirLock.TabIndex = 1;
            this.btnSteamCMDdirLock.Text = "Lås";
            this.btnSteamCMDdirLock.UseVisualStyleBackColor = true;
            this.btnSteamCMDdirLock.Click += new System.EventHandler(this.btnSteamCMDdirLock_Click);
            // 
            // txtCSSdir
            // 
            this.txtCSSdir.Location = new System.Drawing.Point(90, 63);
            this.txtCSSdir.Name = "txtCSSdir";
            this.txtCSSdir.Size = new System.Drawing.Size(499, 22);
            this.txtCSSdir.TabIndex = 0;
            // 
            // txtCSGOdir
            // 
            this.txtCSGOdir.Location = new System.Drawing.Point(90, 35);
            this.txtCSGOdir.Name = "txtCSGOdir";
            this.txtCSGOdir.Size = new System.Drawing.Size(499, 22);
            this.txtCSGOdir.TabIndex = 0;
            // 
            // txtSteamCMDdir
            // 
            this.txtSteamCMDdir.Location = new System.Drawing.Point(90, 7);
            this.txtSteamCMDdir.Name = "txtSteamCMDdir";
            this.txtSteamCMDdir.Size = new System.Drawing.Size(499, 22);
            this.txtSteamCMDdir.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 581);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Indstillinger.ResumeLayout(false);
            this.Indstillinger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GlobalOffensive;
        private System.Windows.Forms.TabPage Source;
        private System.Windows.Forms.TabPage SteamCMD;
        private System.Windows.Forms.TabPage Indstillinger;
        private System.Windows.Forms.Button btnSteamCMDdirLock;
        private System.Windows.Forms.TextBox txtSteamCMDdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCSSdirSearch;
        private System.Windows.Forms.Button btnCSGOdirSearch;
        private System.Windows.Forms.Button btnSteamCMDdirSearch;
        private System.Windows.Forms.Button btnCSSdirLock;
        private System.Windows.Forms.Button btnCSGOdirLock;
        private System.Windows.Forms.TextBox txtCSSdir;
        private System.Windows.Forms.TextBox txtCSGOdir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

