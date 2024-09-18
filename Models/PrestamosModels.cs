namespace Prestamos.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using Autores.Config;

    class PrestamosModel
    {
        public int prestamo_id { get; set; }
        public int libro_id { get; set; }
        public int usuario_id { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime? fecha_devolucion { get; set; }

        List<PrestamosModel> Lista_Prestamos = new List<PrestamosModel>();

        private Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<PrestamosModel> todos()
        {
            string cadena = "select * from prestamos";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow Prestamo in tabla.Rows)
            {
                PrestamosModel nuevoPrestamo = new PrestamosModel
                {
                    prestamo_id = Convert.ToInt32(Prestamo["prestamo_id"]),
                    libro_id = Convert.ToInt32(Prestamo["libro_id"]),
                    usuario_id = Convert.ToInt32(Prestamo["usuario_id"]),
                    fecha_prestamo = Convert.ToDateTime(Prestamo["fecha_prestamo"]),
                    fecha_devolucion = Prestamo["fecha_devolucion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(Prestamo["fecha_devolucion"])
                };
                Lista_Prestamos.Add(nuevoPrestamo);
            }

            conexion.CerrarConexcion();
            return Lista_Prestamos;
        }

        public PrestamosModel uno(PrestamosModel Prestamo)
        {
            string cadena = "select * from prestamos where prestamo_id=" + Prestamo.prestamo_id;
            cmd = new SqlCommand(cadena, conexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            PrestamosModel prestamoRegresa = new PrestamosModel
            {
                prestamo_id = Convert.ToInt32(lector["prestamo_id"]),
                libro_id = Convert.ToInt32(lector["libro_id"]),
                usuario_id = Convert.ToInt32(lector["usuario_id"]),
                fecha_prestamo = Convert.ToDateTime(lector["fecha_prestamo"]),
                fecha_devolucion = lector["fecha_devolucion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(lector["fecha_devolucion"])
            };
            conexion.CerrarConexcion();
            return prestamoRegresa;
        }

        public string insertar(PrestamosModel Prestamo)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into prestamos(libro_id, usuario_id, fecha_prestamo, fecha_devolucion) values("
                    + Prestamo.libro_id + ", " + Prestamo.usuario_id + ", '" + Prestamo.fecha_prestamo.ToString("yyyy-MM-dd") + "', "
                    + (Prestamo.fecha_devolucion.HasValue ? "'" + Prestamo.fecha_devolucion.Value.ToString("yyyy-MM-dd") + "'" : "NULL") + ")";
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

        public string actualizar(PrestamosModel Prestamo)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update prestamos set libro_id=" + Prestamo.libro_id + ", usuario_id=" + Prestamo.usuario_id
                    + ", fecha_prestamo='" + Prestamo.fecha_prestamo.ToString("yyyy-MM-dd") + "', fecha_devolucion="
                    + (Prestamo.fecha_devolucion.HasValue ? "'" + Prestamo.fecha_devolucion.Value.ToString("yyyy-MM-dd") + "'" : "NULL")
                    + " where prestamo_id=" + Prestamo.prestamo_id;
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

        public string eliminar(PrestamosModel Prestamo)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "delete from prestamos where prestamo_id=" + Prestamo.prestamo_id;
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
