using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            conexion.ConnectionString = "Data Source=10.52.3.249; Initial Catalog=gmaxDB; User ID=usrgmax; Password=P4$$w0rd";
            return conexion;
        }

        //public String GetConnectionString()
        //{
        //    return ConfigurationManager.ConnectionStrings["local_clinica"].ConnectionString;
        //}

    }
}
