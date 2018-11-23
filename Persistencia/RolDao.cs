using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private SqlConnection con = Conexion.getInstance().ConexionBD();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr = null;
        private int nr = 0;

        public List<Rol> dsListaRoles()
        {

            List<Rol> ListaRoles = new List<Rol>();

            try
            {
                cmd.Parameters.Clear();
                // con = Conexion.getInstance().ConexionBD();
                cmd.Connection = con;
                cmd.CommandText = "SELECT id_rol, de_rol FROM gmxc_roles;";
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

        public int InsertarRol (Rol pRolInstance)
        {

            try
            {
                cmd.Parameters.Clear();
                cmd = new SqlCommand("INSERT INTO gmxc_roles(de_rol) VALUES (@pDErol);", con);
                cmd.Parameters.AddWithValue("@pDErol", pRolInstance.DErol.ToString());
                cmd.CommandType = CommandType.Text;
                con.Open();
                if (cmd.ExecuteNonQuery() > 0 )
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT CAST(@@IDENTITY AS int)";
                    nr = (int)cmd.ExecuteScalar();
                }
                
            }
            catch (Exception ex)
            {
                nr = 0;
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return nr;
        }
    }
}
