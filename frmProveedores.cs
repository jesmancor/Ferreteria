using System;
using Ferreteria.Objetos;
using System.Windows.Forms;
using System.ComponentModel;

namespace Ferreteria
{
    public partial class frmProveedores : frmMenu
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                proveedor Proveedor = new proveedor();
                if (Proveedor.validaExistencia(txtID.Text))
                {
                    txtNombre.Text = Proveedor.NombreProveedor;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
                else
                {
                    DialogResult pregunta = MessageBox.Show("¿Desea dar de alta el proovedor con ID " + txtID.Text + "?", "¿Dar de alta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pregunta == DialogResult.Yes)
                    {
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        txtID.Text = string.Empty;
                        btnAgregar.Enabled = false;
                    }
                }
            }
        }

        private void txtID_GotFocus(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string nombre = txtNombre.Text;
            proveedor Proveedor = new proveedor();
            if(Proveedor.alta(id, nombre))
            {
                txtID.Text = string.Empty;
                txtID.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string nombre = txtNombre.Text;
            proveedor Proveedor = new proveedor();
            if (Proveedor.modificar(id, nombre))
            {
                txtID.Text = string.Empty;
                txtID.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Desea dar de baja el proovedor con ID " + txtID.Text + "?", "¿Dar de baja?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                proveedor Proveedor = new proveedor();
                if (Proveedor.baja(txtID.Text))
                {
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
            }
        }
    }
}
