using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmProductos : Ferreteria.frmMenu
    {
        public string strEditarNuevo = "";
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.ferreteriaDataSet.PRODUCTOS);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource source1 = new BindingSource();
            source1.DataSource = pRODUCTOSBindingSource;
            if (txtBuscar.Text.Length > 0)
            {
                try
                {
                    string searchValue = txtBuscar.Text;
                    string busqueda = string.Format("{0} LIKE '%{1}%'", "DESCRIPCIÓN_PRODUCTO", searchValue);
                    source1.Filter = busqueda;
                    dgProductos.DataSource = source1;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                source1.Filter = null;
                dgProductos.DataSource = source1;
            }
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgProductos.SelectedRows.ToString(), "Producto seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            gbEditarNuevo.Text = "Editar producto";
            gbEditarNuevo.Visible=true;
            strEditarNuevo = "E";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            gbEditarNuevo.Text = "Nuevo producto";
            gbEditarNuevo.Visible = true;
            strEditarNuevo = "N";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMenudeo.Text = string.Empty;
            txtMayoreo.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            gbEditarNuevo.Visible = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            strEditarNuevo = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (strEditarNuevo=="N")
                MessageBox.Show("Nuevo producto agregado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(strEditarNuevo=="E")
                MessageBox.Show("El producto ha sido editado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbEditarNuevo.Visible = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }
    }

}
