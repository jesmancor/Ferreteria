namespace Ferreteria
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hacerVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(102, 39);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 15);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "lblHora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "lblFecha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerVentaToolStripMenuItem,
            this.cToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hacerVentaToolStripMenuItem
            // 
            this.hacerVentaToolStripMenuItem.Name = "hacerVentaToolStripMenuItem";
            this.hacerVentaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.hacerVentaToolStripMenuItem.Text = "Hacer venta";
            this.hacerVentaToolStripMenuItem.Click += new System.EventHandler(this.hacerVentaToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cToolStripMenuItem.Text = "Catálogo";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar caja";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMenu";
            this.Text = "Ferretería y tlapalería \"Los Jilgueros\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hacerVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}