﻿namespace Ejercicios_Cap9_11
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
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo9ToolStripMenuItem,
            this.capitulo10ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capitulo9ToolStripMenuItem
            // 
            this.capitulo9ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem});
            this.capitulo9ToolStripMenuItem.Name = "capitulo9ToolStripMenuItem";
            this.capitulo9ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.capitulo9ToolStripMenuItem.Text = "&Capitulo 9";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem.Text = "&Ejercicio 1 y 3";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio1ToolStripMenuItem_Click);
            // 
            // capitulo10ToolStripMenuItem
            // 
            this.capitulo10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio2ToolStripMenuItem});
            this.capitulo10ToolStripMenuItem.Name = "capitulo10ToolStripMenuItem";
            this.capitulo10ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.capitulo10ToolStripMenuItem.Text = "&Capitulo 10";
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio2ToolStripMenuItem.Text = "&Ejercicio 2";
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio2ToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
    }
}

