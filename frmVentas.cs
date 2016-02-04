using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmVentas : Ferreteria.frmMenu
    {
        private double doubTotalVenta = 0;

        public frmVentas()
        {
            InitializeComponent();
        }

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
                {
                    return null;
                }
                }
        }

        private void nombreRepetido(object objeto)
        {
            foreach (DataGridViewRow filas in dgVenta.Rows)
            {
                string strNombre = filas.Cells[0].Value.ToString();
                double doubRestarPrecio = double.Parse(filas.Cells[3].Value.ToString());
                if (objeto.ToString() == strNombre)
                {
                    doubTotalVenta = doubTotalVenta - doubRestarPrecio;
                    dgVenta.Rows.Remove(filas);
                }
            }
        }

        private void txtIDVenta_TextChanged(object sender, EventArgs e)
        {
            double doubPrecio = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDVenta.Text, "[^0-9]"))
            {
                txtIDVenta.Text = txtIDVenta.Text.Remove(txtIDVenta.Text.Length - 1);
            }
            if (txtIDVenta.Text.Length>=13)
            {
                string strIDVenta = txtIDVenta.Text;
                try {
                    string strCantidad = ingresarCantidad();
                    MySqlConnection cnon = new MySqlConnection();
                    cnon.ConnectionString = @"Data Source=localhost;User id=root;Password=666666;database=ferreteria";
                    MySqlCommand commandNombre = new MySqlCommand();
                    MySqlCommand commandPrecio = new MySqlCommand();
                    commandNombre.CommandText = "SELECT NOMBRE_PRODUCTO FROM productos WHERE ID_PRODUCTO = '" + strIDVenta + "'";
                    commandPrecio.CommandText = "SELECT PRECIO_MENUDEO FROM productos WHERE ID_PRODUCTO = '" + strIDVenta + "'";
                    cnon.Open();
                    commandPrecio.Connection = cnon;
                    commandNombre.Connection = cnon;
                    object objPrecioUnitario = commandPrecio.ExecuteScalar();
                    object objNombre = commandNombre.ExecuteScalar();
                    cnon.Close();
                    nombreRepetido(objNombre);
                    if (strCantidad != null && int.Parse(strCantidad) != 0 && objNombre != null)
                    {
                        lblIDNoexiste.Visible = false;
                        doubPrecio = double.Parse(objPrecioUnitario.ToString()) * int.Parse(strCantidad);
                        this.dgVenta.Rows.Add(objNombre, strCantidad,objPrecioUnitario ,doubPrecio);
                        btnVenta.Enabled = true;
                    }
                    else if (objNombre == null)
                    {
                        lblIDNoexiste.Visible = true;
                    }
                    txtIDVenta.Text = string.Empty;
                    doubTotalVenta = doubTotalVenta + doubPrecio;
                    lblTotal.Text = "$"+doubTotalVenta.ToString();
                    }
                catch (Exception exc)
                {
                    MessageBox.Show("Error inesperado: " + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void realizaVenta()
        {
            try {
                foreach (DataGridViewRow filas in dgVenta.Rows)
                {
                    string strNombre = filas.Cells[0].Value.ToString();
                    string strCantidad = filas.Cells[1].Value.ToString();
                    string strTotal = filas.Cells[3].Value.ToString();
                    MySqlConnection cnon = new MySqlConnection();
                    cnon.ConnectionString = @"Data Source=localhost;User id=root;Password=666666;database=ferreteria";
                    MySqlCommand commandInsertVenta = new MySqlCommand();
                    MySqlCommand commandConsultaExistencias = new MySqlCommand();
                    MySqlCommand commandRestaExistencia = new MySqlCommand();
                    commandInsertVenta.CommandText = "INSERT INTO VENTAS (PRODUCTO_VENTA, CANTIDAD_VENTA, TOTAL_VENTA) VALUES ('" + strNombre + "', '" + strCantidad + "', '" + strTotal + " ')";
                    commandConsultaExistencias.CommandText = "SELECT EXISTENCIAS FROM productos WHERE NOMBRE_PRODUCTO = '" + strNombre + "'";
                    cnon.Open();
                    commandConsultaExistencias.Connection = cnon;
                    int intExistencias = int.Parse(commandConsultaExistencias.ExecuteScalar().ToString());
                    int intResta = intExistencias - int.Parse(strCantidad);
                    commandRestaExistencia.CommandText="UPDATE productos SET EXISTENCIAS = "+ intResta + " WHERE NOMBRE_PRODUCTO = '" + strNombre + "'";
                    commandRestaExistencia.Connection = cnon;
                    commandInsertVenta.Connection = cnon;
                    commandInsertVenta.ExecuteNonQuery();
                    commandRestaExistencia.ExecuteNonQuery();
                    cnon.Close();
                }
                MessageBox.Show("Se ha realizado la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error inesperado al realizar la venta: " + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validaExistencia()
        {
            try {
                foreach (DataGridViewRow filas in dgVenta.Rows)
                {
                    string strNombre = filas.Cells[0].Value.ToString();
                    string strCantidad = filas.Cells[1].Value.ToString();
                    MySqlConnection cnon = new MySqlConnection();
                    cnon.ConnectionString = @"Data Source=localhost;User id=root;Password=666666;database=ferreteria";
                    MySqlCommand commandExistencias = new MySqlCommand();
                    commandExistencias.CommandText = "SELECT EXISTENCIAS FROM productos WHERE NOMBRE_PRODUCTO = '"+strNombre+"'";
                    cnon.Open();
                    commandExistencias.Connection = cnon;
                    object objExistencias=commandExistencias.ExecuteScalar();
                    if (int.Parse(objExistencias.ToString()) < int.Parse(strCantidad))
                    {
                        MessageBox.Show("Las existencias del producto " + strNombre + " no son suficientes para realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    cnon.Close();     
                }
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error inesperado: " + exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (validaExistencia())
                realizaVenta();
            dgVenta.Rows.Clear();
            dgVenta.Refresh();
            doubTotalVenta = 0;
            lblTotal.Text = "$" + doubTotalVenta.ToString();
            btnVenta.Enabled = false;
        }
    }
}
