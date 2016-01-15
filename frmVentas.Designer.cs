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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.AutoSize = true;
            this.gbVenta.Controls.Add(this.lblTotal);
            this.gbVenta.Controls.Add(this.btnVenta);
            this.gbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenta.Location = new System.Drawing.Point(15, 211);
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
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(10, 67);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(124, 25);
            this.lblVenta.TabIndex = 7;
            this.lblVenta.Text = "Hacer venta";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(34, 125);
            this.txtIDVenta.MaxLength = 12;
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIDVenta.TabIndex = 8;
            this.txtIDVenta.TextChanged += new System.EventHandler(this.txtIDVenta_TextChanged);
            // 
            // lblIDVenta
            // 
            this.lblIDVenta.AutoSize = true;
            this.lblIDVenta.Location = new System.Drawing.Point(12, 128);
            this.lblIDVenta.Name = "lblIDVenta";
            this.lblIDVenta.Size = new System.Drawing.Size(18, 13);
            this.lblIDVenta.TabIndex = 9;
            this.lblIDVenta.Text = "ID";
            // 
            // dgVenta
            // 
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_PRODUCTO,
            this.PRECIO,
            this.CANTIDAD});
            this.dgVenta.Location = new System.Drawing.Point(291, 67);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.Size = new System.Drawing.Size(386, 298);
            this.dgVenta.TabIndex = 10;
            // 
            // NOMBRE_PRODUCTO
            // 
            this.NOMBRE_PRODUCTO.HeaderText = "Nombre del producto";
            this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
            // 
            // PRECIO
            // 
            dataGridViewCellStyle1.Format = "$0.00";
            dataGridViewCellStyle1.NullValue = null;
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.Name = "PRECIO";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "Cantidad";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.lblIDVenta);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.gbVenta);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmVentas";
            this.Controls.SetChildIndex(this.gbVenta, 0);
            this.Controls.SetChildIndex(this.lblVenta, 0);
            this.Controls.SetChildIndex(this.txtIDVenta, 0);
            this.Controls.SetChildIndex(this.lblIDVenta, 0);
            this.Controls.SetChildIndex(this.dgVenta, 0);
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    }
}
