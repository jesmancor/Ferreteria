namespace Ferreteria
{
    partial class frmExistencias
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
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblActuales = new System.Windows.Forms.Label();
            this.txtActuales = new System.Windows.Forms.TextBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtNuevas = new System.Windows.Forms.TextBox();
            this.lblNuevas = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.NumericUpDown();
            this.txtReorden = new System.Windows.Forms.NumericUpDown();
            this.txtMaximo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReorden = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.NumericUpDown();
            this.lblProductos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(13, 34);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 31);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.GotFocus += new System.EventHandler(this.txtID_GotFocus);
            this.txtID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtID_PreviewKeyDown);
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            // 
            // lblActuales
            // 
            this.lblActuales.AutoSize = true;
            this.lblActuales.Location = new System.Drawing.Point(13, 98);
            this.lblActuales.Name = "lblActuales";
            this.lblActuales.Size = new System.Drawing.Size(109, 13);
            this.lblActuales.TabIndex = 8;
            this.lblActuales.Text = "Existencias actuales :";
            // 
            // txtActuales
            // 
            this.txtActuales.Enabled = false;
            this.txtActuales.Location = new System.Drawing.Point(138, 91);
            this.txtActuales.Name = "txtActuales";
            this.txtActuales.Size = new System.Drawing.Size(55, 20);
            this.txtActuales.TabIndex = 1;
            this.txtActuales.Text = "0";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(13, 174);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(114, 13);
            this.lblAgregar.TabIndex = 10;
            this.lblAgregar.Text = "Existencias a agregar :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(15, 419);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblUnitario);
            this.groupBox1.Controls.Add(this.txtUnitario);
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.txtProveedorNombre);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.txtNuevas);
            this.groupBox1.Controls.Add(this.lblNuevas);
            this.groupBox1.Controls.Add(this.txtMinimo);
            this.groupBox1.Controls.Add(this.txtReorden);
            this.groupBox1.Controls.Add(this.txtMaximo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblReorden);
            this.groupBox1.Controls.Add(this.lblMaximo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtAgregar);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lblAgregar);
            this.groupBox1.Controls.Add(this.lblActuales);
            this.groupBox1.Controls.Add(this.txtActuales);
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 287);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(226, 234);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 13);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Precio total de la compra :";
            // 
            // lblUnitario
            // 
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.Location = new System.Drawing.Point(45, 234);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(80, 13);
            this.lblUnitario.TabIndex = 24;
            this.lblUnitario.Text = "Precio unitario :";
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(138, 231);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(82, 20);
            this.txtUnitario.TabIndex = 23;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(63, 208);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(62, 13);
            this.lblProveedor.TabIndex = 22;
            this.lblProveedor.Text = "Proveedor :";
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Enabled = false;
            this.txtProveedorNombre.Location = new System.Drawing.Point(226, 205);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(236, 20);
            this.txtProveedorNombre.TabIndex = 21;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(138, 205);
            this.txtProveedor.MaxLength = 10;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(82, 20);
            this.txtProveedor.TabIndex = 20;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtProveedor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtProveedor_PreviewKeyDown);
            this.txtProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.txtProveedor_Validating);
            // 
            // txtNuevas
            // 
            this.txtNuevas.Enabled = false;
            this.txtNuevas.Location = new System.Drawing.Point(328, 171);
            this.txtNuevas.Name = "txtNuevas";
            this.txtNuevas.Size = new System.Drawing.Size(54, 20);
            this.txtNuevas.TabIndex = 4;
            this.txtNuevas.Text = "1";
            // 
            // lblNuevas
            // 
            this.lblNuevas.AutoSize = true;
            this.lblNuevas.Location = new System.Drawing.Point(217, 174);
            this.lblNuevas.Name = "lblNuevas";
            this.lblNuevas.Size = new System.Drawing.Size(105, 13);
            this.lblNuevas.TabIndex = 19;
            this.lblNuevas.Text = "Nuevas existencias :";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(327, 130);
            this.txtMinimo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMinimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(55, 20);
            this.txtMinimo.TabIndex = 2;
            this.txtMinimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinimo.ValueChanged += new System.EventHandler(this.txtMinimo_ValueChanged);
            // 
            // txtReorden
            // 
            this.txtReorden.Location = new System.Drawing.Point(137, 131);
            this.txtReorden.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtReorden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtReorden.Name = "txtReorden";
            this.txtReorden.Size = new System.Drawing.Size(55, 20);
            this.txtReorden.TabIndex = 2;
            this.txtReorden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtReorden.ValueChanged += new System.EventHandler(this.txtMinimo_ValueChanged);
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(327, 92);
            this.txtMaximo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMaximo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(55, 20);
            this.txtMaximo.TabIndex = 1;
            this.txtMaximo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaximo.ValueChanged += new System.EventHandler(this.txtMaximo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mínimo :";
            // 
            // lblReorden
            // 
            this.lblReorden.AutoSize = true;
            this.lblReorden.Location = new System.Drawing.Point(36, 137);
            this.lblReorden.Name = "lblReorden";
            this.lblReorden.Size = new System.Drawing.Size(95, 13);
            this.lblReorden.TabIndex = 15;
            this.lblReorden.Text = "Punto de reorden :";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(272, 98);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(49, 13);
            this.lblMaximo.TabIndex = 13;
            this.lblMaximo.Text = "Máximo :";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(138, 60);
            this.txtNombre.MaxLength = 13;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre del producto :";
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(138, 167);
            this.txtAgregar.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtAgregar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(55, 20);
            this.txtAgregar.TabIndex = 3;
            this.txtAgregar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAgregar.ValueChanged += new System.EventHandler(this.txtAgregar_ValueChanged);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(10, 75);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(194, 25);
            this.lblProductos.TabIndex = 14;
            this.lblProductos.Text = "Agregar existencias";
            // 
            // frmExistencias
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 498);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmExistencias";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblActuales;
        private System.Windows.Forms.TextBox txtActuales;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblReorden;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.NumericUpDown txtReorden;
        private System.Windows.Forms.NumericUpDown txtMaximo;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TextBox txtNuevas;
        private System.Windows.Forms.Label lblNuevas;
        private System.Windows.Forms.NumericUpDown txtMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.TextBox txtProveedor;
    }
}
