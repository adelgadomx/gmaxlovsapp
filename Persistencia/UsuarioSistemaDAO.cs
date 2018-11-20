using System;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Persistencia
{
    public class UsuarioSistemaDAO
    {
        #region "SingletonPatern"
        private static UsuarioSistemaDAO objSigle = null;
        private UsuarioSistemaDAO() { }
        public static UsuarioSistemaDAO getInstance()
        {
            if (objSigle == null)
            {
                objSigle = new UsuarioSistemaDAO();
            }
            return objSigle;
        }
        #endregion

        public UsuarioSistema AccesoSistema (String _user, String _password)
        {
            SqlConnection Cnx = null;
            SqlCommand Cmd = null;
            UsuarioSistema usr = null;
            SqlDataReader dr = null;

            try
            {
                Cnx = Conexion.getInstance().ConexionBD();
                Cmd = new SqlCommand("SELECT id_persona, de_nombre_completo, es_vigente " +
                    "                   FROM gmxc_personas " +
                    "                  WHERE cv_username=@pUsr AND cv_password=@pPwd;", Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@pUsr", _user);
                Cmd.Parameters.AddWithValue("@pPwd", _password);
                Cnx.Open();
                dr = Cmd.ExecuteReader();
                if ( dr.Read() )
                {
                    usr = new UsuarioSistema();
                    usr.id_persona = Convert.ToInt32(dr["id_persona"].ToString());
                    usr.de_nombre_completo = dr["de_nombre_completo"].ToString();
                    usr.es_vigente = dr["es_vigente"].ToString();
                }

            }
            catch (Exception ex)
            {
                usr = null;
                throw ex;
            }
            finally
            {
                Cnx.Close();
            }
            return usr;
        }

    }
}
