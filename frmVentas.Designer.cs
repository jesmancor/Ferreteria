namespace Ferreteria
{
    partial class frmVentas
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
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.gbVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.AutoSize = true;
            this.gbVenta.Controls.Add(this.lblTotal);
            this.gbVenta.Controls.Add(this.btnVenta);
            this.gbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenta.Location = new System.Drawing.Point(15, 152);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(217, 137);
            this.gbVenta.TabIndex = 6;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Total venta";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(53, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 48);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnVenta
            // 
            this.btnVenta.Enabled = false;
            this.btnVenta.Location = new System.Drawing.Point(50, 83);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(112, 32);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Realizar venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(10, 67);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(66, 25);
            this.lblVenta.TabIndex = 7;
            this.lblVenta.Text = "Venta";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.gbVenta);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmVentas";
            this.Controls.SetChildIndex(this.gbVenta, 0);
            this.Controls.SetChildIndex(this.lblVenta, 0);
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblVenta;
    }
}
