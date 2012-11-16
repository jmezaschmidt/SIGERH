using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFDRHEstructura : System.Web.UI.Page
    {
        ControladorOrganizacion _controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            verEstructuraOrganizacional();
            
        }
        public void verEstructuraOrganizacional()
        {
            organigrama.InnerHtml = _controladorOrganizacion.verEstructuraOrganizacional();
        }
    }
}