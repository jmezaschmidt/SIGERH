using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SIGERHSis.Interface.ModuloUsuarios
{
    public partial class WFDRHPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Attributes.Add("onKeyUp", "searchTable()");
        }
    }
}