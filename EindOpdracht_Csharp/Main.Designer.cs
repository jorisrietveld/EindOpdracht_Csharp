namespace EindOpdracht_Csharp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabCurrent = new System.Windows.Forms.TabPage();
            this.tabTrend = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuRefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuOptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabMenu.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabCurrent);
            this.tabMenu.Controls.Add(this.tabTrend);
            this.tabMenu.Controls.Add(this.tabOptions);
            this.tabMenu.Location = new System.Drawing.Point(0, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(435, 333);
            this.tabMenu.TabIndex = 0;
            // 
            // tabCurrent
            // 
            this.tabCurrent.Location = new System.Drawing.Point(4, 22);
            this.tabCurrent.Name = "tabCurrent";
            this.tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrent.Size = new System.Drawing.Size(427, 307);
            this.tabCurrent.TabIndex = 0;
            this.tabCurrent.Text = "Actueel";
            this.tabCurrent.UseVisualStyleBackColor = true;
            // 
            // tabTrend
            // 
            this.tabTrend.Location = new System.Drawing.Point(4, 22);
            this.tabTrend.Name = "tabTrend";
            this.tabTrend.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrend.Size = new System.Drawing.Size(427, 307);
            this.tabTrend.TabIndex = 1;
            this.tabTrend.Text = "Trend";
            this.tabTrend.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(427, 307);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Opties";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.ContextMenuStrip = this.trayMenu;
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Text = "Stenden Weerstation";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayMenu_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuTitle,
            this.trayMenuAboutButton,
            this.toolStripSeparator2,
            this.trayMenuRefreshButton,
            this.toolStripSeparator3,
            this.trayMenuOptionsButton,
            this.toolStripSeparator1,
            this.trayMenuOpenButton,
            this.trayMenuCloseButton});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(206, 176);
            // 
            // trayMenuTitle
            // 
            this.trayMenuTitle.BackColor = System.Drawing.Color.Navy;
            this.trayMenuTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.trayMenuTitle.Name = "trayMenuTitle";
            this.trayMenuTitle.Size = new System.Drawing.Size(205, 22);
            this.trayMenuTitle.Text = "Huidige temperatuur: 7C";
            this.trayMenuTitle.Click += new System.EventHandler(this.TrayMenuTitle_Click);
            // 
            // trayMenuAboutButton
            // 
            this.trayMenuAboutButton.Name = "trayMenuAboutButton";
            this.trayMenuAboutButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuAboutButton.Text = "Over...";
            this.trayMenuAboutButton.Click += new System.EventHandler(this.TrayMenuAboutButton_Click);
            // 
            // trayMenuRefreshButton
            // 
            this.trayMenuRefreshButton.Name = "trayMenuRefreshButton";
            this.trayMenuRefreshButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuRefreshButton.Text = "Verversen...";
            this.trayMenuRefreshButton.Click += new System.EventHandler(this.TrayMenuRefreshButton_Click);
            // 
            // trayMenuOptionsButton
            // 
            this.trayMenuOptionsButton.Name = "trayMenuOptionsButton";
            this.trayMenuOptionsButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuOptionsButton.Text = "Opties...";
            this.trayMenuOptionsButton.Click += new System.EventHandler(this.TrayMenuOptionsButton_Click);
            // 
            // trayMenuOpenButton
            // 
            this.trayMenuOpenButton.Name = "trayMenuOpenButton";
            this.trayMenuOpenButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuOpenButton.Text = "Open...";
            // 
            // trayMenuCloseButton
            // 
            this.trayMenuCloseButton.Name = "trayMenuCloseButton";
            this.trayMenuCloseButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuCloseButton.Text = "Sluiten";
            this.trayMenuCloseButton.Click += new System.EventHandler(this.TrayMenuCloseButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenden Weather";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMenu.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.TabPage tabTrend;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuTitle;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayMenuRefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOptionsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOpenButton;
        private System.Windows.Forms.ToolStripMenuItem trayMenuCloseButton;
    }
}