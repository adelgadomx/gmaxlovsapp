using System;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using Modelo;
using Persistencia;
using Presentacion.Custom;

namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["UserSession"] = null;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            // string user = txtUsuario.Text;
            // string password = txtPassword.Text;
            // string userName = "adelgado";
            // string passName = "4ug02000";
            //if (user.Equals(userName) && password.Equals(passName))
        
            UsuarioSistema _Usuario = UsuarioSistemaDAO.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);
        
            if (_Usuario != null)
            {
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script> alert ('Usuario Incorrecto'); </script>");
            }
        }

        // protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        // {
        //     bool auth = Membership.ValidateUser(LoginUser.UserName, LoginUser.Password);
        // 
        //     if (auth)
        //     {
        //         UsuarioSistema _Usuario = UsuarioSistemaDAO.getInstance().AccesoSistema(LoginUser.UserName, LoginUser.Password);
        // 
        //         if (_Usuario != null)
        //         {
        //             SessionIDManager = new SessionManager(Session);
        //             // Bonus 1:
        //             //SessionManager.UserSession = objEmpleado.Nombre.ToString();
        //             SessionManager.UserSessionObjeto = _Usuario;
        // 
        //             //Response.Redirect("PanelGeneral.aspx");
        //             FormsAuthentication.RedirectFromLoginPage(LoginUser.UserName, false);
        //         }
        //         else
        //         {
        //             Response.Write("<script>alert('USUARIO INCORRECTO.')</script>");
        //         }
        //     }
        // }
    }
}