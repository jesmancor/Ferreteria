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
            if(txtIDVenta.Text.Length>=12)
            {
                try {
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "SELECT PRECIO_MENUDEO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + txtIDVenta.Text + "'";
                    cnon.Open();
                    command.Connection = cnon;
                    int precio = command.ExecuteNonQuery();
                    cnon.Close();
                    MessageBox.Show("El precio del producto es $" + precio, "12 dígitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDVenta.Text = string.Empty;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
