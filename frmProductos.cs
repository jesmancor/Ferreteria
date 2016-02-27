using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;
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
            try
            {
                this.productosTableAdapter.Fill(this.ferreteriaDataSet.productos);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource source1 = new BindingSource();
            source1.DataSource = productosBindingSource;
            if (txtBuscar.Text.Length > 0)
            {
                try
                {
                    string searchValue = txtBuscar.Text;
                    string busqueda = string.Format("{0} LIKE '%{1}%'", "DESCRIPCION_PRODUCTO", searchValue);
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
            limpiarErrorProvider();
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
            limpiarErrorProvider();
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
            limpiarErrorProvider();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEdNu();
        }

        private void guardar()
        {
            try {
                MySqlConnection cnon = new MySqlConnection(Objetos.constantes.CONEXION_MYSQL);
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO productos (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO_PRODUCTO, DESCRIPCION_PRODUCTO, PRECIO_MENUDEO, PRECIO_MAYOREO, EXISTENCIAS) VALUES('" + txtID.Text + "','" + txtNombre.Text.ToUpper() + "','" + txtTipo.Text.ToUpper() + "','" + txtDescripcion.Text.ToUpper() + "','" + txtMenudeo.Text + "','" + txtMayoreo.Text + "','" + txtExistencias.Text + "')";
                cnon.Open();
                command.Connection = cnon;
                command.ExecuteNonQuery();
                cnon.Close();
                MessageBox.Show("Nuevo producto agregado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Text = string.Empty;
                this.productosTableAdapter.Fill(this.ferreteriaDataSet.productos);
            }
             catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }

        private void editarProducto()
        {
            try {
                MySqlConnection cnon = new MySqlConnection(Objetos.constantes.CONEXION_MYSQL);
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "UPDATE productos SET NOMBRE_PRODUCTO = '" + txtNombre.Text.ToUpper() + "', TIPO_PRODUCTO = '"+txtTipo.Text.ToUpper()+"', DESCRIPCION_PRODUCTO = '" + txtDescripcion.Text.ToUpper() + "', PRECIO_MENUDEO = " + txtMenudeo.Text + ", PRECIO_MAYOREO = " + txtMayoreo.Text + ", EXISTENCIAS = "+txtExistencias.Text+" WHERE ID_PRODUCTO = '" + txtID.Text+"'";
                cnon.Open();
                command.Connection = cnon;
                command.ExecuteNonQuery();
                cnon.Close();
                MessageBox.Show("El producto con ID " + txtID.Text + " ha sido editado", "Producto editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Text = string.Empty;
                this.productosTableAdapter.Fill(this.ferreteriaDataSet.productos);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean validaAceptar = validacion();
            if (strEditarNuevo == "N" && validaAceptar == true)
            {
                guardar();
                gbEditarNuevo.Visible = false;
            }
            else if (strEditarNuevo == "E" && validaAceptar == true)
            {
                editarProducto();
                gbEditarNuevo.Visible = false;
            }
        }

        private Boolean validacion()
        {
            double doble = 1.0;
            int entero = 1;
            bool blnMenudeo = double.TryParse(txtMenudeo.Text, out doble);
            bool blnMayoreo = double.TryParse(txtMayoreo.Text, out doble);
            bool blnExistencias = int.TryParse(txtExistencias.Text, out entero);
            //Id
            if (string.IsNullOrEmpty(txtID.Text))
                epID.SetError(txtID, "El ID no puede ir vacío");
            else
                epID.Clear();
            //Nombre
            if (string.IsNullOrEmpty(txtNombre.Text))
                epNombre.SetError(txtNombre, "El Nombre no puede ir vacío");
            else
                epNombre.Clear();
            //Tipo
            if (string.IsNullOrEmpty(txtTipo.Text))
                epTipo.SetError(txtTipo, "El tipo de producto no puede ir vacío");
            else
                epTipo.Clear();
            //Descripción
            if (string.IsNullOrEmpty(txtDescripcion.Text))
                epDescripcion.SetError(txtDescripcion, "La descripción no puede ir vacía");
            else
                epDescripcion.Clear();
            //Menudeo
            if (string.IsNullOrEmpty(txtMenudeo.Text))
                epMenudeo.SetError(txtMenudeo, "El precio de menudeo no puede ir vacío");
            else if(blnMenudeo==false)
                epMenudeo.SetError(txtMenudeo, "El precio de menudeo debe ser un número");
            else
                epMenudeo.Clear();
            //Mayoreo
            if (string.IsNullOrEmpty(txtMayoreo.Text))
                epMayoreo.SetError(txtMayoreo, "El precio de mayoreo no puede ir vacío");
            else if(blnMayoreo==false)
                epMayoreo.SetError(txtMayoreo, "El precio de mayoreo debe ser un número entero");
            else
                epMayoreo.Clear();
            //Existencias
            if (string.IsNullOrEmpty(txtExistencias.Text))
                epExistencias.SetError(txtExistencias, "El campo de existencias no puede ir vacío");
            else if(blnExistencias==false)
                epExistencias.SetError(txtExistencias, "El campo de existencias debe ser un número");
            else
                epExistencias.Clear();
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTipo.Text) && string.IsNullOrEmpty(txtMenudeo.Text) || string.IsNullOrEmpty(txtMayoreo.Text) || string.IsNullOrEmpty(txtExistencias.Text)||blnMenudeo==false||blnMayoreo==false||blnExistencias==false)
                return false;
            else
                return true;
        }

        private void limpiarErrorProvider()
        {
            epID.Clear();
            epNombre.Clear();
            epDescripcion.Clear();
            epTipo.Clear();
            epMenudeo.Clear();
            epMayoreo.Clear();
            epExistencias.Clear();
        }

        private void eliminarProducto()
        {
            DialogResult confEliminar = MessageBox.Show("¿Eliminar el producto con ID " + dgProductos.CurrentRow.Cells[0].Value.ToString() + "?", "¿Eliminar producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confEliminar == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection cnon = new MySqlConnection(Objetos.constantes.CONEXION_MYSQL);
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "DELETE FROM productos WHERE ID_PRODUCTO = " + dgProductos.CurrentRow.Cells[0].Value.ToString();
                    cnon.Open();
                    command.Connection = cnon;
                    command.ExecuteNonQuery();
                    cnon.Close();
                    MessageBox.Show("El producto con ID " + dgProductos.CurrentRow.Cells[0].Value.ToString() + " ha sido eliminado", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Text = string.Empty;
                    this.productosTableAdapter.Fill(this.ferreteriaDataSet.productos);

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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
            {
                txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
            }
        }

        private void txtMenudeo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMenudeo.Text, "[^0-9,^0-9]"))
            {
                txtMenudeo.Text = txtMenudeo.Text.Remove(txtMenudeo.Text.Length - 1);
            }
        }

        private void txtMayoreo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMayoreo.Text, "[^0-9,^0-9]"))
            {
                txtMayoreo.Text = txtMayoreo.Text.Remove(txtMayoreo.Text.Length - 1);
            }
        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtExistencias.Text, "[^0-9]"))
            {
                txtExistencias.Text = txtExistencias.Text.Remove(txtExistencias.Text.Length - 1);
            }
        }
    }
}
