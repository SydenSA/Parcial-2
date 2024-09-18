namespace Autores.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using Autores.Config;
   

    class AutoresModel
    {
        public int autor_id { get; set; }
        public string nombre { get; set; }


        List<AutoresModel> Lista_Autor = new List<AutoresModel>();
      
        private Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<AutoresModel> todos()
        { 
            string cadena = "select *  from autores";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow Autor in tabla.Rows)
            {
                AutoresModel nuevoautor = new AutoresModel
                {
                    autor_id = Convert.ToInt32(Autor["autor_id"]),
                    nombre = Autor["nombre"].ToString()
                };
                Lista_Autor.Add(nuevoautor);
            }

            conexion.CerrarConexcion();
            return Lista_Autor;
        }
        public AutoresModel uno(AutoresModel Autor)
        { 
            string cadena = "select * from autores where autor_id=" + Autor.autor_id;
            cmd = new SqlCommand(cadena, conexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            AutoresModel autoregresa = new AutoresModel
            {
                autor_id = Convert.ToInt32(lector["autor_id"]),
                nombre = lector["nombre"].ToString()
            };
            conexion.CerrarConexcion();
            return autoregresa;
        }
        public string insertar(AutoresModel Autor)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into autores(nombre) values('" + Autor.nombre + "')";
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
        public string actualizar(AutoresModel Autor)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update autores set nombre='" + Autor.nombre + "' where autor_id=" + Autor.autor_id;
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
        public string eliminar(AutoresModel Autor)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "delete from autores where autor_id =" + Autor.autor_id;
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
