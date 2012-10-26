using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis
{
    public partial class TemplatePageExpediente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_InfoGeneral_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormInfoGeneralExpediente.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormPermisosExp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormVacacionesExp.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormIncapacidadesExp.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormCapacitacionesExp.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormContrato.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormDocumentosExp.aspx");
        }

        protected void botonExpediente_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormListarExpedientes.aspx");
        }

        protected void botonExpediente0_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormSolicitudesPendientes.aspx");
        }

        protected void botonExpediente1_Click(object sender, EventArgs e)
        {

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

        }       

    }
}