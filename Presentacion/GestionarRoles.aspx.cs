using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Logica;
using System.Web.Services;

namespace Presentacion
{
    public partial class GestionarRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                mvMainRoles.ActiveViewIndex = 1;
            }
        }

        private Rol setRolInstance()
        {
            Rol insRol = new Rol();
            insRol.DErol = txtDescripcion.Text;
            return insRol;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear instancia de Rol
            Rol objRol = setRolInstance();

            // Envia a la capade Logica
            int nr = RolLG.getInstance().RegistrarRol(objRol);
            if (nr > 0)
            {
                Response.Write(String.Format("<script>alert('Registro creado #{0} Correctamente');</script>", nr));
            }
            else
            {
                Response.Write("<script>alert('Registro Fallido');</script>");
            }
            Response.Redirect("PanelGeneral.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("PanelGeneral.aspx");
            txtDescripcion.Text = null;
            mvMainRoles.ActiveViewIndex = 1;
        }

        [WebMethod]
        public static List<Rol> ListarRoles ()
        {
            List<Rol> Lista = null;

            try
            {
                Lista = Logica.RolLG.getInstance().ListarolesDS();
            }
            catch (Exception ex)
            {
                Lista = null;
                throw ex;
            }
            return Lista;
        }

        protected void btnAltaAction_Click(object sender, EventArgs e)
        {
            mvMainRoles.ActiveViewIndex = 0;
        }
    }
}