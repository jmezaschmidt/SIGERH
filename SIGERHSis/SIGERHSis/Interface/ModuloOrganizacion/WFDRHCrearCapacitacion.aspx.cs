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
    public partial class WFDRHCrearCapacitacion : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        public void crearCapacitacion()
        {
            String capacitacion = TextBoxNombreCapacitacion.Text;
            DateTime fInicial;
            DateTime fFinal;
            int duracion;
            bool parsefInicial = DateTime.TryParse(fechaInicial.Text, out fInicial);
            bool parsefFinal = DateTime.TryParse(fechaFinal.Text, out fFinal);            
            String descripcion = TextBoxDescripcion.Text;
            bool parseDuracion = int.TryParse(TextBoxDuracion.Text, out duracion);
            if(capacitacion.Equals("") || !parsefFinal || !parsefInicial || descripcion.Equals("") || duracion.Equals(""))
            {
                LabelResultado.ForeColor = Color.Red;
                LabelResultado.Text = "Campos en Blanco";
            }
            else
            {
                controladorOrganizacion.crearCapacitacion(capacitacion, fInicial, fFinal, descripcion, duracion);
                LabelResultado.ForeColor = Color.Green;
                LabelResultado.Text = "Capacitacion creada con exito";
            }

            
        }
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            crearCapacitacion();
        }
    }
}