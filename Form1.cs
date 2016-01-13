using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ferreteria.accdb";
                string cmdText = "select Count(*) from LOGIN where USERNAME=? and [PASSWORD]=?";
                using (OleDbConnection con = new OleDbConnection(constring))
                using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p2", txtPassword.Text); 
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        frmVentas frm = new frmVentas();
                        frm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
