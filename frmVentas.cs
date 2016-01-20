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
        public frmVentas()
        {
            InitializeComponent();
        }

        private void txtIDVenta_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDVenta.Text, "[^0-9]"))
            {
                txtIDVenta.Text = txtIDVenta.Text.Remove(txtIDVenta.Text.Length - 1);
            }
            if (txtIDVenta.Text.Length>=12)
            {
                string strIDVenta = txtIDVenta.Text;
                try {
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand commandNombre = new OleDbCommand();
                    OleDbCommand commandPrecio = new OleDbCommand();
                    commandNombre.CommandText= "SELECT NOMBRE_PRODUCTO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + strIDVenta + "'";
                    commandPrecio.CommandText = "SELECT PRECIO_MENUDEO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + strIDVenta + "'";
                    cnon.Open();
                    commandPrecio.Connection = cnon;
                    commandNombre.Connection = cnon;
                    object objPrecio = commandPrecio.ExecuteScalar();
                    object objNombre = commandNombre.ExecuteScalar();
                    cnon.Close();
                    if (dgVenta.Rows[0].Cells[0].Value != null)
                    {
                        for (int fila = 0; fila < dgVenta.Rows.Count; fila++)
                          {
                            string nombreFila = dgVenta.Rows[fila].Cells[0].Value.ToString();
                            if (nombreFila == objNombre.ToString())
                                dgVenta.Rows[fila].Cells[2].Value = int.Parse(dgVenta.Rows[fila].Cells[2].Value.ToString())+1;
                            else
                                this.dgVenta.Rows.Add(objNombre, objPrecio, 1);                                                              
                          }                          
                    }
                    else
                        this.dgVenta.Rows.Add(objNombre, objPrecio, 1);    
                    txtIDVenta.Text = string.Empty;
                    btnVenta.Enabled = true;
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
            btnVenta.Enabled = false;
        }
    }
}
