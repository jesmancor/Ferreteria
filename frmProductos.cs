using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmProductos : Ferreteria.frmMenu
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
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
            Producto.altaProducto();
        }
    }
}
