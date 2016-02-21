using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmVentas : frmMenu
    {
        private double doubTotalVenta = 0;
        private const int FILA_ID = 0;
        private const int FILA_NOMBRE_PRODUCTO = 1;
        private const int FILA_CANTIDAD = 2;
        private const int FILA_PRECIO_UNITARIO = 3;
        private const int FILA_PRECIO_TOTAL = 4;

        public frmVentas()
        {
            InitializeComponent();
        }

        //Despliega la ventana en la que se ingresa la cantidad del producto a vender
        private string ingresarCantidad()
        {
            using (var form = new frmCantidad())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string valor = form.retornoCantidad;
                    return valor;
                }
                else
                    return null;
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
                                this.dgVenta.Rows.Add(strIDVenta, Producto.strNombreProducto, strCantidad, Producto.doubPrecioUnitario, doubPrecio);
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
                    MessageBox.Show("Error inesperado: " + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método que almacena los datos del DataGridview a la Base de Datos
        private void realizaVenta()
        {
            try {
                foreach (DataGridViewRow filas in dgVenta.Rows)
                {
                    string strNombre = filas.Cells[FILA_NOMBRE_PRODUCTO].Value.ToString();
                    string strID = filas.Cells[FILA_ID].Value.ToString();
                    string strCantidad = filas.Cells[FILA_CANTIDAD].Value.ToString();
                    string strTotal = filas.Cells[FILA_PRECIO_TOTAL].Value.ToString();
                    producto.procesaVenta(strNombre,strID,strCantidad,strTotal);
                }
                MessageBox.Show("Se ha realizado la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
