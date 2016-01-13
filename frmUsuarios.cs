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
    public partial class frmUsuarios : Ferreteria.frmMenu
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private bool validacionAgregaUsuario()
        {
            //Username
            if (string.IsNullOrEmpty(txtUsername.Text))
                epUsername.SetError(txtUsername, "El nombre de usuario no puede ir vacío");
            else
                epUsername.Clear();
            //Password
            if (string.IsNullOrEmpty(txtPassword.Text))
                epUsername.SetError(txtPassword, "La contraseña no puede ir vacía");
            else
                epUsername.Clear();
            //Confirmación
            if (string.IsNullOrEmpty(txtConfirmar.Text))
                epConfirmar.SetError(txtConfirmar, "Este campo no puede ir vacío");
            else if (txtPassword.Text != txtConfirmar.Text)
                epConfirmar.SetError(txtConfirmar, "Las contraseñas no coinciden");
            else
                epConfirmar.Clear();
            //Validación
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text != txtConfirmar.Text)
                return false;
            else
                return true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool valida = validacionAgregaUsuario();
            if(valida==true)
            {
                try
                {
                    OleDbConnection cnon = new OleDbConnection();
                    cnon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "INSERT INTO LOGIN (USERNAME, [PASSWORD]) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    cnon.Open();
                    command.Connection = cnon;
                    command.ExecuteNonQuery();
                    cnon.Close();
                    MessageBox.Show("Nuevo usuario agregado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    txtUsername.Focus();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarCampos()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
        }
    }
}
