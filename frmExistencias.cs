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
            txtID.Text = Producto.strID;
            txtNombre.Text = Producto.strNombreProducto;
        }

        private string consultaPorDescripcion()
        {
            using (var form = new frmConsulta())
            {
                var resultado = form.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    string valor = form.valor;
                    return valor;
                }
                else
                    return null;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
            {
                txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
            }
            if (txtID.Text.Length >= 13)
            {
                txtMaximo.Focus();
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                Producto = new producto();
                bool valida = Producto.valida(txtID.Text);
                if (valida)
                {
                    txtActuales.Text = Producto.strExistencias;
                    txtNombre.Text = Producto.strNombreProducto;
                    txtMaximo.Value = int.Parse(Producto.strMaximo);
                    txtMinimo.Value = int.Parse(Producto.strMinimo);
                    txtReorden.Value = int.Parse(Producto.strReorden);
                    int intNuevas = int.Parse(txtActuales.Text) + (int)txtAgregar.Value;
                    txtNuevas.Text = intNuevas.ToString();
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
            btnAgregar.Enabled = false;
        }

        private void txtID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                txtID.Text = consultaPorDescripcion();
            }
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
            Producto.strExistencias = txtNuevas.Text;
            Producto.strMaximo = txtMaximo.Value.ToString();
            Producto.strMinimo = txtMinimo.Value.ToString();
            Producto.strReorden = txtReorden.Value.ToString();
            if (Producto.agregarExistencias())
            {
                txtID.Focus();
            }
        }
    }
}
