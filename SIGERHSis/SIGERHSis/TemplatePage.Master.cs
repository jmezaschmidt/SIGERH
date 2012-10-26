using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis
{
    public partial class TemplatePage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonExpediente_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormListaExpedientes.aspx");
        }

        protected void botonExpediente0_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormSolicitudesPendientes.aspx");
        }

        protected void botonExpediente1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormConstruccionDRH.aspx");
        }

        protected void botonExpediente2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormDepartamentos.aspx");
        }

        protected void botonExpediente3_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormReportarAusencia.aspx");
        }

        protected void botonExpediente4_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormAsignarCapacitaciones.aspx");
        }

        protected void botonExpediente5_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormConstruccionDRH.aspx");
        }

        protected void botonExpediente6_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormAsignarProyecto.aspx");
        }

        protected void botonExpediente5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormConstruccionDRH.aspx");
        }

        protected void botonExpediente6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormConstruccionDRH.aspx");
        }

        protected void botonExpediente7_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormConstruccionDRH.aspx");
        }

    }
}