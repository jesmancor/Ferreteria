using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmProductos : frmMenu
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void txtID_GotFocus(object sender, EventArgs e)
        {
            limpiarCampos();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                bool valida;
                producto Producto = new producto();
                valida = Producto.valida(txtID.Text);
                if (valida)
                {
                    txtNombre.Text = Producto.NombreProducto;
                    txtTipo.Text = Producto.Tipo;
                    txtDescripcion.Text = Producto.Descripcion;
                    txtMenudeo.asignarValor(Producto.Menudeo);
                    txtMayoreo.asignarValor(Producto.Mayoreo);
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    DialogResult pregunta = MessageBox.Show("¿Desea dar de alta el producto con ID " + txtID.Text + "?", "Alta producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pregunta == DialogResult.Yes)
                    {
                        limpiarCampos();
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        txtID.Text = string.Empty;
                        btnAgregar.Enabled = false;
                        e.Cancel = true;
                    }
                }
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtTipo_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtMenudeo_Validating(object sender, CancelEventArgs e)
        {
            if (txtMenudeo.Text != string.Empty)
            {
                double intMenudeo = double.Parse(txtMenudeo.Text);
                if (intMenudeo < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMenudeo.Text = string.Empty;
                    e.Cancel = true;
                }
            }
        }

        private void txtMayoreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtMayoreo.Text != string.Empty)
            {
                double intMayoreo = double.Parse(txtMayoreo.Text);
                if (intMayoreo < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMayoreo.Text = string.Empty;
                    e.Cancel = true;
                }
            }
        }

        private void txtDescuento_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto Producto = new producto();
            Producto.ID = txtID.Text;
            Producto.NombreProducto = txtNombre.Text;
            Producto.Tipo = txtTipo.Text;
            Producto.Descripcion = txtDescripcion.Text;
            Producto.Menudeo = txtMenudeo.valor();
            Producto.Mayoreo = txtMayoreo.valor();
            bool valida = validaCampos();
            if (valida)
            {
                valida = Producto.altaProducto();
                if (valida)
                {
                    DialogResult pregunta = MessageBox.Show("¿Agregar existencias al nuevo producto?", "¿Alta existencias?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pregunta == DialogResult.Yes)
                    {
                        frmExistencias frm = new frmExistencias(Producto);
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        txtID.Text = string.Empty;
                        txtID.Focus();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            producto Producto = new producto();
            Producto.ID = txtID.Text;
            Producto.NombreProducto = txtNombre.Text;
            Producto.Tipo = txtTipo.Text;
            Producto.Descripcion = txtDescripcion.Text;
            Producto.Menudeo = txtMenudeo.valor();
            Producto.Mayoreo = txtMayoreo.valor();
            bool valida = validaCampos();
            if (valida)
            {
                valida = Producto.modificarProducto();
                if (valida)
                {
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Desea dar de baja el producto con ID " + txtID.Text + "?", "¿Eliminar producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                producto Producto = new producto();
                Producto.ID = txtID.Text;
                bool valida = Producto.eliminarProducto();
                if (valida)
                {
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMenudeo.Text = string.Empty;
            txtMayoreo.Text = string.Empty;
        }

        private bool validaCampos()
        {
            if(
            txtNombre.Text == string.Empty ||
            txtTipo.Text == string.Empty ||
            txtDescripcion.Text == string.Empty ||
            txtMenudeo.Text == string.Empty ||
            txtMayoreo.Text == string.Empty
            )
            {
                MessageBox.Show("Se deben llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}