using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Logica;

namespace Presentacion
{
    public partial class PanelGeneral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Rol> dsRoles = RolLG.getInstance().ListarolesDS();
            GridView1.DataSource = dsRoles;
            GridView1.DataBind();
        }
    }
}