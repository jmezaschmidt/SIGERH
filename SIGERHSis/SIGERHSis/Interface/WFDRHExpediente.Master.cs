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
        }

        protected void btnPermisos_Click(object sender, EventArgs e)
        {

            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHPermisosExp.aspx");
        }

        protected void btnVacacionesExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHVacacionesExp.aspx");
        }

        protected void btnIncapacidadesExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHIncapacidadesExp.aspx");
        }

        protected void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHCapacitacionesExp.aspx");
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHContratoExp.aspx");
        }
<<<<<<< HEAD

        protected void botonSolicitudes_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFRDHCrearProyecto.aspx");
        }
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
    }
}