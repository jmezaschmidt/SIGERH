using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.Logica.ModuloExpedientes
{
    public class ProxyExpediente : IExpediente
    {
        private Expediente _ExpedienteReal;

        public ProxyExpediente() {
            _ExpedienteReal = new Expediente();
        }

        public DateTime getFechaCreacion(int pCedulaClaborador);
        public void setFechaCreacion();

        public Colaborador getColaborador(int pCedulaClaborador);
        public void setColaborador();

        public List<Solicitud> getPermisos(int pCedulaClaborador);
        public void setPermisos();

        public List<Vacaciones> getVacaciones(int pCedulaClaborador);
        public void setVacaciones();

        public List<Solicitud> getIncapacidades(int pCedulaClaborador);
        public void setIncapacidades();

        public List<Ausencia> getHistorialAusencias(int pCedulaClaborador);
        public void setHistorialAusencias();

        public List<Capacitacion> getCapacitaciones(int pCedulaClaborador);
        public void setCapacitaciones();

        public List<Proyecto> getProyecto(int pIdClaborador);
        public void setProyecto();

        public Contrato getContrato(int pIdClaborador);
        public void setContrato();
        
    }
}