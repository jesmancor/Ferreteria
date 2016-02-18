using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ferreteria.Objetos
{
    public class producto
    {
        public bool blnRetorno { get; set; }
        public string strMensaje { get; set; }
        public string strNombreProducto { get; set; }
        public double doubPrecioUnitario { get; set; }

        public producto()
        {
            strMensaje = null;
            blnRetorno = false;
            strNombreProducto = null;
            doubPrecioUnitario = 0;
        }
        public bool consulta(string id, int cantidad)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string rtn = "conProducto";
                MySqlCommand cmd = new MySqlCommand(rtn, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.Parameters.AddWithValue("@retorno",null);
                cmd.Parameters["@retorno"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@mensaje",null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@nombre", null);
                cmd.Parameters["@nombre"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                blnRetorno = Convert.ToBoolean(int.Parse(cmd.Parameters["@retorno"].Value.ToString()));
                strMensaje = cmd.Parameters["@mensaje"].Value.ToString();
                strNombreProducto = cmd.Parameters["@nombre"].Value.ToString();
                conn.Close();
                if (!blnRetorno)
                {
                    MessageBox.Show(strMensaje, "No es posible realizar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return blnRetorno;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public double consultaPrecio()
        {
            return 0;
        }
    }
}