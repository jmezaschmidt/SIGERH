﻿using System;
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
            Response.Redirect("http://localhost:1491/Interface/WebFormInfoGeneralExpediente.aspx");
        }
    }
}