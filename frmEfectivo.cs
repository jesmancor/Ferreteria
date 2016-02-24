using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmEfectivo : Form
    {
        public double efectivo;
        public double total;
        public double retorno;

        public frmEfectivo(double totalVenta)
        {
            InitializeComponent();
            total = totalVenta;
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEfectivo.Text, "[^0-9,^0-9]"))
            {
                txtEfectivo.Text = txtEfectivo.Text.Remove(txtEfectivo.Text.Length - 1);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtEfectivo.Text != "")
            {
                efectivo = double.Parse(txtEfectivo.Text);
                if(efectivo>=total){
                    retorno = efectivo - total;
                    if (retorno!=0)
                        MessageBox.Show("Cantidad a devolver: $"+ retorno, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad mayor o igual al total de la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEfectivo.Text = string.Empty;
                }
            }
            else
            {
                confirmaCancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            confirmaCancelar();
        }

        private void confirmaCancelar()
        {
            DialogResult pregunta = MessageBox.Show("¿Desea cancelar la venta?", "¿Cancelar venta?", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (pregunta == DialogResult.No)
            {
                txtEfectivo.Focus();
            }
        }
    }
}
