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
            this.components = new System.ComponentModel.Container();
            this.lblReporteVentas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSetVentas = new Ferreteria.ferreteriaDataSetVentas();
            this.ventasTableAdapter = new Ferreteria.ferreteriaDataSetVentasTableAdapters.ventasTableAdapter();
            this.iDVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetVentas)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENTADataGridViewTextBoxColumn,
            this.pRODUCTOVENTADataGridViewTextBoxColumn,
            this.cANTIDADVENTADataGridViewTextBoxColumn,
            this.tOTALVENTADataGridViewTextBoxColumn,
            this.fECHAVENTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ventasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 176);
            this.dataGridView1.TabIndex = 8;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.ferreteriaDataSetVentas;
            // 
            // ferreteriaDataSetVentas
            // 
            this.ferreteriaDataSetVentas.DataSetName = "ferreteriaDataSetVentas";
            this.ferreteriaDataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // iDVENTADataGridViewTextBoxColumn
            // 
            this.iDVENTADataGridViewTextBoxColumn.DataPropertyName = "ID_VENTA";
            this.iDVENTADataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDVENTADataGridViewTextBoxColumn.Name = "iDVENTADataGridViewTextBoxColumn";
            // 
            // pRODUCTOVENTADataGridViewTextBoxColumn
            // 
            this.pRODUCTOVENTADataGridViewTextBoxColumn.DataPropertyName = "PRODUCTO_VENTA";
            this.pRODUCTOVENTADataGridViewTextBoxColumn.HeaderText = "Producto";
            this.pRODUCTOVENTADataGridViewTextBoxColumn.Name = "pRODUCTOVENTADataGridViewTextBoxColumn";
            // 
            // cANTIDADVENTADataGridViewTextBoxColumn
            // 
            this.cANTIDADVENTADataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_VENTA";
            this.cANTIDADVENTADataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cANTIDADVENTADataGridViewTextBoxColumn.Name = "cANTIDADVENTADataGridViewTextBoxColumn";
            // 
            // tOTALVENTADataGridViewTextBoxColumn
            // 
            this.tOTALVENTADataGridViewTextBoxColumn.DataPropertyName = "TOTAL_VENTA";
            this.tOTALVENTADataGridViewTextBoxColumn.HeaderText = "Total";
            this.tOTALVENTADataGridViewTextBoxColumn.Name = "tOTALVENTADataGridViewTextBoxColumn";
            // 
            // fECHAVENTADataGridViewTextBoxColumn
            // 
            this.fECHAVENTADataGridViewTextBoxColumn.DataPropertyName = "FECHA_VENTA";
            this.fECHAVENTADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHAVENTADataGridViewTextBoxColumn.Name = "fECHAVENTADataGridViewTextBoxColumn";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblReporteVentas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.Controls.SetChildIndex(this.lblReporteVentas, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReporteVentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ferreteriaDataSetVentas ferreteriaDataSetVentas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private ferreteriaDataSetVentasTableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTOVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENTADataGridViewTextBoxColumn;
    }
}
