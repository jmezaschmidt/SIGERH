using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface
{
    public partial class WebFormListaExpedientes : System.Web.UI.Page
    {


        protected void ButtonVerExpediente_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:1491/Interface/WebFormInfoGeneralExpediente.aspx");
        }
    }
}