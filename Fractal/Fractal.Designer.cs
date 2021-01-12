namespace Fractal
{
    partial class Fractal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fractal));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.appMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.printPicture = new System.Drawing.Printing.PrintDocument();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.loadStateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.reloadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customSize = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalSetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mandelbrotMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setConstantsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appMenu,
            this.toolsToolStripMenuItem,
            this.settingsMenu,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(640, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "Menu Bar";
            this.menuBar.MouseEnter += new System.EventHandler(this.menuBar_MouseEnter);
            // 
            // appMenu
            // 
            this.appMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadMenu,
            this.restartMenu,
            this.startMenu,
            this.stopMenu,
            this.cloneMenu,
            this.toolStripSeparator2,
            this.closeMenu,
            this.quitMenu});
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(41, 20);
            this.appMenu.Text = "App";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenu,
            this.saveStateMenu,
            this.loadStateMenu,
            this.printMenu});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customSize,
            this.fractalSetMenu,
            this.setConstantsMenu});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 20);
            this.settingsMenu.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenu});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 516);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "App Started";
            // 
            // printPicture
            // 
            this.printPicture.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPicture_PrintPage);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.sizeLabel.ForeColor = System.Drawing.Color.Black;
            this.sizeLabel.Location = new System.Drawing.Point(546, 516);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sizeLabel.Size = new System.Drawing.Size(82, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size: 640 X 480";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadStateMenu
            // 
            this.loadStateMenu.BackColor = System.Drawing.SystemColors.Control;
            this.loadStateMenu.Image = global::Fractal.Properties.Resources.LoadProfilenode_8711;
            this.loadStateMenu.Name = "loadStateMenu";
            this.loadStateMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadStateMenu.Size = new System.Drawing.Size(199, 22);
            this.loadStateMenu.Text = "Load State";
            this.loadStateMenu.Click += new System.EventHandler(this.loadStateMenu_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 480);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // reloadMenu
            // 
            this.reloadMenu.Image = global::Fractal.Properties.Resources.Refresh_icon;
            this.reloadMenu.Name = "reloadMenu";
            this.reloadMenu.Size = new System.Drawing.Size(147, 22);
            this.reloadMenu.Text = "Reload";
            this.reloadMenu.Click += new System.EventHandler(this.reloadMenu_Click);
            // 
            // restartMenu
            // 
            this.restartMenu.Image = global::Fractal.Properties.Resources.Restart_6322;
            this.restartMenu.Name = "restartMenu";
            this.restartMenu.Size = new System.Drawing.Size(147, 22);
            this.restartMenu.Text = "Restart";
            this.restartMenu.Click += new System.EventHandler(this.restartMenu_Click);
            // 
            // startMenu
            // 
            this.startMenu.Image = global::Fractal.Properties.Resources.startwithoutdebugging_6556;
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(147, 22);
            this.startMenu.Text = "Start";
            this.startMenu.Click += new System.EventHandler(this.startMenu_Click);
            // 
            // stopMenu
            // 
            this.stopMenu.Image = global::Fractal.Properties.Resources.Symbols_Stop_32xLG;
            this.stopMenu.Name = "stopMenu";
            this.stopMenu.Size = new System.Drawing.Size(147, 22);
            this.stopMenu.Text = "Stop";
            this.stopMenu.Click += new System.EventHandler(this.stopMenu_Click);
            // 
            // cloneMenu
            // 
            this.cloneMenu.Image = global::Fractal.Properties.Resources.Copy_6524;
            this.cloneMenu.Name = "cloneMenu";
            this.cloneMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cloneMenu.Size = new System.Drawing.Size(147, 22);
            this.cloneMenu.Text = "Clone";
            this.cloneMenu.Click += new System.EventHandler(this.cloneMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Image = global::Fractal.Properties.Resources.close;
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.closeMenu.Size = new System.Drawing.Size(147, 22);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // quitMenu
            // 
            this.quitMenu.BackColor = System.Drawing.SystemColors.Control;
            this.quitMenu.Image = global::Fractal.Properties.Resources.quit;
            this.quitMenu.Name = "quitMenu";
            this.quitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitMenu.Size = new System.Drawing.Size(147, 22);
            this.quitMenu.Text = "Quit";
            this.quitMenu.Click += new System.EventHandler(this.quitMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveMenu.Image")));
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenu.Size = new System.Drawing.Size(199, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveStateMenu
            // 
            this.saveStateMenu.Image = global::Fractal.Properties.Resources.SaveFileDialogControl_703;
            this.saveStateMenu.Name = "saveStateMenu";
            this.saveStateMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveStateMenu.Size = new System.Drawing.Size(199, 22);
            this.saveStateMenu.Text = "Save State";
            this.saveStateMenu.Click += new System.EventHandler(this.saveStateMenu_Click);
            // 
            // printMenu
            // 
            this.printMenu.Image = ((System.Drawing.Image)(resources.GetObject("printMenu.Image")));
            this.printMenu.Name = "printMenu";
            this.printMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenu.Size = new System.Drawing.Size(199, 22);
            this.printMenu.Text = "Print";
            this.printMenu.Click += new System.EventHandler(this.printMenu_Click);
            // 
            // customSize
            // 
            this.customSize.Image = ((System.Drawing.Image)(resources.GetObject("customSize.Image")));
            this.customSize.Name = "customSize";
            this.customSize.Size = new System.Drawing.Size(146, 22);
            this.customSize.Text = "Custom Size";
            this.customSize.Click += new System.EventHandler(this.customSize_Click);
            // 
            // fractalSetMenu
            // 
            this.fractalSetMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandelbrotMenu,
            this.juliaMenu});
            this.fractalSetMenu.Image = ((System.Drawing.Image)(resources.GetObject("fractalSetMenu.Image")));
            this.fractalSetMenu.Name = "fractalSetMenu";
            this.fractalSetMenu.Size = new System.Drawing.Size(146, 22);
            this.fractalSetMenu.Text = "Fractal Set";
            // 
            // mandelbrotMenu
            // 
            this.mandelbrotMenu.Name = "mandelbrotMenu";
            this.mandelbrotMenu.Size = new System.Drawing.Size(136, 22);
            this.mandelbrotMenu.Text = "Mandelbrot";
            this.mandelbrotMenu.Click += new System.EventHandler(this.mandelbrotMenu_Click);
            // 
            // juliaMenu
            // 
            this.juliaMenu.Name = "juliaMenu";
            this.juliaMenu.Size = new System.Drawing.Size(136, 22);
            this.juliaMenu.Text = "Julia";
            this.juliaMenu.Click += new System.EventHandler(this.juliaMenu_Click);
            // 
            // setConstantsMenu
            // 
            this.setConstantsMenu.Image = global::Fractal.Properties.Resources.SetIterationCount_8811;
            this.setConstantsMenu.Name = "setConstantsMenu";
            this.setConstantsMenu.Size = new System.Drawing.Size(146, 22);
            this.setConstantsMenu.Text = "Set Constants";
            this.setConstantsMenu.Click += new System.EventHandler(this.setConstantsMenu_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.Image = global::Fractal.Properties.Resources.InfoPathDocumentView2010_11758;
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoMenu.Size = new System.Drawing.Size(132, 22);
            this.infoMenu.Text = "Info";
            this.infoMenu.Click += new System.EventHandler(this.infoMenu_Click);
            // 
            // Fractal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 538);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Fractal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fractal_FormClosed);
            this.Resize += new System.EventHandler(this.Fractal_Resize);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem printMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.Label statusLabel;
        private System.Drawing.Printing.PrintDocument printPicture;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem customSize;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ToolStripMenuItem appMenu;
        private System.Windows.Forms.ToolStripMenuItem reloadMenu;
        private System.Windows.Forms.ToolStripMenuItem restartMenu;
        private System.Windows.Forms.ToolStripMenuItem startMenu;
        private System.Windows.Forms.ToolStripMenuItem stopMenu;
        private System.Windows.Forms.ToolStripMenuItem cloneMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem quitMenu;
        private System.Windows.Forms.ToolStripMenuItem fractalSetMenu;
        private System.Windows.Forms.ToolStripMenuItem mandelbrotMenu;
        private System.Windows.Forms.ToolStripMenuItem juliaMenu;
        private System.Windows.Forms.ToolStripMenuItem setConstantsMenu;
        private System.Windows.Forms.ToolStripMenuItem saveStateMenu;
        private System.Windows.Forms.ToolStripMenuItem loadStateMenu;
    }
}

