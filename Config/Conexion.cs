using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Autores.Config
{
    class Conexion
    {
        private SqlConnection con = new SqlConnection("Server=SANTY\\SQLEXPRESS; Database=Biblioteca; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection CerrarConexcion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
