
namespace q1
{
    partial class form_MenuGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.About_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.signinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu,
            this.signinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_Menu
            // 
            this.File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_Menu,
            this.Exit_Menu});
            this.File_Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.File_Menu.Name = "File_Menu";
            this.File_Menu.Size = new System.Drawing.Size(46, 24);
            this.File_Menu.Text = "File";
            // 
            // About_Menu
            // 
            this.About_Menu.Name = "About_Menu";
            this.About_Menu.Size = new System.Drawing.Size(224, 26);
            this.About_Menu.Text = "About";
            this.About_Menu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Exit_Menu
            // 
            this.Exit_Menu.Name = "Exit_Menu";
            this.Exit_Menu.Size = new System.Drawing.Size(224, 26);
            this.Exit_Menu.Text = "Exit";
            this.Exit_Menu.Click += new System.EventHandler(this.Exit_Menu_Click);
            // 
            // signinToolStripMenuItem
            // 
            this.signinToolStripMenuItem.Name = "signinToolStripMenuItem";
            this.signinToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.signinToolStripMenuItem.Text = "SignIn";
            this.signinToolStripMenuItem.Click += new System.EventHandler(this.signinToolStripMenuItem_Click);
            // 
            // form_MenuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_Menu;
        private System.Windows.Forms.ToolStripMenuItem About_Menu;
        private System.Windows.Forms.ToolStripMenuItem Exit_Menu;
        private System.Windows.Forms.ToolStripMenuItem signinToolStripMenuItem;
    }
}

