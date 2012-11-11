using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.Controladores.ModuloExpedientes;
namespace SIGERHSis.Interface.ModuloExpedientes
{
    public partial class WFDRHContratoExp : System.Web.UI.Page
    {
        ControladorExpedientes controladorExpediente = ControladorExpedientes.obtenerControladorExpedientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarContrato();
        }
        private void cargarContrato()
        {
            Contrato contrato = controladorExpediente.obtenerContratoColaboradorPxy();
            lblCreacionInfo.Text = contrato.FechaCreacion.Day + "-"+ contrato.FechaCreacion.Month + "-" +contrato.FechaCreacion.Year ;
            lblCantidadHorasInfo.Text = contrato.CantidadHorasLaborales.ToString();
            lblEstado.Text = contrato.Estado;
        }
    }
}