using Logic;
using Model;
using SimpleCrypto;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Login : System.Web.UI.Page
    {
        UsersLog objUserLog = new UsersLog();
        UserMod objUser = new UserMod();
        private string correo;
        private string contrasena;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            ICryptoService cryptoService = new PBKDF2();
            correo = TBCorreo.Text;
            contrasena = TBContrasena.Text;

            objUser = objUserLog.showUserMail(correo); //busca el correo del usuario
            if (objUser != null)
            {
                string passEncryp = cryptoService.Compute(contrasena, objUser.Salt);
                if (cryptoService.Compare(objUser.Contrasena, passEncryp))
                {
                    FormsAuthentication.RedirectFromLoginPage("Index.aspx", true);
                    TBCorreo.Text = "";
                    TBContrasena.Text = "";
                }
                else
                {
                    LblMsg.Text = "Correo o Contraseña Incorrectos";
                }
            }
            else
            {
                LblMsg.Text = "Correo o contraseña Incorrecto";
            }
        }
    }
}