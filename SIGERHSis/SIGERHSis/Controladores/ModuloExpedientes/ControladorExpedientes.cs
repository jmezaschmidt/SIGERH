using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.Logica.ModuloExpedientes;

namespace SIGERHSis.Controladores.ModuloExpedientes
{
    public class ControladorExpedientes
    {
        LogicaExpedientes _LogicaExpedientes;

        public ControladorExpedientes()
        {
            _LogicaExpedientes = new LogicaExpedientes();
        }

        public DateTime getFechaCreacion(int pCedulaClaborador);
        public Colaborador getColaborador(int pCedulaClaborador);
        public List<Solicitud> getPermisos(int pCedulaClaborador);
        public List<Vacaciones> getVacaciones(int pCedulaClaborador);
        public List<Solicitud> getIncapacidades(int pCedulaClaborador);
        public List<Ausencia> getHistorialAusencias(int pCedulaClaborador);
        public List<Capacitacion> getCapacitaciones(int pCedulaClaborador);
        public List<Proyecto> getProyecto(int pIdClaborador);
        public Contrato getContrato(int pIdClaborador);

    }
}