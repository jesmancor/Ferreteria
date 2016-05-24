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
            this.txtMenudeo = new Ferreteria.Herramientas.doble();
            this.txtID = new Ferreteria.Herramientas.controlProducto();
            this.lblMayoreo = new System.Windows.Forms.Label();
            this.lblMenudeo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMayoreo = new Ferreteria.Herramientas.doble();
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
            this.gbEditarNuevo.Controls.Add(this.txtMayoreo);
            this.gbEditarNuevo.Controls.Add(this.txtMenudeo);
            this.gbEditarNuevo.Controls.Add(this.txtID);
            this.gbEditarNuevo.Controls.Add(this.lblMayoreo);
            this.gbEditarNuevo.Controls.Add(this.lblMenudeo);
            this.gbEditarNuevo.Controls.Add(this.lblDescripcion);
            this.gbEditarNuevo.Controls.Add(this.lblTipo);
            this.gbEditarNuevo.Controls.Add(this.lblNombre);
            this.gbEditarNuevo.Controls.Add(this.lblID);
            this.gbEditarNuevo.Controls.Add(this.txtDescripcion);
            this.gbEditarNuevo.Controls.Add(this.txtTipo);
            this.gbEditarNuevo.Controls.Add(this.txtNombre);
            this.gbEditarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditarNuevo.Location = new System.Drawing.Point(17, 109);
            this.gbEditarNuevo.Name = "gbEditarNuevo";
            this.gbEditarNuevo.Size = new System.Drawing.Size(1046, 126);
            this.gbEditarNuevo.TabIndex = 5;
            this.gbEditarNuevo.TabStop = false;
            // 
            // txtMenudeo
            // 
            this.txtMenudeo.Location = new System.Drawing.Point(972, 18);
            this.txtMenudeo.Name = "txtMenudeo";
            this.txtMenudeo.Size = new System.Drawing.Size(49, 20);
            this.txtMenudeo.TabIndex = 4;
            this.txtMenudeo.Validating += new System.ComponentModel.CancelEventHandler(this.txtMenudeo_Validating);
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtID.Location = new System.Drawing.Point(102, 18);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 0;
            this.txtID.GotFocus += new System.EventHandler(this.txtID_GotFocus);
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
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
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(508, 18);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 88);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(102, 86);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(252, 20);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipo_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(102, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(17, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(98, 241);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(179, 241);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMayoreo
            // 
            this.txtMayoreo.Location = new System.Drawing.Point(972, 44);
            this.txtMayoreo.Name = "txtMayoreo";
            this.txtMayoreo.Size = new System.Drawing.Size(49, 20);
            this.txtMayoreo.TabIndex = 5;
            this.txtMayoreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtMayoreo_Validating);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1354, 646);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbEditarNuevo);
            this.Controls.Add(this.lblProductos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.Controls.SetChildIndex(this.gbEditarNuevo, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.gbEditarNuevo.ResumeLayout(false);
            this.gbEditarNuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox gbEditarNuevo;
        private System.Windows.Forms.Label lblMayoreo;
        private System.Windows.Forms.Label lblMenudeo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private Herramientas.controlProducto txtID;
        private Herramientas.doble txtMenudeo;
        private Herramientas.doble txtMayoreo;
    }
}
