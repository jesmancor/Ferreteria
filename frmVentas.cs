using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                MessageBox.Show("Has ingresado 12 dígitos", "12 dígitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDVenta.Text = string.Empty;
            }
        }
    }
}
