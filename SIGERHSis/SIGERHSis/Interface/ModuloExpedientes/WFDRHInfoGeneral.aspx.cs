using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloExpedientes
{
    public partial class WFDRHInfoGeneral : System.Web.UI.Page
    {
        ControladorExpedientes controladorExpediente = ControladorExpedientes.obtenerControladorExpedientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            String cedula = Request.QueryString["cedula"];
            obtenerInformacionGeneral(cedula);
        }

        private void obtenerInformacionGeneral(String pCedula)
        {
            Colaborador colaborador = controladorExpediente.obtenerInformacionGeneral(int.Parse(pCedula));
            LabelInfoNombre.Text = colaborador.Nombre;
            LabelInfoCedula.Text = colaborador.Cedula+"";
            LabelInfoNacimiento.Text = colaborador.FechaNacimiento.Day + "-" + colaborador.FechaNacimiento.Month + "-" + colaborador.FechaNacimiento.Year;
            LabelInfoPuesto.Text = colaborador.Puesto;
            LabelInfoDepartemento.Text = colaborador.Departamento;
            LabelInfoIngreso.Text = colaborador.FechaIngreso.Day + "-" + colaborador.FechaIngreso.Month + "-" + colaborador.FechaIngreso.Year;
        }
    }
}