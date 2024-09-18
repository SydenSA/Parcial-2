namespace Libros.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using Autores.Config;

    class LibrosModel
    {
        public int libro_id { get; set; }
        public string titulo { get; set; }
        public int autor_id { get; set; }
        public int editorial_id { get; set; }

        List<LibrosModel> Lista_Libros = new List<LibrosModel>();

        private Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<LibrosModel> todos()
        {
            string cadena = "select * from libros";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow Libro in tabla.Rows)
            {
                LibrosModel nuevoLibro = new LibrosModel
                {
                    libro_id = Convert.ToInt32(Libro["libro_id"]),
                    titulo = Libro["titulo"].ToString(),
                    autor_id = Convert.ToInt32(Libro["autor_id"]),
                    editorial_id = Convert.ToInt32(Libro["editorial_id"])
                };
                Lista_Libros.Add(nuevoLibro);
            }

            conexion.CerrarConexcion();
            return Lista_Libros;
        }

        public LibrosModel uno(LibrosModel Libro)
        {
            string cadena = "select * from libros where libro_id=" + Libro.libro_id;
            cmd = new SqlCommand(cadena, conexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            LibrosModel libroRegresa = new LibrosModel
            {
                libro_id = Convert.ToInt32(lector["libro_id"]),
                titulo = lector["titulo"].ToString(),
                autor_id = Convert.ToInt32(lector["autor_id"]),
                editorial_id = Convert.ToInt32(lector["editorial_id"])
            };
            conexion.CerrarConexcion();
            return libroRegresa;
        }

        public string insertar(LibrosModel Libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into libros(titulo, autor_id, editorial_id) values('" + Libro.titulo + "', " + Libro.autor_id + ", " + Libro.editorial_id + ")";
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

        public string actualizar(LibrosModel Libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update libros set titulo='" + Libro.titulo + "', autor_id=" + Libro.autor_id + ", editorial_id=" + Libro.editorial_id + " where libro_id=" + Libro.libro_id;
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

        public string eliminar(LibrosModel Libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "delete from libros where libro_id=" + Libro.libro_id;
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
