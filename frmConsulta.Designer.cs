namespace Ferreteria
{
    partial class frmConsulta
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_MENUDEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_MAYOREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(544, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.NOMBRE_PRODUCTO,
            this.DESCRIPCION_PRODUCTO,
            this.PRECIO_MENUDEO,
            this.PRECIO_MAYOREO});
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 89);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(544, 276);
            this.dgvBusqueda.TabIndex = 1;
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentClick);
            this.dgvBusqueda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvBusqueda_PreviewKeyDown);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.ReadOnly = true;
            // 
            // NOMBRE_PRODUCTO
            // 
            this.NOMBRE_PRODUCTO.HeaderText = "Nombre";
            this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
            this.NOMBRE_PRODUCTO.ReadOnly = true;
            // 
            // DESCRIPCION_PRODUCTO
            // 
            this.DESCRIPCION_PRODUCTO.HeaderText = "Descripción";
            this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
            this.DESCRIPCION_PRODUCTO.ReadOnly = true;
            // 
            // PRECIO_MENUDEO
            // 
            this.PRECIO_MENUDEO.HeaderText = "Precio de menudeo";
            this.PRECIO_MENUDEO.Name = "PRECIO_MENUDEO";
            this.PRECIO_MENUDEO.ReadOnly = true;
            // 
            // PRECIO_MAYOREO
            // 
            this.PRECIO_MAYOREO.HeaderText = "Precio de mayoreo";
            this.PRECIO_MAYOREO.Name = "PRECIO_MAYOREO";
            this.PRECIO_MAYOREO.ReadOnly = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(9, 18);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(124, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Búsqueda por producto :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(481, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsulta
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(572, 401);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsulta";
            this.Text = "Consulta de producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_MENUDEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_MAYOREO;
        private System.Windows.Forms.Button btnCancelar;
    }
}