using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFRDHCrearProyecto : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void crearProyecto()
        {
            String proyecto = TextBoxNombreProyecto.Text;
            DateTime fInicial = Convert.ToDateTime(fechaInicial.Text);
            DateTime fFinal = Convert.ToDateTime(fechaFinal.Text);
            
            String descripcion = TextBoxDescripcion.Text;
            controladorOrganizacion.crearProyecto(proyecto, fInicial, fFinal, descripcion);
            
        }

        protected void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            crearProyecto();
        }
    }
}