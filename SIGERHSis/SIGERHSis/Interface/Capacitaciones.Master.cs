using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class Capacitaciones : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnAsignarColaboradores_Click(object sender, EventArgs e)
        {

        }


        protected void btnCrearCapacitacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
        }

        protected void botonCapacitaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHCrearCapacitacion.aspx");
        }

        protected void btnAsignarColaboradores_Click1(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHAsignarColaboradoresCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHAsignarColaboradoresCapacitacion.aspx");
        }

        protected void btnQuitarColaboradores_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHQuitarColaboradoresCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHQuitarColaboradoresCapacitacion.aspx");
        }

        protected void btnAsignarProyectos_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFDRHAsignarProyectoCapacitacion.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFDRHAsignarProyectoCapacitacion.aspx");
        }

     

        
    }
}