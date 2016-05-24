using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "select Count(*) from LOGIN where username=? and password=?";
                using (MySqlConnection con = new MySqlConnection(Objetos.constantes.CONEXION_MYSQL))
                using (MySqlCommand cmd = new MySqlCommand(cmdText, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p2", txtPassword.Text); 
                    int result = int.Parse(cmd.ExecuteScalar().ToString());
                    if (result > 0)
                    {
                        frmVentas frm = new frmVentas();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtUsername.Focus();
                    }
                    con.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
