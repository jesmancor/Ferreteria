namespace Ferreteria
{
    partial class frmReporteVentas
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
            this.lblReporteVentas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReporteVentas
            // 
            this.lblReporteVentas.AutoSize = true;
            this.lblReporteVentas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteVentas.Location = new System.Drawing.Point(10, 72);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(182, 25);
            this.lblReporteVentas.TabIndex = 7;
            this.lblReporteVentas.Text = "Reporte de ventas";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.lblReporteVentas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmReporteVentas";
            this.Controls.SetChildIndex(this.lblReporteVentas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReporteVentas;
    }
}
