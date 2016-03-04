namespace Ferreteria
{
    partial class frmProductos
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.gbEditarNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtReorden = new System.Windows.Forms.TextBox();
            this.lblReorden = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDecuento = new System.Windows.Forms.Label();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblMayoreo = new System.Windows.Forms.Label();
            this.lblMenudeo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtMayoreo = new System.Windows.Forms.TextBox();
            this.txtMenudeo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbEditarNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(12, 65);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(104, 25);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Productos";
            // 
            // gbEditarNuevo
            // 
            this.gbEditarNuevo.Controls.Add(this.txtReorden);
            this.gbEditarNuevo.Controls.Add(this.lblReorden);
            this.gbEditarNuevo.Controls.Add(this.txtMaximo);
            this.gbEditarNuevo.Controls.Add(this.lblMaximo);
            this.gbEditarNuevo.Controls.Add(this.lblMinimo);
            this.gbEditarNuevo.Controls.Add(this.txtMinimo);
            this.gbEditarNuevo.Controls.Add(this.txtDescuento);
            this.gbEditarNuevo.Controls.Add(this.lblDecuento);
            this.gbEditarNuevo.Controls.Add(this.lblExistencias);
            this.gbEditarNuevo.Controls.Add(this.lblMayoreo);
            this.gbEditarNuevo.Controls.Add(this.lblMenudeo);
            this.gbEditarNuevo.Controls.Add(this.lblDescripcion);
            this.gbEditarNuevo.Controls.Add(this.lblTipo);
            this.gbEditarNuevo.Controls.Add(this.lblNombre);
            this.gbEditarNuevo.Controls.Add(this.lblID);
            this.gbEditarNuevo.Controls.Add(this.txtExistencias);
            this.gbEditarNuevo.Controls.Add(this.txtMayoreo);
            this.gbEditarNuevo.Controls.Add(this.txtMenudeo);
            this.gbEditarNuevo.Controls.Add(this.txtDescripcion);
            this.gbEditarNuevo.Controls.Add(this.txtTipo);
            this.gbEditarNuevo.Controls.Add(this.txtNombre);
            this.gbEditarNuevo.Controls.Add(this.txtID);
            this.gbEditarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditarNuevo.Location = new System.Drawing.Point(17, 109);
            this.gbEditarNuevo.Name = "gbEditarNuevo";
            this.gbEditarNuevo.Size = new System.Drawing.Size(1301, 126);
            this.gbEditarNuevo.TabIndex = 5;
            this.gbEditarNuevo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtReorden
            // 
            this.txtReorden.Location = new System.Drawing.Point(1214, 70);
            this.txtReorden.Name = "txtReorden";
            this.txtReorden.Size = new System.Drawing.Size(49, 20);
            this.txtReorden.TabIndex = 10;
            // 
            // lblReorden
            // 
            this.lblReorden.AutoSize = true;
            this.lblReorden.Location = new System.Drawing.Point(1115, 77);
            this.lblReorden.Name = "lblReorden";
            this.lblReorden.Size = new System.Drawing.Size(95, 13);
            this.lblReorden.TabIndex = 20;
            this.lblReorden.Text = "Punto de reorden :";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(1214, 44);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(49, 20);
            this.txtMaximo.TabIndex = 9;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(1115, 51);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(49, 13);
            this.lblMaximo.TabIndex = 18;
            this.lblMaximo.Text = "Máximo :";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(1115, 25);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(48, 13);
            this.lblMinimo.TabIndex = 17;
            this.lblMinimo.Text = "Mínimo :";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(1214, 18);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(49, 20);
            this.txtMinimo.TabIndex = 8;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(972, 70);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(49, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // lblDecuento
            // 
            this.lblDecuento.AutoSize = true;
            this.lblDecuento.Location = new System.Drawing.Point(873, 77);
            this.lblDecuento.Name = "lblDecuento";
            this.lblDecuento.Size = new System.Drawing.Size(65, 13);
            this.lblDecuento.TabIndex = 14;
            this.lblDecuento.Text = "Descuento :";
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(873, 103);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(66, 13);
            this.lblExistencias.TabIndex = 13;
            this.lblExistencias.Text = "Existencias :";
            // 
            // lblMayoreo
            // 
            this.lblMayoreo.AutoSize = true;
            this.lblMayoreo.Location = new System.Drawing.Point(873, 51);
            this.lblMayoreo.Name = "lblMayoreo";
            this.lblMayoreo.Size = new System.Drawing.Size(98, 13);
            this.lblMayoreo.TabIndex = 12;
            this.lblMayoreo.Text = "Precio mayoreo :  $";
            // 
            // lblMenudeo
            // 
            this.lblMenudeo.AutoSize = true;
            this.lblMenudeo.Location = new System.Drawing.Point(873, 25);
            this.lblMenudeo.Name = "lblMenudeo";
            this.lblMenudeo.Size = new System.Drawing.Size(99, 13);
            this.lblMenudeo.TabIndex = 11;
            this.lblMenudeo.Text = "Precio menudeo : $";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(433, 93);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 93);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(94, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo de producto :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID :";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(972, 96);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(49, 20);
            this.txtExistencias.TabIndex = 7;
            this.txtExistencias.TextChanged += new System.EventHandler(this.txtExistencias_TextChanged);
            // 
            // txtMayoreo
            // 
            this.txtMayoreo.Location = new System.Drawing.Point(972, 44);
            this.txtMayoreo.Name = "txtMayoreo";
            this.txtMayoreo.Size = new System.Drawing.Size(49, 20);
            this.txtMayoreo.TabIndex = 5;
            this.txtMayoreo.TextChanged += new System.EventHandler(this.txtMayoreo_TextChanged);
            // 
            // txtMenudeo
            // 
            this.txtMenudeo.Location = new System.Drawing.Point(972, 18);
            this.txtMenudeo.Name = "txtMenudeo";
            this.txtMenudeo.Size = new System.Drawing.Size(49, 20);
            this.txtMenudeo.TabIndex = 4;
            this.txtMenudeo.TextChanged += new System.EventHandler(this.txtMenudeo_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(508, 18);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 88);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(102, 86);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(252, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(102, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtID.Location = new System.Drawing.Point(102, 18);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1355, 646);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbEditarNuevo);
            this.Controls.Add(this.lblProductos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.Controls.SetChildIndex(this.gbEditarNuevo, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.gbEditarNuevo.ResumeLayout(false);
            this.gbEditarNuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox gbEditarNuevo;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblMayoreo;
        private System.Windows.Forms.Label lblMenudeo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtMayoreo;
        private System.Windows.Forms.TextBox txtMenudeo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDecuento;
        private System.Windows.Forms.TextBox txtReorden;
        private System.Windows.Forms.Label lblReorden;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Button btnAgregar;
    }
}
