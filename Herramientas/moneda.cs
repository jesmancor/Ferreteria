using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ferreteria.Herramientas
{
    class moneda:TextBox
    {
        public moneda()
        {
            this.TextChanged += new EventHandler(eliminaTexto);
            this.KeyPress += new KeyPressEventHandler(teclaPres);
        }
        private void eliminaTexto(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.Text, "[^0-9,^0-9]"))
            {
                this.Text = this.Text.Remove(this.Text.Length - 1);
            }
        }

        private void teclaPres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(this.Text, @"\,\d\d") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public double valor()
        {
            double valor = Math.Round(double.Parse(this.Text),2);
            return valor;
        }

        public void asignarValor(double valor)
        {
            this.Text = valor.ToString();
        }
    }
}
