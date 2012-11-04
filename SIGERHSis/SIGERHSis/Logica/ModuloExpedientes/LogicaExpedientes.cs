using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.AccesoDatos.ModuloExpedientes;

namespace SIGERHSis.Logica.ModuloExpedientes
{
    public class LogicaExpedientes
    {

        AccesoDatosExpedientes _AccesoDatosExpedientes;

        public LogicaExpedientes()
        {
            _AccesoDatosExpedientes = new AccesoDatosExpedientes();
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