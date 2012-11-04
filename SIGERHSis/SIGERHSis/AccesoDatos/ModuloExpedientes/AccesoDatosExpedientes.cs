using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.AccesoDatos.ModuloExpedientes
{
    public class AccesoDatosExpedientes
    {

        AccesoDatos _AccesoDatos;
        
        public AccesoDatosExpedientes() {
            _AccesoDatos = new AccesoDatos();    
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