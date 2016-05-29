using System;
using System.ComponentModel;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmProvProd : frmMenu
    {
        private proveedor Proveedor = null;
        public frmProvProd()
        {
            InitializeComponent();
        }

        private void txtProveedor_GotFocus(object sender, EventArgs e)
        {
            txtProveedorNombre.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
        }

        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
            Proveedor = new proveedor();
            bool existe = Proveedor.validaExistencia(txtProveedor.Text);
            if (existe)
            {
                txtProveedorNombre.Text = Proveedor.strNombreProveedor;
            }
        }
    }
}
