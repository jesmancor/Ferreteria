using System;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmVentas : frmMenu
    {
        private double doubTotalVenta = 0;

        //Constantes para filas del grid
        private const int FILA_ID = 0;
        private const int FILA_NOMBRE_PRODUCTO = 1;
        private const int FILA_CANTIDAD = 2;
        private const int FILA_PRECIO_UNITARIO = 3;
        private const int FILA_PRECIO_TOTAL = 4;

        //Constantes para elementos del arreglo
        private const int ARR_NOMBRE = 0;
        private const int ARR_ID = 1;
        private const int ARR_CANTIDAD = 2;
        private const int ARR_PRECIO = 3;

        public frmVentas()
        {
            InitializeComponent();
        }

        //Despliega la ventana en la que se realiza la consulta por descripción
        private string consultaPorDescripcion()
        {
            using (var form = new vtnProducto())
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

        //Despliega la ventana en la que se ingresa la cantidad del producto a vender
        private string ingresarCantidad()
        {
            using (var form = new frmCantidad())
            {
                var resultado = form.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    string valor = form.retornoCantidad;
                    return valor;
                }
                else
                    return null;
                }
        }

        //Despliega la ventana en la que se ingresa el efectivo que se recibe al hacer la venta y muestra el cambio
        //a devolver al cliente
        private bool cambioDeEfectivo(double total, out double retorno, out double efectivo)
        {
            using (var form = new frmEfectivo(total))
            {
                var resultado = form.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    retorno = form.retorno;
                    efectivo = form.efectivo;
                    return true;
                }
                else
                {
                    retorno = 0;
                    efectivo = 0;
                    return false;
                }
            }
        }

        //Método que reemplaza una línea del DataGridView si es que se vuelve a ingresar un producto
        //contenido en él
        private void nombreRepetido(object objeto)
        {
            foreach (DataGridViewRow filas in dgVenta.Rows)
            {
                string strNombre = filas.Cells[FILA_NOMBRE_PRODUCTO].Value.ToString();
                double doubRestarPrecio = double.Parse(filas.Cells[FILA_PRECIO_TOTAL].Value.ToString());
                if (objeto.ToString() == strNombre)
                {
                    doubTotalVenta = doubTotalVenta - doubRestarPrecio;
                    dgVenta.Rows.Remove(filas);
                }
            }
        }

        private void txtIDVenta_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                txtIDVenta.Text = consultaPorDescripcion();
            }
        }

        //Método que agrega los datos del producto al DataGridView
        private void txtIDVenta_TextChanged(object sender, EventArgs e)
        {
            double doubPrecio = 0;
            bool validacionConsulta = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDVenta.Text, "[^0-9]"))
            {
                txtIDVenta.Text = txtIDVenta.Text.Remove(txtIDVenta.Text.Length - 1);
            }
            if (txtIDVenta.Text.Length>=13)
            {
                string strIDVenta = txtIDVenta.Text;
                try
                {
                    producto Producto = new producto();
                    string strCantidad = ingresarCantidad();
                    int intCantidad = 0;
                    if (strCantidad != null)
                        intCantidad = int.Parse(strCantidad);
                    if (intCantidad > 0) { 
                    validacionConsulta = Producto.consulta(strIDVenta, intCantidad);
                        if (validacionConsulta)
                        {
                            nombreRepetido(Producto.strNombreProducto);
                            doubPrecio = Producto.consultaPrecio(strIDVenta,intCantidad) * intCantidad;
                            if (doubPrecio > 0)
                            {
                                dgVenta.Rows.Add(strIDVenta, Producto.strNombreProducto, strCantidad, Producto.doubPrecioUnitario, doubPrecio);
                                btnVenta.Enabled = true;
                                txtIDVenta.Text = string.Empty;
                                doubTotalVenta = doubTotalVenta + doubPrecio;
                                lblTotal.Text = "$" + doubTotalVenta.ToString();
                            }
                            else
                                txtIDVenta.Text = string.Empty;
                        }
                        else
                            txtIDVenta.Text = string.Empty;
                    }
                    else
                        txtIDVenta.Text = string.Empty;
                }
                catch (Exception exc)
                {
                    txtIDVenta.Text = string.Empty;
                }
            }
        }

        //Método que almacena los datos del DataGridview a la Base de Datos
        private void realizaVenta()
        {
            try {
                producto Producto = new producto();
                foreach (DataGridViewRow fila in dgVenta.Rows)
                {
                    string[] arreglo = new string[4];
                    string strNombre = fila.Cells[FILA_NOMBRE_PRODUCTO].Value.ToString();
                    string strID = fila.Cells[FILA_ID].Value.ToString();
                    string strCantidad = fila.Cells[FILA_CANTIDAD].Value.ToString();
                    string strTotal = fila.Cells[FILA_PRECIO_TOTAL].Value.ToString();
                    arreglo[ARR_NOMBRE] = strNombre;
                    arreglo[ARR_ID] = strID;
                    arreglo[ARR_CANTIDAD] = strCantidad;
                    arreglo[ARR_PRECIO] = strTotal;
                    Producto.agregaLista(arreglo);
                }
                double retorno;
                double efectivo;
                bool valCambio = cambioDeEfectivo(doubTotalVenta,out retorno,out efectivo);
                if (valCambio)
                {
                    if (Producto.procesaVenta())
                    {
                        MessageBox.Show("Se ha realizado la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Producto.imprimeTicket(doubTotalVenta, retorno, efectivo);
                        
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error inesperado al realizar la venta: " + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            realizaVenta();
            dgVenta.Rows.Clear();
            dgVenta.Refresh();
            doubTotalVenta = 0;
            lblTotal.Text = "$" + doubTotalVenta.ToString();
            btnVenta.Enabled = false;
        }
    }
}
