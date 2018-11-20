using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Logica
{
    public class RolLG
    {
        #region "SingletonPattern"
        private static RolLG objSingle = null;
        private RolLG() { }
        public static RolLG getInstance()
        {
            if (objSingle == null)
            {
                objSingle = new RolLG();
            }
            return objSingle;
        }
        #endregion

        public List<Rol> ListarolesDS ()
        {
            try
            {
                return RolDAO.getInstance().dsListaRoles();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
