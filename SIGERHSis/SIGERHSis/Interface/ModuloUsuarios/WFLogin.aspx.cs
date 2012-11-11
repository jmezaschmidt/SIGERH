using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloUsuarios;

namespace SIGERHSis.Interface.ModuloUsuarios
{
    public partial class WFLogin : System.Web.UI.Page
    {
        ControladorUsuarios controladorUsuario =new ControladorUsuarios();

        protected void Page_Load(object sender, EventArgs e){
        
            
        }

        protected void buttonIngresar_Click(object sender, EventArgs e)
        {
            String usuario = textBoxUsuario.Text;
            String contrasena = textBoxContrasena.Text;
            String tipoUsuario = dropDownListTipoUsuario.SelectedItem.Text;
            if (controladorUsuario.autenticarUsuario(usuario, contrasena, tipoUsuario))
            {
                Response.Redirect("http://localhost:17482/Interface/ModuloUsuarios/WFDRHPrincipal.aspx?dato1=hola");
            }
            else
            {
                Label3.Text = "Usuario: *";
                Label1.Text = "Contraseña: *";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label3.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }
}