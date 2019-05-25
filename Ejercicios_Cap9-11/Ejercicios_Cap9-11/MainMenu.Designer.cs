namespace Ejercicios_Cap9_11
{
    partial class MainMenu
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
            this.capitulo9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo9ToolStripMenuItem,
            this.capitulo10ToolStripMenuItem,
            this.capitulo11ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capitulo9ToolStripMenuItem
            // 
            this.capitulo9ToolStripMenuItem.Name = "capitulo9ToolStripMenuItem";
            this.capitulo9ToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.capitulo9ToolStripMenuItem.Text = "&1.Capitulo 9";
            // 
            // capitulo10ToolStripMenuItem
            // 
            this.capitulo10ToolStripMenuItem.Name = "capitulo10ToolStripMenuItem";
            this.capitulo10ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.capitulo10ToolStripMenuItem.Text = "&2.Capitulo 10";
            // 
            // capitulo11ToolStripMenuItem
            // 
            this.capitulo11ToolStripMenuItem.Name = "capitulo11ToolStripMenuItem";
            this.capitulo11ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.capitulo11ToolStripMenuItem.Text = "&3.Capitulo 11";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capitulo9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo11ToolStripMenuItem;
    }
}

