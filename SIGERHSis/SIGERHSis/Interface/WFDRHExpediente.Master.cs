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

        protected void btnPermisos_Click(object sender, EventArgs e)
        {

            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHPermisosExp.aspx");
        }
    }
}