using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPelicula
{
    class ConexionBD
    {
        static private string CadenaConexion=@"Data Source = JOEL\SQLEXPRESS; Initial Catalog = Peliculas; Integrated Security = True";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
                
            }
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
                
            }
            return Conexion;
        }




    }
}
