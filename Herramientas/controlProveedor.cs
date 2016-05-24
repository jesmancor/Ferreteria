using System;
using System.Windows.Forms;

namespace Ferreteria.Herramientas
{
    class controlProveedor:TextBox
    {
        public controlProveedor()
        {
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(desplegar);
            this.TextChanged += new EventHandler(texto);
            this.Size = new System.Drawing.Size(46, 20);
            this.MaxLength = 3;
        }

        private void texto(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, "[^0-9]"))
            {
                this.Text = this.Text.Remove(this.Text.Length - 1);
            }
            if (this.Text.Length >= 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void desplegar(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.Text = consultaPorDescripcion();
            }
        }

        private string consultaPorDescripcion()
        {
            using (var form = new vtnProveedor())
            {
                var resultado = form.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    string valor = form.valor;
                    return valor;
                }
                else
                    return null;
            }
        }
    }
}
