using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand commandNombre = new OleDbCommand();
                    OleDbCommand commandPrecio = new OleDbCommand();
                    commandNombre.CommandText = "SELECT NOMBRE_PRODUCTO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + strIDVenta + "'";
                    commandPrecio.CommandText = "SELECT PRECIO_MENUDEO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + strIDVenta + "'";
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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha realizado la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgVenta.Rows.Clear();
            dgVenta.Refresh();
            doubTotalVenta = 0;
            lblTotal.Text = "$" + doubTotalVenta.ToString();
            btnVenta.Enabled = false;
        }
    }
}
