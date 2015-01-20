namespace QuraanRadio
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblExit = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblPlay = new System.Windows.Forms.Label();
            this.LblPause = new System.Windows.Forms.Label();
            this.LblNext = new System.Windows.Forms.Label();
            this.LblDownload = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.LblAbout = new System.Windows.Forms.Label();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblExit
            // 
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblExit.Location = new System.Drawing.Point(285, 26);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(19, 11);
            this.LblExit.TabIndex = 0;
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblMin
            // 
            this.LblMin.BackColor = System.Drawing.Color.Transparent;
            this.LblMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMin.Location = new System.Drawing.Point(260, 26);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(19, 11);
            this.LblMin.TabIndex = 1;
            this.LblMin.Click += new System.EventHandler(this.LblMin_Click);
            // 
            // LblPlay
            // 
            this.LblPlay.BackColor = System.Drawing.Color.Transparent;
            this.LblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPlay.Location = new System.Drawing.Point(86, 51);
            this.LblPlay.Name = "LblPlay";
            this.LblPlay.Size = new System.Drawing.Size(35, 31);
            this.LblPlay.TabIndex = 2;
            this.LblPlay.Click += new System.EventHandler(this.LblPlay_Click);
            // 
            // LblPause
            // 
            this.LblPause.BackColor = System.Drawing.Color.Transparent;
            this.LblPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPause.Location = new System.Drawing.Point(127, 51);
            this.LblPause.Name = "LblPause";
            this.LblPause.Size = new System.Drawing.Size(45, 31);
            this.LblPause.TabIndex = 3;
            this.LblPause.Click += new System.EventHandler(this.LblPause_Click);
            // 
            // LblNext
            // 
            this.LblNext.BackColor = System.Drawing.Color.Transparent;
            this.LblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNext.Location = new System.Drawing.Point(178, 51);
            this.LblNext.Name = "LblNext";
            this.LblNext.Size = new System.Drawing.Size(50, 31);
            this.LblNext.TabIndex = 4;
            this.LblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // LblDownload
            // 
            this.LblDownload.BackColor = System.Drawing.Color.Transparent;
            this.LblDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDownload.Location = new System.Drawing.Point(234, 51);
            this.LblDownload.Name = "LblDownload";
            this.LblDownload.Size = new System.Drawing.Size(35, 31);
            this.LblDownload.TabIndex = 5;
            this.LblDownload.Click += new System.EventHandler(this.LblDownload_Click);
            // 
            // prgBar
            // 
            this.prgBar.BackColor = System.Drawing.Color.Gray;
            this.prgBar.Location = new System.Drawing.Point(47, 26);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(49, 10);
            this.prgBar.TabIndex = 6;
            this.prgBar.Visible = false;
            // 
            // LblAbout
            // 
            this.LblAbout.BackColor = System.Drawing.Color.Transparent;
            this.LblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAbout.Location = new System.Drawing.Point(285, 42);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(19, 11);
            this.LblAbout.TabIndex = 7;
            this.LblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::QuraanRadio.Properties.Resources.app1;
            this.ClientSize = new System.Drawing.Size(337, 91);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.LblDownload);
            this.Controls.Add(this.LblNext);
            this.Controls.Add(this.LblPause);
            this.Controls.Add(this.LblPlay);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.LblExit);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quraan Radio";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.cMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblPlay;
        private System.Windows.Forms.Label LblPause;
        private System.Windows.Forms.Label LblNext;
        private System.Windows.Forms.Label LblDownload;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

