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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.AutoSize = true;
            this.gbVenta.Controls.Add(this.lblTotal);
            this.gbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenta.Location = new System.Drawing.Point(543, 461);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(168, 86);
            this.gbVenta.TabIndex = 6;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Total venta";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(6, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 48);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$0";
            // 
            // btnVenta
            // 
            this.btnVenta.Enabled = false;
            this.btnVenta.Location = new System.Drawing.Point(599, 553);
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
            this.lblVenta.Size = new System.Drawing.Size(143, 25);
            this.lblVenta.TabIndex = 7;
            this.lblVenta.Text = "Realizar venta";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(34, 125);
            this.txtIDVenta.MaxLength = 13;
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIDVenta.TabIndex = 8;
            this.txtIDVenta.TextChanged += new System.EventHandler(this.txtIDVenta_TextChanged);
            this.txtIDVenta.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtIDVenta_PreviewKeyDown);
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
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE_PRODUCTO,
            this.CANTIDAD,
            this.PRECIO_UNITARIO,
            this.TOTAL});
            this.dgVenta.Location = new System.Drawing.Point(12, 151);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            this.dgVenta.Size = new System.Drawing.Size(699, 298);
            this.dgVenta.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 13;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOMBRE_PRODUCTO
            // 
            this.NOMBRE_PRODUCTO.HeaderText = "Nombre del producto";
            this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
            this.NOMBRE_PRODUCTO.ReadOnly = true;
            this.NOMBRE_PRODUCTO.Width = 300;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "Cantidad";
            this.CANTIDAD.MaxInputLength = 9;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 55;
            // 
            // PRECIO_UNITARIO
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.PRECIO_UNITARIO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECIO_UNITARIO.HeaderText = "Precio unitario";
            this.PRECIO_UNITARIO.MaxInputLength = 9;
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "Precio total";
            this.TOTAL.MaxInputLength = 9;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // frmVentas
            // 
            this.AcceptButton = this.btnVenta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1109, 610);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.btnVenta);
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
            this.Controls.SetChildIndex(this.btnVenta, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}
