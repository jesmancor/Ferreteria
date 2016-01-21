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
                    string strCantidad = ingresarCantidad();
                    if (strCantidad!=null && int.Parse(strCantidad)!=0) 
                        this.dgVenta.Rows.Add(objNombre, objPrecio,strCantidad);    
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
