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

        public Colaborador obtenerColaborador(int pCedulaClaborador)
        {
            return _AccesoDatosExpedientes.obtenerColaborador(pCedulaClaborador);
        }

        private List<Solicitud> obtenerSolicitudesColaborador(int pCedulaClaborador, String pTipoSolicitud)
        {
            return _AccesoDatosExpedientes.obtenerSolicitudesColaborador(pCedulaClaborador, pTipoSolicitud);
        }

        public List<Permiso> obtenerPermisosColaborador(int pCedulaClaborador)
        {
            List<Solicitud> solicitudes = _AccesoDatosExpedientes.obtenerSolicitudesColaborador(pCedulaClaborador, "Permiso");
            List<Permiso> permisos = new List<Permiso>();

            for (int i = 0; i < solicitudes.Count; i++)
            {
                Permiso _permiso = new Permiso();
                Solicitud _solicitud = solicitudes.ElementAt(i);
                _permiso.FechaSolicitud = _solicitud.FechaSolicitud;
                _permiso.FechaInicial = _solicitud.FechaInicial;
                _permiso.FechaFinal = _solicitud.FechaFinal;
                _permiso.Estado = _solicitud.Estado;
                _permiso.Motivo = _solicitud.Motivo;
                _permiso.Id = _solicitud.Id;
                permisos.Add(_permiso);
            }

            return permisos;
        }

        public List<Vacaciones> obtenerVacacionesColaborador(int pCedulaClaborador)
        {
            List<Solicitud> solicitudes = _AccesoDatosExpedientes.obtenerSolicitudesColaborador(pCedulaClaborador, "Vacaciones");
            List<Vacaciones> vacaciones = new List<Vacaciones>();

            for (int i = 0; i < solicitudes.Count; i++)
            {
                Vacaciones _vacaciones = new Vacaciones();
                Solicitud _solicitud = solicitudes.ElementAt(i);
                _vacaciones.FechaSolicitud = _solicitud.FechaSolicitud;
                _vacaciones.FechaInicial = _solicitud.FechaInicial;
                _vacaciones.FechaFinal = _solicitud.FechaFinal;
                _vacaciones.Estado = _solicitud.Estado;
                _vacaciones.Motivo = _solicitud.Motivo;
                _vacaciones.Id = _solicitud.Id;
                vacaciones.Add(_vacaciones);
            }

            return vacaciones;
        }

        public List<Incapacidad> obtenerIncapacidadesColaborador(int pCedulaClaborador)
        {
            List<Solicitud> solicitudes = _AccesoDatosExpedientes.obtenerSolicitudesColaborador(pCedulaClaborador, "Incapacidad");
            List<Incapacidad> incapacidades = new List<Incapacidad>();

            for (int i = 0; i < solicitudes.Count; i++)
            {
                Incapacidad _incapacidades = new Incapacidad();
                Solicitud _solicitud = solicitudes.ElementAt(i);
                _incapacidades.FechaSolicitud = _solicitud.FechaSolicitud;
                _incapacidades.FechaInicial = _solicitud.FechaInicial;
                _incapacidades.FechaFinal = _solicitud.FechaFinal;
                _incapacidades.Estado = _solicitud.Estado;
                _incapacidades.Motivo = _solicitud.Motivo;
                _incapacidades.Id = _solicitud.Id;
                incapacidades.Add(_incapacidades);
            }

            return incapacidades;
        }

        public List<Capacitacion> obtenerCapacitacionesColaborador(int pCedulaClaborador)
        {
            return _AccesoDatosExpedientes.obtenerCapacitacionesColaborador(pCedulaClaborador);
        }

        public Boolean cambiarEstadoSolicitud(int pIdSolicitud, String pNuevoEstado)
        {
            return _AccesoDatosExpedientes.cambiarEstadoSolicitud(pIdSolicitud, pNuevoEstado);
        }

        public Contrato obtenerContratoColaborador(int pCedulaClaborador)
        {
            return _AccesoDatosExpedientes.obtenerContratoColaborador(pCedulaClaborador);
        }

    }
}