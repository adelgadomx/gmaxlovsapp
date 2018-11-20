using System;
using Modelo;
using Persistencia;

namespace Logica
{
    public class AccesoSistemaLG
    {
        #region "SingletonPattern"
        private static AccesoSistemaLG objSingle = null;
        private AccesoSistemaLG() { }
        public static AccesoSistemaLG getInstance()
        {
            if (objSingle == null)
            {
                objSingle = new AccesoSistemaLG();
            }
            return objSingle;
        }
        #endregion

        public UsuarioSistema Acceso (String _usr, String _pwd)
        {
            try
            {
                return UsuarioSistemaDAO.getInstance().AccesoSistema(_usr, _pwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
