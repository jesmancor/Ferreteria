using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LibPrintTicket;

namespace Ferreteria.Objetos
{
    public class producto
    {
        //Variables de retorno para consulta
        public bool blnRetorno { get; set; }
        public double doubPrecioUnitario;
        public string strMensaje { get; set; }

        //Campos de la tabla producto para el alta
        public string strNombreProducto { get; set; }
        public string strID { get; set; }
        public string strTipo { get; set; }
        public string strDescripcion { get; set; }
        public string strMayoreo { get; set; }
        public string strMenudeo { get; set; }
        public string strDescuento { get; set; }
        public string strExistencias { get; set; }
        public string strMinimo { get; set; }
        public string strMaximo { get; set; }
        public string strReorden { get; set; }
        public string strProveedor { get; set; }
        public string strCantidad { get; set; }

        //Constantes para el arreglo de datos del producto
        private const int ARR_NOMBRE = 0;
        private const int ARR_ID = 1;
        private const int ARR_CANTIDAD = 2;
        private const int ARR_PRECIO = 3;

        //Constantes para el tipo de consulta
        private const int CON_VENTA = 1;
        private const int CON_MOD = 2;
        private const int CON_BUSQ = 3;

        //Constantes para el tipo de modificación
        private const int MODI_UNO = 1;
        private const int MODI_DOS = 2;

        //Lista para ingresar todos los productos de la venta al sp
        public List<string[]> lista;

