﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Ferreteria.Objetos
{
    public class proveedor
    {
        //Varibles
        public string strIDProveedor { get; set; }
        public string strNombreProveedor { get; set; }

        public proveedor()
        {
            strIDProveedor = null;
            strNombreProveedor = null;
        }

        //Método que realiza una consulta para validar si un proveedor existe o no
        public bool validaExistencia(string id)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            bool existe = false;
            try
            {
                conn.Open();
                string sp = "proveedorCon";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", null);
                cmd.Parameters.AddWithValue("@tipoCon", 1);

                MySqlDataReader resultadoBD = cmd.ExecuteReader();
                if (resultadoBD.Read())
                {
                    strNombreProveedor = resultadoBD["NOMBRE_PROVEEDOR"].ToString();
                    existe = true;
                }
                else
                {
                    existe = false;
                }
                conn.Close();
                return existe;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de alta el proveedor: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método para dar de alta un proveedor a la base de datos
        public bool alta(string id, string nombre)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "proveedorAlta";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                int exito = cmd.ExecuteNonQuery();
                conn.Close();

                string mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                if (exito > 0)
                {
                    MessageBox.Show("Se dio de alta el proveedor correctamente", "Registro agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error al dar de alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de alta el proveedor: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método para dar de alta un proveedor a la base de datos
        public bool modificar(string id, string nombre)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "proveedorMod";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.Parameters.AddWithValue("@mensaje", null);
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;

                int exito = cmd.ExecuteNonQuery();
                conn.Close();

                string mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                if (exito > 0)
                {
                    MessageBox.Show("Se modificó el proveedor correctamente", "Registro agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error al dar de alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de alta el proveedor: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool baja(string id)
        {
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "proveedorBaja";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Se dio de baja el proveedor con ID " + id, "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Falló la conexión con la base de datos al dar de baja el proveedor: " + exc.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<string[]> busqueda(string nombre)
        {
            List<string[]> Lista = new List<string[]>();
            MySqlConnection conn = new MySqlConnection(constantes.CONEXION_MYSQL);
            try
            {
                conn.Open();
                string sp = "proveedorCon";
                MySqlCommand cmd = new MySqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tipoCon", 2);

                MySqlDataReader resultadoBD = cmd.ExecuteReader();
                while (resultadoBD.Read())
                {
                    string[] arreglo = new string[2];
                    arreglo[0] = resultadoBD["ID_PROVEEDOR"].ToString();
                    arreglo[1] = resultadoBD["NOMBRE_PROVEEDOR"].ToString();
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