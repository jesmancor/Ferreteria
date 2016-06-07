namespace Ferreteria
{
    partial class frmProvProd
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
            this.txtProducto = new Ferreteria.Herramientas.controlProducto();
            this.txtProveedor = new Ferreteria.Herramientas.controlProveedor();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new Ferreteria.Herramientas.moneda();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(92, 129);
            this.txtProducto.MaxLength = 13;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(150, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(92, 93);
            this.txtProveedor.MaxLength = 3;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(32, 20);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.GotFocus += new System.EventHandler(this.txtProveedor_GotFocus);
            this.txtProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.txtProveedor_Validating);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(37, 136);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Producto";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(31, 100);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 9;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Enabled = false;
            this.txtProveedorNombre.Location = new System.Drawing.Point(130, 93);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(301, 20);
            this.txtProveedorNombre.TabIndex = 10;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Enabled = false;
            this.txtProductoNombre.Location = new System.Drawing.Point(248, 129);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(287, 20);
            this.txtProductoNombre.TabIndex = 11;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROV,
            this.PROD,
            this.PRECIO});
            this.dgvProductos.Location = new System.Drawing.Point(92, 238);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(570, 200);
            this.dgvProductos.TabIndex = 4;
            // 
            // PROV
            // 
            this.PROV.HeaderText = "Proveedor";
            this.PROV.Name = "PROV";
            // 
            // PROD
            // 
            this.PROD.HeaderText = "Producto";
            this.PROD.Name = "PROD";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.Name = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(92, 164);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(-3, 167);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(90, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio de compra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmProvProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 485);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtProductoNombre);
            this.Controls.Add(this.txtProveedorNombre);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtProducto);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProvProd";
            this.Controls.SetChildIndex(this.txtProducto, 0);
            this.Controls.SetChildIndex(this.txtProveedor, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.txtProveedorNombre, 0);
            this.Controls.SetChildIndex(this.txtProductoNombre, 0);
            this.Controls.SetChildIndex(this.dgvProductos, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Herramientas.controlProducto txtProducto;
        private Herramientas.controlProveedor txtProveedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private Herramientas.moneda txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
    }
}
