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
        public double doubPrecioUnitario;
        public List<string[]> lista;

        public producto()
        {
            strMensaje = null;
            blnRetorno = false;
            strNombreProducto = null;
            doubPrecioUnitario = 0;
            lista = new List<string[]>();
        }

        //Método que devuelve un booleano si el producto tiene
        //existencias, de lo contrario arroja un mensaje de error
        public bool consulta(string id, int cantidad)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "conProducto";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@retorno", null);
                cmd.Parameters["@retorno"].Direction = ParameterDirection.Output;

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
                else if(strMensaje!=null)
                {
                    MessageBox.Show(strMensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return blnRetorno;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al consultar existencias del producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método que consulta el precio de venta del producto tomando como referencia la
        //cantidad de la venta actual, para aplicar precio de mayoreo o menudeo según corresponda
        public double consultaPrecio(string id,int cantidad)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "conPrecio";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.Parameters.AddWithValue("@precio", null);
                cmd.Parameters["@precio"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                doubPrecioUnitario = double.Parse(cmd.Parameters["@precio"].Value.ToString());
                return doubPrecioUnitario;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al consultar precio del producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //Llena la lista de los productos a comprar
        public void agregaLista(string[] arreglo)
        {
            lista.Add(arreglo);
        }

        //Método que se encarga de ingresar las ventas a la tabla de ventas del día y reducir las existencias
        public bool procesaVenta()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            conn.Open();
            MySqlTransaction trans;
            trans = conn.BeginTransaction();
            foreach (string[] arr in lista)
            {
                string sp = "venta";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = trans;
                try
                {
                    cmd.Parameters.AddWithValue("@nombre", arr[0]);
                    cmd.Parameters.AddWithValue("@id", arr[1]);
                    cmd.Parameters.AddWithValue("@cantidad", arr[2]);
                    cmd.Parameters.AddWithValue("@precio", arr[3]);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    try
                    {
                        trans.Rollback();
                    }
                    catch (MySqlException mse)
                    {
                        MessageBox.Show("Fallo en rollback: " + mse.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    MessageBox.Show("Falló la conexión con la base de datos al procesar la venta: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            trans.Commit();
            return true;
        }

    }
}