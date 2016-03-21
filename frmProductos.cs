using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmProductos : Ferreteria.frmMenu
    {
        public frmProductos()
        {
            InitializeComponent();
            txtID.GotFocus += txtID_GotFocus;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
        }

        private void txtID_GotFocus(object sender, EventArgs e)
        {
            limpiarCampos();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
            {
                txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
            }
            if (txtID.Text.Length >= 13)
            {
                txtNombre.Focus();
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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDescuento.Text, "[^0-9]"))
            {
                txtDescuento.Text = txtDescuento.Text.Remove(txtDescuento.Text.Length - 1);
            }
        }

        private void txtMinimo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMinimo.Text, "[^0-9]"))
            {
                txtMinimo.Text = txtMinimo.Text.Remove(txtMinimo.Text.Length - 1);
            }
        }

        private void txtMaximo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaximo.Text, "[^0-9]"))
            {
                txtMaximo.Text = txtMaximo.Text.Remove(txtMaximo.Text.Length - 1);
            }
        }

        private void txtReorden_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReorden.Text, "[^0-9]"))
            {
                txtReorden.Text = txtReorden.Text.Remove(txtReorden.Text.Length - 1);
            }
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
                    txtNombre.Text = Producto.strNombreProducto;
                    txtTipo.Text = Producto.strTipo;
                    txtDescripcion.Text = Producto.strDescripcion;
                    txtMenudeo.Text = Producto.strMenudeo;
                    txtMayoreo.Text = Producto.strMayoreo;
                    txtDescuento.Text = Producto.strDescuento;
                    txtExistencias.Text = Producto.strExistencias;
                    txtMaximo.Text = Producto.strMaximo;
                    txtMinimo.Text = Producto.strMinimo;
                    txtReorden.Text = Producto.strReorden;
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

        private void txtExistencias_Validating(object sender, CancelEventArgs e)
        {
            if (txtExistencias.Text != string.Empty)
            {
                int intExistencias = int.Parse(txtExistencias.Text);
                if (intExistencias < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtExistencias.Text = string.Empty;
                    e.Cancel = true;
                }
            }
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

        private void txtMinimo_Validating(object sender, CancelEventArgs e)
        {
            if (txtMinimo.Text != string.Empty)
            {
                int intMinimo = int.Parse(txtMinimo.Text);
                if (intMinimo < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMinimo.Text = string.Empty;
                    e.Cancel = true;
                }
                if (txtExistencias.Text != string.Empty)
                {
                    int intExistencias = int.Parse(txtExistencias.Text);
                    if (intExistencias < intMinimo)
                    {
                        MessageBox.Show("El mínimo debe ser menor que las existencias", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMinimo.Text = string.Empty;
                        e.Cancel = true;
                    }
                    else if (txtReorden.Text != string.Empty)
                    {
                        int intReorden = int.Parse(txtReorden.Text);
                        if (intReorden < intMinimo)
                        {
                            MessageBox.Show("El mínimo debe ser menor que el punto de reorden", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMinimo.Text = string.Empty;
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void txtMaximo_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaximo.Text != string.Empty)
            {
                int intMaximo = int.Parse(txtMaximo.Text);
                if (intMaximo < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaximo.Text = string.Empty;
                    e.Cancel = true;
                }
            }
        }

        private void txtReorden_Validating(object sender, CancelEventArgs e)
        {
            if (txtReorden.Text != string.Empty)
            {
                int intReorden = int.Parse(txtReorden.Text);
                if (intReorden < 1)
                {
                    MessageBox.Show("El valor no puede ser cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReorden.Text = string.Empty;
                    e.Cancel = true;
                }
                if (txtExistencias.Text != string.Empty)
                {
                    int intExistencias = int.Parse(txtExistencias.Text);
                    if (intExistencias < intReorden)
                    {
                        MessageBox.Show("El punto de reorden debe ser menor que las existencias", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtReorden.Text = string.Empty;
                        e.Cancel = true;
                    }
                    else if (txtMinimo.Text != string.Empty)
                    {
                        int intMinimo = int.Parse(txtMinimo.Text);
                        if (intReorden < intMinimo)
                        {
                            MessageBox.Show("El punto de reorden debe ser mayor que el mínimo", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtReorden.Text = string.Empty;
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto Producto = new producto();
            Producto.strID = txtID.Text;
            Producto.strNombreProducto = txtNombre.Text;
            Producto.strTipo = txtTipo.Text;
            Producto.strDescripcion = txtDescripcion.Text;
            Producto.strMenudeo = txtMenudeo.Text;
            Producto.strMayoreo = txtMayoreo.Text;
            Producto.strDescuento = txtDescuento.Text;
            Producto.strExistencias = txtExistencias.Text;
            Producto.strMinimo = txtMinimo.Text;
            Producto.strMaximo = txtMaximo.Text;
            Producto.strReorden = txtReorden.Text;
            bool valida = validaCampos();
            if (valida)
            {
                valida = Producto.altaProducto();
                if (valida)
                {
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            producto Producto = new producto();
            Producto.strID = txtID.Text;
            Producto.strNombreProducto = txtNombre.Text;
            Producto.strTipo = txtTipo.Text;
            Producto.strDescripcion = txtDescripcion.Text;
            Producto.strMenudeo = txtMenudeo.Text;
            Producto.strMayoreo = txtMayoreo.Text;
            Producto.strDescuento = txtDescuento.Text;
            Producto.strExistencias = txtExistencias.Text;
            Producto.strMinimo = txtMinimo.Text;
            Producto.strMaximo = txtMaximo.Text;
            Producto.strReorden = txtReorden.Text;
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
            producto Producto = new producto();
            Producto.strID = txtID.Text;
            bool valida = Producto.eliminarProducto();
            if (valida)
            {
                txtID.Text = string.Empty;
                txtID.Focus();
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMenudeo.Text = string.Empty;
            txtMayoreo.Text = string.Empty;
            txtDescuento.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            txtMaximo.Text = string.Empty;
            txtMinimo.Text = string.Empty;
            txtReorden.Text = string.Empty;
        }

        private bool validaCampos()
        {
            if(
            txtNombre.Text == string.Empty ||
            txtTipo.Text == string.Empty ||
            txtDescripcion.Text == string.Empty ||
            txtMenudeo.Text == string.Empty ||
            txtMayoreo.Text == string.Empty ||
            txtDescuento.Text == string.Empty ||
            txtExistencias.Text == string.Empty ||
            txtMaximo.Text ==string.Empty ||
            txtMinimo.Text == string.Empty ||
            txtReorden.Text == string.Empty
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