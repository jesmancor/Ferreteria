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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOMENUDEODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOMAYOREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCUENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXISTENCIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mINIMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXIMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEORDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTACIONALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORTRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSet = new Ferreteria.ferreteriaDataSet();
            this.gbEditarNuevo = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pRODUCTOSTableAdapter = new Ferreteria.ferreteriaDataSetTableAdapters.PRODUCTOSTableAdapter();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.epID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMenudeo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMayoreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExistencias = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            this.gbEditarNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMenudeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExistencias)).BeginInit();
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
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn,
            this.tIPOPRODUCTODataGridViewTextBoxColumn,
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn,
            this.pRECIOMENUDEODataGridViewTextBoxColumn,
            this.pRECIOMAYOREODataGridViewTextBoxColumn,
            this.dESCUENTODataGridViewTextBoxColumn,
            this.eXISTENCIASDataGridViewTextBoxColumn,
            this.mINIMODataGridViewTextBoxColumn,
            this.mAXIMODataGridViewTextBoxColumn,
            this.rEORDENDataGridViewTextBoxColumn,
            this.pEDIDODataGridViewTextBoxColumn,
            this.eSTACIONALIDADDataGridViewTextBoxColumn,
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn,
            this.pROVEEDORDOSDataGridViewTextBoxColumn,
            this.pROVEEDORTRESDataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.pRODUCTOSBindingSource;
            this.dgProductos.Location = new System.Drawing.Point(17, 136);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(1335, 262);
            this.dgProductos.TabIndex = 1;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // iDPRODUCTODataGridViewTextBoxColumn
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPRODUCTODataGridViewTextBoxColumn.Name = "iDPRODUCTODataGridViewTextBoxColumn";
            this.iDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREPRODUCTODataGridViewTextBoxColumn
            // 
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Name = "nOMBREPRODUCTODataGridViewTextBoxColumn";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOPRODUCTODataGridViewTextBoxColumn
            // 
            this.tIPOPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_PRODUCTO";
            this.tIPOPRODUCTODataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPRODUCTODataGridViewTextBoxColumn.Name = "tIPOPRODUCTODataGridViewTextBoxColumn";
            this.tIPOPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn
            // 
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCIÓN_PRODUCTO";
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn.Name = "dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn";
            this.dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIOMENUDEODataGridViewTextBoxColumn
            // 
            this.pRECIOMENUDEODataGridViewTextBoxColumn.DataPropertyName = "PRECIO_MENUDEO";
            this.pRECIOMENUDEODataGridViewTextBoxColumn.HeaderText = "Precio de menudeo";
            this.pRECIOMENUDEODataGridViewTextBoxColumn.Name = "pRECIOMENUDEODataGridViewTextBoxColumn";
            this.pRECIOMENUDEODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIOMAYOREODataGridViewTextBoxColumn
            // 
            this.pRECIOMAYOREODataGridViewTextBoxColumn.DataPropertyName = "PRECIO_MAYOREO";
            this.pRECIOMAYOREODataGridViewTextBoxColumn.HeaderText = "Precio de mayoreo";
            this.pRECIOMAYOREODataGridViewTextBoxColumn.Name = "pRECIOMAYOREODataGridViewTextBoxColumn";
            this.pRECIOMAYOREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCUENTODataGridViewTextBoxColumn
            // 
            this.dESCUENTODataGridViewTextBoxColumn.DataPropertyName = "DESCUENTO";
            this.dESCUENTODataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.dESCUENTODataGridViewTextBoxColumn.Name = "dESCUENTODataGridViewTextBoxColumn";
            this.dESCUENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXISTENCIASDataGridViewTextBoxColumn
            // 
            this.eXISTENCIASDataGridViewTextBoxColumn.DataPropertyName = "EXISTENCIAS";
            this.eXISTENCIASDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.eXISTENCIASDataGridViewTextBoxColumn.Name = "eXISTENCIASDataGridViewTextBoxColumn";
            this.eXISTENCIASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mINIMODataGridViewTextBoxColumn
            // 
            this.mINIMODataGridViewTextBoxColumn.DataPropertyName = "MINIMO";
            this.mINIMODataGridViewTextBoxColumn.HeaderText = "Mínimo";
            this.mINIMODataGridViewTextBoxColumn.Name = "mINIMODataGridViewTextBoxColumn";
            this.mINIMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAXIMODataGridViewTextBoxColumn
            // 
            this.mAXIMODataGridViewTextBoxColumn.DataPropertyName = "MAXIMO";
            this.mAXIMODataGridViewTextBoxColumn.HeaderText = "Máximo";
            this.mAXIMODataGridViewTextBoxColumn.Name = "mAXIMODataGridViewTextBoxColumn";
            this.mAXIMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEORDENDataGridViewTextBoxColumn
            // 
            this.rEORDENDataGridViewTextBoxColumn.DataPropertyName = "REORDEN";
            this.rEORDENDataGridViewTextBoxColumn.HeaderText = "Reorden";
            this.rEORDENDataGridViewTextBoxColumn.Name = "rEORDENDataGridViewTextBoxColumn";
            this.rEORDENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDIDODataGridViewTextBoxColumn
            // 
            this.pEDIDODataGridViewTextBoxColumn.DataPropertyName = "PEDIDO";
            this.pEDIDODataGridViewTextBoxColumn.HeaderText = "Pedido";
            this.pEDIDODataGridViewTextBoxColumn.Name = "pEDIDODataGridViewTextBoxColumn";
            this.pEDIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTACIONALIDADDataGridViewTextBoxColumn
            // 
            this.eSTACIONALIDADDataGridViewTextBoxColumn.DataPropertyName = "ESTACIONALIDAD";
            this.eSTACIONALIDADDataGridViewTextBoxColumn.HeaderText = "Estacionalidad";
            this.eSTACIONALIDADDataGridViewTextBoxColumn.Name = "eSTACIONALIDADDataGridViewTextBoxColumn";
            this.eSTACIONALIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROVEEDORASIGNADODataGridViewTextBoxColumn
            // 
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn.DataPropertyName = "PROVEEDOR_ASIGNADO";
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn.HeaderText = "Proveedor asignado";
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn.Name = "pROVEEDORASIGNADODataGridViewTextBoxColumn";
            this.pROVEEDORASIGNADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROVEEDORDOSDataGridViewTextBoxColumn
            // 
            this.pROVEEDORDOSDataGridViewTextBoxColumn.DataPropertyName = "PROVEEDOR_DOS";
            this.pROVEEDORDOSDataGridViewTextBoxColumn.HeaderText = "Proveedor 2";
            this.pROVEEDORDOSDataGridViewTextBoxColumn.Name = "pROVEEDORDOSDataGridViewTextBoxColumn";
            this.pROVEEDORDOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROVEEDORTRESDataGridViewTextBoxColumn
            // 
            this.pROVEEDORTRESDataGridViewTextBoxColumn.DataPropertyName = "PROVEEDOR_TRES";
            this.pROVEEDORTRESDataGridViewTextBoxColumn.HeaderText = "Proveedor 3";
            this.pROVEEDORTRESDataGridViewTextBoxColumn.Name = "pROVEEDORTRESDataGridViewTextBoxColumn";
            this.pROVEEDORTRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.ferreteriaDataSet;
            // 
            // ferreteriaDataSet
            // 
            this.ferreteriaDataSet.DataSetName = "ferreteriaDataSet";
            this.ferreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbEditarNuevo
            // 
            this.gbEditarNuevo.Controls.Add(this.btnCancelar);
            this.gbEditarNuevo.Controls.Add(this.btnAceptar);
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
            this.gbEditarNuevo.Location = new System.Drawing.Point(15, 450);
            this.gbEditarNuevo.Name = "gbEditarNuevo";
            this.gbEditarNuevo.Size = new System.Drawing.Size(589, 172);
            this.gbEditarNuevo.TabIndex = 5;
            this.gbEditarNuevo.TabStop = false;
            this.gbEditarNuevo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(478, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(397, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(412, 69);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(60, 13);
            this.lblExistencias.TabIndex = 13;
            this.lblExistencias.Text = "Existencias";
            // 
            // lblMayoreo
            // 
            this.lblMayoreo.AutoSize = true;
            this.lblMayoreo.Location = new System.Drawing.Point(392, 43);
            this.lblMayoreo.Name = "lblMayoreo";
            this.lblMayoreo.Size = new System.Drawing.Size(80, 13);
            this.lblMayoreo.TabIndex = 12;
            this.lblMayoreo.Text = "Precio mayoreo";
            // 
            // lblMenudeo
            // 
            this.lblMenudeo.AutoSize = true;
            this.lblMenudeo.Location = new System.Drawing.Point(393, 17);
            this.lblMenudeo.Name = "lblMenudeo";
            this.lblMenudeo.Size = new System.Drawing.Size(84, 13);
            this.lblMenudeo.TabIndex = 11;
            this.lblMenudeo.Text = "Precio menudeo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(88, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo de producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(78, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(478, 66);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(63, 20);
            this.txtExistencias.TabIndex = 6;
            // 
            // txtMayoreo
            // 
            this.txtMayoreo.Location = new System.Drawing.Point(478, 40);
            this.txtMayoreo.Name = "txtMayoreo";
            this.txtMayoreo.Size = new System.Drawing.Size(63, 20);
            this.txtMayoreo.TabIndex = 5;
            // 
            // txtMenudeo
            // 
            this.txtMenudeo.Location = new System.Drawing.Point(478, 14);
            this.txtMenudeo.Name = "txtMenudeo";
            this.txtMenudeo.Size = new System.Drawing.Size(63, 20);
            this.txtMenudeo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(102, 97);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 57);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(102, 70);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(252, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(102, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(102, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(134, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(276, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 113);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(118, 13);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar por descripción:";
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(97, 418);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 418);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(179, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // epID
            // 
            this.epID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epID.ContainerControl = this;
            this.epID.Icon = ((System.Drawing.Icon)(resources.GetObject("epID.Icon")));
            // 
            // epNombre
            // 
            this.epNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNombre.ContainerControl = this;
            this.epNombre.Icon = ((System.Drawing.Icon)(resources.GetObject("epNombre.Icon")));
            // 
            // epTipo
            // 
            this.epTipo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epTipo.ContainerControl = this;
            this.epTipo.Icon = ((System.Drawing.Icon)(resources.GetObject("epTipo.Icon")));
            // 
            // epDescripcion
            // 
            this.epDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDescripcion.ContainerControl = this;
            this.epDescripcion.Icon = ((System.Drawing.Icon)(resources.GetObject("epDescripcion.Icon")));
            // 
            // epMenudeo
            // 
            this.epMenudeo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epMenudeo.ContainerControl = this;
            this.epMenudeo.Icon = ((System.Drawing.Icon)(resources.GetObject("epMenudeo.Icon")));
            // 
            // epMayoreo
            // 
            this.epMayoreo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epMayoreo.ContainerControl = this;
            this.epMayoreo.Icon = ((System.Drawing.Icon)(resources.GetObject("epMayoreo.Icon")));
            // 
            // epExistencias
            // 
            this.epExistencias.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epExistencias.ContainerControl = this;
            this.epExistencias.Icon = ((System.Drawing.Icon)(resources.GetObject("epExistencias.Icon")));
            // 
            // frmProductos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1362, 646);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gbEditarNuevo);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lblProductos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.Controls.SetChildIndex(this.dgProductos, 0);
            this.Controls.SetChildIndex(this.gbEditarNuevo, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            this.gbEditarNuevo.ResumeLayout(false);
            this.gbEditarNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMenudeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.GroupBox gbEditarNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private ferreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private ferreteriaDataSetTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIÓNPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOMENUDEODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOMAYOREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCUENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXISTENCIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEORDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTACIONALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVEEDORASIGNADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVEEDORDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVEEDORTRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider epID;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epTipo;
        private System.Windows.Forms.ErrorProvider epDescripcion;
        private System.Windows.Forms.ErrorProvider epMenudeo;
        private System.Windows.Forms.ErrorProvider epMayoreo;
        private System.Windows.Forms.ErrorProvider epExistencias;
    }
}
