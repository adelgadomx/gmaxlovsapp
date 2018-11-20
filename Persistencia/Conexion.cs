using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Persistencia
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            // "Data Source=10.52.3.249; Initial Catalog=gmaxDB; User ID=usrgmax; Password=P4$$w0rd";
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["gmaxDB"].ConnectionString;
            return conexion;
        }

    }
}
