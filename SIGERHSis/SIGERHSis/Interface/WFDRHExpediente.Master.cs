using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface
{
    public partial class WFDRHExpediente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInformacionGeneralExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
        }

        protected void btnPermisos_Click(object sender, EventArgs e)
        {

            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHPermisosExp.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHPermisosExp.aspx");
        }

        protected void btnVacacionesExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHVacacionesExp.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHVacacionesExp.aspx");
        }

        protected void btnIncapacidadesExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHIncapacidadesExp.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHIncapacidadesExp.aspx");
        }

        protected void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHCapacitacionesExp.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHCapacitacionesExp.aspx");
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHContratoExp.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHContratoExp.aspx");
        }

        protected void botonSolicitudes_Click(object sender, EventArgs e)
        {
            
        }

        protected void botonExpedientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloUsuarios/WFDRHPrincipal.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloUsuarios/WFDRHPrincipal.aspx");
        }

        protected void botonProyectos_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFRDHCrearProyecto.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFRDHCrearProyecto.aspx");
        }

        protected void botonCapacitaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
        }

        protected void botonDepartamentos_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHEstructura.aspx");
        }
    }
}