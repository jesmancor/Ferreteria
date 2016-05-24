using System;
using System.Windows.Forms;

namespace Ferreteria.Herramientas
{
    class doble:TextBox
    {
        public doble()
        {
            this.TextChanged += new EventHandler(texto);
        }
        private void texto(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, "[^0-9,^0-9]"))
            {
                this.Text = this.Text.Remove(this.Text.Length - 1);
            }
        }
    }
}
