using System;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class vtnCantidad : Form
    {
        public string retornoCantidad { get; set; }

        public vtnCantidad()
        {
            InitializeComponent();
        }

        private void sumar()
        {
            int intCantidad = int.Parse(txtCantidad.Text);
            intCantidad++;
            txtCantidad.Text = intCantidad.ToString();
        }

        private void restar()
        {
            int intCantidad = int.Parse(txtCantidad.Text);
            if (intCantidad>0)
                intCantidad--;
            txtCantidad.Text = intCantidad.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    sumar();
                    return true;
                case Keys.Down:
                    restar();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                retornoCantidad = txtCantidad.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                retornoCantidad = null;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            retornoCantidad = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
