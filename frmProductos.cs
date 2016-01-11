using System;
using System.ComponentModel;
using System.Data.OleDb;
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
            txtBuscar.Focus();
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
        }

        private void llenarEditar()
        {
                txtID.Enabled = false;
                gbEditarNuevo.Text = "Editar producto";
                gbEditarNuevo.Visible = true;
                strEditarNuevo = "E";
                txtID.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();
                txtTipo.Text = dgProductos.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dgProductos.CurrentRow.Cells[3].Value.ToString();
                txtMenudeo.Text = dgProductos.CurrentRow.Cells[4].Value.ToString();
                txtMayoreo.Text = dgProductos.CurrentRow.Cells[5].Value.ToString();
                txtExistencias.Text = dgProductos.CurrentRow.Cells[7].Value.ToString();
                txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            llenarEditar();
        }

        private void NuevoProducto()
        {
            txtID.Enabled = true;
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMenudeo.Text = string.Empty;
            txtMayoreo.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            gbEditarNuevo.Text = "Nuevo producto";
            gbEditarNuevo.Visible = true;
            strEditarNuevo = "N";
            txtID.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto();
        }

        private void CancelarEdNu()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMenudeo.Text = string.Empty;
            txtMayoreo.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            gbEditarNuevo.Visible = false;
            strEditarNuevo = "";
            errorProvider1.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEdNu();
        }

        private void guardar()
        {
            try {
                OleDbConnection cnon = new OleDbConnection();
                cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "INSERT INTO PRODUCTOS (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO_PRODUCTO, DESCRIPCIÓN_PRODUCTO, PRECIO_MENUDEO, PRECIO_MAYOREO, EXISTENCIAS) VALUES('" + txtID.Text + "','" + txtNombre.Text.ToUpper() + "','" + txtTipo.Text.ToUpper() + "','" + txtDescripcion.Text.ToUpper() + "','" + txtMenudeo.Text + "','" + txtMayoreo.Text + "','" + txtExistencias.Text + "')";
                cnon.Open();
                command.Connection = cnon;
                command.ExecuteNonQuery();
                cnon.Close();
                MessageBox.Show("Nuevo producto agregado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Text = string.Empty;
                this.pRODUCTOSTableAdapter.Fill(this.ferreteriaDataSet.PRODUCTOS);
            }
             catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }

        private void editarProducto()
        {
            try {
                OleDbConnection cnon = new OleDbConnection();
                cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "UPDATE PRODUCTOS SET NOMBRE_PRODUCTO = '" + txtNombre.Text.ToUpper() + "', TIPO_PRODUCTO = '"+txtTipo.Text.ToUpper()+"', DESCRIPCIÓN_PRODUCTO = '" + txtDescripcion.Text.ToUpper() + "', PRECIO_MENUDEO = " + txtMenudeo.Text + ", PRECIO_MAYOREO = " + txtMayoreo.Text + ", EXISTENCIAS = "+txtExistencias.Text+" WHERE ID_PRODUCTO = " + txtID.Text;
                cnon.Open();
                command.Connection = cnon;
                command.ExecuteNonQuery();
                cnon.Close();
                MessageBox.Show("El producto con ID " + txtID.Text + " ha sido editado", "Producto editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Text = string.Empty;
                this.pRODUCTOSTableAdapter.Fill(this.ferreteriaDataSet.PRODUCTOS);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean blnValida = false;
            if (string.IsNullOrEmpty(txtID.Text))
            {
                errorProvider1.SetError(txtID, "El ID no puede ir vacío");
                blnValida = false;
            }
            else
                blnValida = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede ir vacío");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                errorProvider1.SetError(txtTipo, "El tipo no puede ir vacío");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "La descripción no puede ir vacía");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtMenudeo.Text))
            {
                errorProvider1.SetError(txtMenudeo, "El precio de menudeo no puede ir vacío");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtMayoreo.Text))
            {
                errorProvider1.SetError(txtMayoreo, "El precio de mayoreo no puede ir vacío");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtExistencias.Text))
            {
                errorProvider1.SetError(txtExistencias, "El campo de existencias no puede ir vacío");
                blnValida = false;
            }
            else
            {
                blnValida = true;
                errorProvider1.Clear();
            }
            if (strEditarNuevo == "N" && blnValida == true)
            {
                guardar();
                gbEditarNuevo.Visible = false;
            }
            else if (strEditarNuevo == "E" && blnValida == true)
            {
                editarProducto();
                gbEditarNuevo.Visible = false;
            }
        }

        private void eliminarProducto()
        {
            DialogResult confEliminar = MessageBox.Show("¿Eliminar el producto con ID " + dgProductos.CurrentRow.Cells[0].Value.ToString() + "?", "¿Eliminar producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confEliminar == DialogResult.Yes)
            {
                try
                {
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = " + dgProductos.CurrentRow.Cells[0].Value.ToString();
                    cnon.Open();
                    command.Connection = cnon;
                    command.ExecuteNonQuery();
                    cnon.Close();
                    MessageBox.Show("El producto con ID " + dgProductos.CurrentRow.Cells[0].Value.ToString() + " ha sido eliminado", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Text = string.Empty;
                    this.pRODUCTOSTableAdapter.Fill(this.ferreteriaDataSet.PRODUCTOS);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox currenttb = (TextBox)sender;
                if (currenttb.Text == "") { 
                    MessageBox.Show(string.Format("El campo {0} está vacío", currenttb.Name.Substring(3)));
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.B:
                    txtBuscar.Focus();
                    return true;
                case Keys.Control | Keys.E:
                    llenarEditar();
                    return true;
                case Keys.Control | Keys.N:
                    NuevoProducto();
                    return true;
                case Keys.Delete:
                    eliminarProducto();
                    return true;
                case Keys.Escape:
                    CancelarEdNu();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
