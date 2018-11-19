using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "adelgado";
            string passName = "4ug02000";

            if (user.Equals(userName) && password.Equals(passName))
                //Empleado objEmpleado = EmpleadoLN.getInstance().AccesoDatos(txtusuario.Text, txtPassword.Text);

                //if (objEmpleado != null)
            {
                Response.Write("<script> alert ('Usuario Correcto'); </script>");
            }
            else
            {
                Response.Write("<script> alert ('Usuario Incorrecto'); </script>");
            }
        }
    }
}