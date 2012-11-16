using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using System.Drawing;

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

            DateTime fInicial;
            DateTime fFinal;
            bool parsefInicial = DateTime.TryParse(fechaInicial.Text, out fInicial);
            bool parsefFinal = DateTime.TryParse(fechaFinal.Text, out fFinal);
            String descripcion = TextBoxDescripcion.Text;

            if (proyecto.Equals("") || !parsefFinal || !parsefInicial || descripcion.Equals(""))
            {
                LabelResultado.ForeColor = Color.Red;
                LabelResultado.Text = "Campos en Blanco";
            }
            else
            {
                bool resultado = controladorOrganizacion.crearProyecto(proyecto, fInicial, fFinal, descripcion);
                if (resultado)
                {
                    LabelResultado.ForeColor = Color.Green;
                    LabelResultado.Text = "Capacitacion creada con exito";
                }
                else
                {
                    LabelResultado.ForeColor = Color.Red;
                    LabelResultado.Text = "El nombre especificado para el proyecto ya existe";
                }
            }
        }

        protected void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            crearProyecto();
        }
    }
}