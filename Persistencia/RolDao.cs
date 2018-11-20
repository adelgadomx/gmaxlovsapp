using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Persistencia
{
    public class RolDAO
    {
        #region "SingletonPatern"
        private static RolDAO objSigle = null;
        private RolDAO() { }
        public static RolDAO getInstance()
        {
            if (objSigle == null)
            {
                objSigle = new RolDAO();
            }
            return objSigle;
        }
        #endregion

        public List<Rol> dsListaRoles()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            List<Rol> ListaRoles = new List<Rol>();

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("SELECT id_rol, de_rol FROM gmxc_roles;", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Rol rol = new Rol();
                    rol.IDrol = Convert.ToInt32( dr["id_rol"].ToString() );
                    rol.DErol = dr["de_rol"].ToString();
                    ListaRoles.Add(rol);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return ListaRoles;
        }

    }
}
