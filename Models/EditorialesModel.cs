namespace Editoriales.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using Autores.Config;

    class EditorialesModel
    {
        public int editorial_id { get; set; }
        public string nombre { get; set; }

        List<EditorialesModel> Lista_Editorial = new List<EditorialesModel>();

        private Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<EditorialesModel> todos()
        {
            string cadena = "select * from editoriales";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow Editorial in tabla.Rows)
            {
                EditorialesModel nuevaEditorial = new EditorialesModel
                {
                    editorial_id = Convert.ToInt32(Editorial["editorial_id"]),
                    nombre = Editorial["nombre"].ToString()
                };
                Lista_Editorial.Add(nuevaEditorial);
            }

            conexion.CerrarConexcion();
            return Lista_Editorial;
        }

        public EditorialesModel uno(EditorialesModel Editorial)
        {
            string cadena = "select * from editoriales where editorial_id=" + Editorial.editorial_id;
            cmd = new SqlCommand(cadena, conexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            EditorialesModel editorialRegresa = new EditorialesModel
            {
                editorial_id = Convert.ToInt32(lector["editorial_id"]),
                nombre = lector["nombre"].ToString()
            };
            conexion.CerrarConexcion();
            return editorialRegresa;
        }

        public string insertar(EditorialesModel Editorial)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into editoriales(nombre) values('" + Editorial.nombre + "')";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }

        public string actualizar(EditorialesModel Editorial)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update editoriales set nombre='" + Editorial.nombre + "' where editorial_id=" + Editorial.editorial_id;
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }

        public string eliminar(EditorialesModel Editorial)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "delete from editoriales where editorial_id =" + Editorial.editorial_id;
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }
    }
}
