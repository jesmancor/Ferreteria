using Ferreteria.Objetos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmExistencias : frmMenu
    {
        producto Producto = null;

        public frmExistencias()
        {
            InitializeComponent();
        }

        public frmExistencias(producto Prod)
        {
            InitializeComponent();
            Producto = Prod;
            txtID.Text = Producto.ID;
            txtNombre.Text = Producto.NombreProducto;
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                Producto = new producto();
                bool valida = Producto.valida(txtID.Text);
                if (valida)
                {
                    txtActuales.Text = Producto.Existencias.ToString();
                    txtNombre.Text = Producto.NombreProducto;
                    txtMaximo.Value = Producto.Maximo;
                    txtMinimo.Value = Producto.Minimo;
                    txtReorden.Value = Producto.Reorden;
                    int intNuevas = int.Parse(txtActuales.Text) + (int)txtAgregar.Value;
                    txtNuevas.Text = intNuevas.ToString();
                    txtProveedor.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El ID de producto no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Text = string.Empty;
                    txtActuales.Text = string.Empty;
                    e.Cancel = true;
                }
            }
        }

        private void txtID_GotFocus(object sender, EventArgs e)
        {
            Producto = null;
            txtActuales.Text = "0";
            txtAgregar.Value = 1;
            txtReorden.Value = 1;
            txtMinimo.Value = 1;
            txtMaximo.Value = 1;
            txtNuevas.Text = "0";
            txtProveedor.Text = string.Empty;
            txtProveedorNombre.Text = string.Empty;
            btnAgregar.Enabled = false;
        }

        private void txtAgregar_ValueChanged(object sender, EventArgs e)
        {
            int intNuevas = int.Parse(txtActuales.Text) + (int)txtAgregar.Value;
            txtNuevas.Text = intNuevas.ToString();
            activaBoton();
        }

        private void txtMaximo_ValueChanged(object sender, EventArgs e)
        {
            activaBoton();
        }

        private void txtMinimo_ValueChanged(object sender, EventArgs e)
        {
            activaBoton();
        }

        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (txtProveedor.Text != string.Empty)
            {
                proveedor Proveedor = new proveedor();
                if (Proveedor.validaExistencia(txtProveedor.Text))
                {
                    txtProveedorNombre.Text = Proveedor.strNombreProveedor;
                }
                else
                {
                    MessageBox.Show("El proveedor no existe", "Proveedor no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void activaBoton()
        {
            if (txtReorden.Value <= txtMaximo.Value &&
                txtReorden.Value >= txtMinimo.Value &&
                txtMinimo.Value <= txtMaximo.Value &&
                (txtAgregar.Value + int.Parse(txtActuales.Text)) <= txtMaximo.Value &&
                (txtAgregar.Value + int.Parse(txtActuales.Text)) >= txtReorden.Value &&
                (txtAgregar.Value + int.Parse(txtActuales.Text)) >= txtMinimo.Value &&
                Producto != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto.Existencias = txtNuevas.valor();
            Producto.Proveedor = txtProveedor.Text;
            Producto.Cantidad = txtAgregar.Value.ToString();
            if (Producto.agregarExistencias())
            {
                txtID.Focus();
            }
        }
    }
}
