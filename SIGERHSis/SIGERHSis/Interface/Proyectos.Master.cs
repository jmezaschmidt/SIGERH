﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface
{
    public partial class Proyectos : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:17482/Interface/ModuloOrganizacion/WFRDHCrearProyecto.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloOrganizacion/WFRDHCrearProyecto.aspx");
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
    }
}