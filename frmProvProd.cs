using System;
using System.ComponentModel;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmProvProd : frmMenu
    {
        private proveedor Proveedor = null;
        private producto Producto = null;

        private const int COL_PROVEEDOR = 0;
        private const int COL_PRODUCTO = 1;
        private const int COL_PRECIO = 2;

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
                txtProveedorNombre.Text = Proveedor.NombreProveedor;
                if (Proveedor.consulta(txtProveedor.Text))
                {
                    foreach (string[] elemento in Proveedor.listaProductos)
                    {
                        dgvProductos.Rows.Add(elemento[COL_PROVEEDOR], elemento[COL_PRODUCTO], elemento[COL_PRECIO]);
                    }
                }
            }
        }

        private void txtProducto_Validating(object sender, CancelEventArgs e)
        {
            Producto = new producto();
            bool existe = Producto.valida(txtProducto.Text);
            if (existe)
            {
                txtProductoNombre.Text = Producto.NombreProducto;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proveedor.asignarProducto(txtProducto.Text, txtPrecio.valor(), txtProveedor.Text);
        }
    }
}
