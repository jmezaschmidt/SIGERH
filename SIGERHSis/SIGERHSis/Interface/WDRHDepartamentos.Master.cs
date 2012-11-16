using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface
{
    public partial class WDRHDepartamentos : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonExpedientes_Click(object sender, EventArgs e)
        {

        }

        protected void botonSolicitudes_Click(object sender, EventArgs e)
        {

        }

        protected void botonVacaciones_Click(object sender, EventArgs e)
        {

        }

        protected void botonDepartamentos_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
        }

        protected void botonAusencias_Click(object sender, EventArgs e)
        {

        }

        protected void botonCapacitaciones_Click(object sender, EventArgs e)
        {

        }

        protected void botonPuestos_Click(object sender, EventArgs e)
        {

        }

        protected void botonProyectos_Click(object sender, EventArgs e)
        {

        }

        protected void botonReportes_Click(object sender, EventArgs e)
        {

        }

        protected void btnVerEstructura_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
        }

        protected void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFcrearDepartamento.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFcrearDepartamento.aspx");
        }
    }
}