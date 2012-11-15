using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFDRHCrearCapacitacion : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void crearCapacitacion()
        {
            String capacitacion = TextBoxNombreCapacitacion.Text;
            DateTime fInicial = Convert.ToDateTime(fechaInicial.Text);
            DateTime fFinal = Convert.ToDateTime(fechaFinal.Text);

            String descripcion = TextBoxDescripcion.Text;
            String duracion = TextBoxDuracion.Text;
            controladorOrganizacion.crearCapacitacion(capacitacion, fInicial, fFinal, descripcion, int.Parse(duracion));
        }
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            crearCapacitacion();
        }
    }
}