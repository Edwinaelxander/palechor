﻿namespace Minimarket
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miniMarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniMarketToolStripMenuItem,
            this.proveToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // miniMarketToolStripMenuItem
            // 
            this.miniMarketToolStripMenuItem.Name = "miniMarketToolStripMenuItem";
            resources.ApplyResources(this.miniMarketToolStripMenuItem, "miniMarketToolStripMenuItem");
            this.miniMarketToolStripMenuItem.Click += new System.EventHandler(this.miniMarketToolStripMenuItem_Click);
            // 
            // proveToolStripMenuItem
            // 
            this.proveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem});
            this.proveToolStripMenuItem.Name = "proveToolStripMenuItem";
            resources.ApplyResources(this.proveToolStripMenuItem, "proveToolStripMenuItem");
            // 
            // rEGISTRARToolStripMenuItem
            // 
            this.rEGISTRARToolStripMenuItem.Name = "rEGISTRARToolStripMenuItem";
            resources.ApplyResources(this.rEGISTRARToolStripMenuItem, "rEGISTRARToolStripMenuItem");
            this.rEGISTRARToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRARToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            resources.ApplyResources(this.cONSULTARToolStripMenuItem, "cONSULTARToolStripMenuItem");
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARToolStripMenuItem1,
            this.cONSULTARToolStripMenuItem1});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            // 
            // rEGISTRARToolStripMenuItem1
            // 
            this.rEGISTRARToolStripMenuItem1.Name = "rEGISTRARToolStripMenuItem1";
            resources.ApplyResources(this.rEGISTRARToolStripMenuItem1, "rEGISTRARToolStripMenuItem1");
            this.rEGISTRARToolStripMenuItem1.Click += new System.EventHandler(this.rEGISTRARToolStripMenuItem1_Click);
            // 
            // cONSULTARToolStripMenuItem1
            // 
            this.cONSULTARToolStripMenuItem1.Name = "cONSULTARToolStripMenuItem1";
            resources.ApplyResources(this.cONSULTARToolStripMenuItem1, "cONSULTARToolStripMenuItem1");
            this.cONSULTARToolStripMenuItem1.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.cONSULTARToolStripMenuItem2});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            resources.ApplyResources(this.categoriaToolStripMenuItem, "categoriaToolStripMenuItem");
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            resources.ApplyResources(this.registrarToolStripMenuItem2, "registrarToolStripMenuItem2");
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // cONSULTARToolStripMenuItem2
            // 
            this.cONSULTARToolStripMenuItem2.Name = "cONSULTARToolStripMenuItem2";
            resources.ApplyResources(this.cONSULTARToolStripMenuItem2, "cONSULTARToolStripMenuItem2");
            this.cONSULTARToolStripMenuItem2.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miniMarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem2;
    }
}