        public producto()
        {
            strMensaje = null;
            blnRetorno = false;
            doubPrecioUnitario = 0;
            lista = new List<string[]>();
            strNombreProducto = null;
            strID = null;
            strTipo = null;
            strDescripcion = null;
            strMayoreo = null;
            strMenudeo = null;
            strDescuento = null;
            strExistencias = null;
            strMinimo = null;
            strMaximo = null;
            strReorden = null;
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

                cmd.Parameters.AddWithValue("@descripcion", null);

                cmd.Parameters.AddWithValue("@tipoCon", CON_VENTA);

                cmd.ExecuteNonQuery();
                blnRetorno = Convert.ToBoolean(int.Parse(cmd.Parameters["@retorno"].Value.ToString()));
                strMensaje = cmd.Parameters["@mensaje"].Value.ToString();
                strNombreProducto = cmd.Parameters["@nombre"].Value.ToString();
                conn.Close();
                if (!blnRetorno)
                {
                    MessageBox.Show(strMensaje, "No es posible realizar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (strMensaje != "nulo")
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
        public double consultaPrecio(string id, int cantidad)
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
                try
                {
                    string sp = "venta";
                    MySqlCommand cmd = new MySqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = trans;
                    cmd.Parameters.AddWithValue("@nombre", arr[ARR_NOMBRE]);
                    cmd.Parameters.AddWithValue("@id", arr[ARR_ID]);
                    cmd.Parameters.AddWithValue("@cantidad", arr[ARR_CANTIDAD]);
                    cmd.Parameters.AddWithValue("@precio", arr[ARR_PRECIO]);
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

        //Método que agrega un nuevo producto a la base de datos
        public bool altaProducto()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "productoAlta";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", strID);
                cmd.Parameters.AddWithValue("@nombre", strNombreProducto);
                cmd.Parameters.AddWithValue("@tipo", strTipo);
                cmd.Parameters.AddWithValue("@descripcion", strDescripcion);
                cmd.Parameters.AddWithValue("@pMenudeo", strMenudeo);
                cmd.Parameters.AddWithValue("@pMayoreo", strMayoreo);
                cmd.Parameters.AddWithValue("@descuento", strDescuento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto " + strNombreProducto + " fue agregado", "Registro agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de alta el producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método que modifica un producto existente
        public bool modificarProducto()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "productoMod";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", strID);
                cmd.Parameters.AddWithValue("@nombre", strNombreProducto);
                cmd.Parameters.AddWithValue("@tipo", strTipo);
                cmd.Parameters.AddWithValue("@descripcion", strDescripcion);
                cmd.Parameters.AddWithValue("@pMenudeo", strMenudeo);
                cmd.Parameters.AddWithValue("@pMayoreo", strMayoreo);
                cmd.Parameters.AddWithValue("@descuento", strDescuento);
                cmd.Parameters.AddWithValue("@nuevaExistencia", null);
                cmd.Parameters.AddWithValue("@maximo", null);
                cmd.Parameters.AddWithValue("@minimo", null);
                cmd.Parameters.AddWithValue("@reorden", null);
                cmd.Parameters.AddWithValue("@proveedor", null);
                cmd.Parameters.AddWithValue("@cantidad", null);
                cmd.Parameters.AddWithValue("@tipoMod", MODI_UNO);
                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto " + strNombreProducto + " fue modificado", "Producto modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al modificar el producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método que modifica las existencias de un producto
        public bool agregarExistencias()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "productoMod";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", strID);
                cmd.Parameters.AddWithValue("@nombre", null);
                cmd.Parameters.AddWithValue("@tipo", null);
                cmd.Parameters.AddWithValue("@descripcion", null);
                cmd.Parameters.AddWithValue("@pMenudeo", null);
                cmd.Parameters.AddWithValue("@pMayoreo", null);
                cmd.Parameters.AddWithValue("@descuento", null);
                cmd.Parameters.AddWithValue("@nuevaExistencia", strExistencias);
                cmd.Parameters.AddWithValue("@maximo", strMaximo);
                cmd.Parameters.AddWithValue("@minimo", strMinimo);
                cmd.Parameters.AddWithValue("@reorden", strReorden);
                cmd.Parameters.AddWithValue("@proveedor", strProveedor);
                cmd.Parameters.AddWithValue("@cantidad", strCantidad);
                cmd.Parameters.AddWithValue("@tipoMod", MODI_DOS);
                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;
                int exito = cmd.ExecuteNonQuery();
                conn.Close();
                string mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                if (exito > 0)
                {
                    MessageBox.Show("El producto " + strNombreProducto + " fue modificado", "Existencias actualizadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error al aregar existencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al agregar existencias: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarProducto()
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "productoBaja";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", strID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto " + strNombreProducto + " fue dado de baja", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de baja el producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método que imprime ticket con la información de los productos vendidos
        public void imprimeTicket(double doubTotalVenta, double retorno, double efectivo)
        {
            try
            {
                Ticket ticket = new Ticket();

                ticket.AddHeaderLine("Ferretería y Tlapalería");
                ticket.AddHeaderLine("'Los Jilgueros'");
                ticket.AddHeaderLine("Calle 10 Oriente, # 1150,");
                ticket.AddHeaderLine("Villas De Carrizalejo,");
                ticket.AddHeaderLine("Ciénega de Flores, Nuevo León");

                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                foreach (string[] arr in lista)
                {
                    ticket.AddItem(arr[ARR_CANTIDAD], arr[ARR_NOMBRE], "$" + arr[ARR_PRECIO]);
                }

                ticket.AddTotal("SUBTOTAL :", "");
                ticket.AddTotal("IVA :", "");
                ticket.AddTotal("TOTAL :", "$" + doubTotalVenta.ToString());
                ticket.AddTotal("RECIBIDO :", "$" + efectivo.ToString());
                ticket.AddTotal("CAMBIO :", "$" + retorno.ToString());

                ticket.AddFooterLine("VUELVA PRONTO");

                ticket.PrintTicket("doPDF 8"); //Nombre de la impresora de tickets
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que realiza una consulta para validar que un producto se encuentre registrado en la base de datos
        public bool valida(string id)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "conProducto";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@cantidad", null);

                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@retorno", null);
                cmd.Parameters["@retorno"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@nombre", null);
                cmd.Parameters["@nombre"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@descripcion", null);

                cmd.Parameters.AddWithValue("@tipoCon", CON_MOD);

                MySqlDataReader resultadoBD = cmd.ExecuteReader();
                if (resultadoBD.Read())
                {
                    strID = id;
                    strNombreProducto = resultadoBD["NOMBRE_PRODUCTO"].ToString();
                    strDescripcion = resultadoBD["DESCRIPCION_PRODUCTO"].ToString();
                    strTipo = resultadoBD["TIPO_PRODUCTO"].ToString();
                    strMenudeo = resultadoBD["PRECIO_MENUDEO"].ToString();
                    strMayoreo = resultadoBD["PRECIO_MAYOREO"].ToString();
                    strDescuento = resultadoBD["DESCUENTO"].ToString();
                    strExistencias = resultadoBD["EXISTENCIAS"].ToString();
                    strMaximo = resultadoBD["MAXIMO_PRODUCTO"].ToString();
                    strMinimo = resultadoBD["MINIMO_PRODUCTO"].ToString();
                    strReorden = resultadoBD["REORDENAR"].ToString();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al consultar existencias del producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método que devuelve una lista de productos que coincidan con la búsqueda ingresada
        public List<string[]> busquedaProducto(string descripcion)
        {
            List<string[]> Lista = new List<string[]>();
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "conProducto";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", null);

                cmd.Parameters.AddWithValue("@cantidad", null);

                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@retorno", null);
                cmd.Parameters["@retorno"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@nombre", null);
                cmd.Parameters["@nombre"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.Parameters.AddWithValue("@tipoCon", CON_BUSQ);

                MySqlDataReader resultadoBD = cmd.ExecuteReader();
                while (resultadoBD.Read())
                {
                    string[] arreglo = new string[5];
                    arreglo[0] = resultadoBD["ID_PRODUCTO"].ToString();
                    arreglo[1] = resultadoBD["NOMBRE_PRODUCTO"].ToString();
                    arreglo[2] = resultadoBD["DESCRIPCION_PRODUCTO"].ToString();
                    arreglo[3] = resultadoBD["PRECIO_MENUDEO"].ToString();
                    arreglo[4] = resultadoBD["PRECIO_MAYOREO"].ToString();
                    Lista.Add(arreglo);
                }
                conn.Close();
                return Lista;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al buscar el producto: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lista.Clear();
                return Lista;
            }
        }
    }
}