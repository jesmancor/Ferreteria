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
                try {
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "SELECT PRECIO_MENUDEO FROM PRODUCTOS WHERE ID_PRODUCTO = '" + txtIDVenta.Text + "'";
                    cnon.Open();
                    command.Connection = cnon;
                    object precio = command.ExecuteScalar();
                    cnon.Close();
                    this.dgVenta.Rows.Add("", precio,"");
                    MessageBox.Show("El precio del producto es $"+precio, "12 dígitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDVenta.Text = string.Empty;
                    btnVenta.Enabled = true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
