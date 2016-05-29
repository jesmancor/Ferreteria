﻿using System;
using System.Windows.Forms;

namespace Ferreteria.Herramientas
{
    class entero:TextBox
    {
        public entero()
        {
            this.TextChanged += new EventHandler(eliminaTexto);
            this.KeyPress += new KeyPressEventHandler(teclaPres);
        }
        private void eliminaTexto(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, "[^0-9]"))
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
        }
        public int valor()
        {
            int valor = int.Parse(this.Text);
            return valor;
        }

        public void asignarValor(int valor)
        {
            this.Text = valor.ToString();
        }
    }
}
