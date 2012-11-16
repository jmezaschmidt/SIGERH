using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloExpedientes;
using SIGERHSis.Controladores.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloExpedientes
{
    public partial class WFCrearContrato : System.Web.UI.Page
    {
        ControladorExpedientes controlador = ControladorExpedientes.obtenerControladorExpedientes();
        ControladorOrganizacion controladorOrg = ControladorOrganizacion.obtenerControladorOrganizacion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
               
            }

        }

        protected void botonCrearContrato_Click(object sender, EventArgs e)
        {

        }
    }
}