using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ferreteria.Objetos
{
    class sistema
    {
        public static bool cierreDeDia()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "pasarahistorico";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DialogResult respuesta = MessageBox.Show("¿Desea realizar el cierre de día y pasar las ventas del día a histórico?", "¿Realizar cierre de día?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    cmd.ExecuteScalar();
                    MessageBox.Show("Se realizó el cierre de día", "Cierre de día", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al realizar el cierre de día: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
