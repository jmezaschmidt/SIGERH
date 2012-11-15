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
        private LogicaExpedientes _LogicaExpedientes;
        private int _CedulaColaboradorActual;

        public ProxyExpediente()
        {
            _ExpedienteReal = new Expediente();
            _LogicaExpedientes = new LogicaExpedientes();
            _CedulaColaboradorActual = -1;
        }

        private Colaborador obtenerColaborador()
        {
            _ExpedienteReal.Colaborador = _LogicaExpedientes.obtenerColaborador(_CedulaColaboradorActual);
            return _ExpedienteReal.Colaborador;
        }

        public void iniciarExpediente(int pCedulaColaborador)
        {
            _CedulaColaboradorActual = pCedulaColaborador;
            _ExpedienteReal = new Expediente();
            _ExpedienteReal.Colaborador = obtenerColaborador();
        }

        public Colaborador obtenerInformacionGeneral()
        {
            return _ExpedienteReal.Colaborador;
        }

        public List<Contacto> obtenerContactos()
        {
            return _ExpedienteReal.Colaborador.Contactos;
        }

        public List<Permiso> obtenerPermisosColaborador()
        {
            if (_ExpedienteReal.Permisos == null)
            {
                _ExpedienteReal.Permisos = _LogicaExpedientes.obtenerPermisosColaborador(_CedulaColaboradorActual);
            }
            return _ExpedienteReal.Permisos;
        }

        public Boolean cambiarEstadoPermiso(int pIdSolicitud, String pNuevoEstado)
        {
            Boolean resultado = _LogicaExpedientes.cambiarEstadoSolicitud(pIdSolicitud, pNuevoEstado);
            if (resultado)
            {
                _ExpedienteReal.Permisos = _LogicaExpedientes.obtenerPermisosColaborador(_CedulaColaboradorActual);
                return resultado;
            }
            return false;
        }

        public List<Vacaciones> obtenerVacacionesColaborador()
        {
            if (_ExpedienteReal.Vacaciones == null)
            {
                _ExpedienteReal.Vacaciones = _LogicaExpedientes.obtenerVacacionesColaborador(_CedulaColaboradorActual);
            }
            return _ExpedienteReal.Vacaciones;
        }

        public Boolean cambiarEstadoVacaciones(int pIdSolicitud, String pNuevoEstado)
        {
            Boolean resultado = _LogicaExpedientes.cambiarEstadoSolicitud(pIdSolicitud, pNuevoEstado);
            if (resultado)
            {
                _ExpedienteReal.Vacaciones = _LogicaExpedientes.obtenerVacacionesColaborador(_CedulaColaboradorActual);
                return resultado;
            }
            return false;
        }

        public List<Incapacidad> obtenerIncapacidadesColaborador()
        {
            if (_ExpedienteReal.Incapacidades == null)
            {
                _ExpedienteReal.Incapacidades = _LogicaExpedientes.obtenerIncapacidadesColaborador(_CedulaColaboradorActual);
            }
            return _ExpedienteReal.Incapacidades;
        }

        public Boolean cambiarEstadoIncapacidades(int pIdSolicitud, String pNuevoEstado)
        {
            Boolean resultado = _LogicaExpedientes.cambiarEstadoSolicitud(pIdSolicitud, pNuevoEstado);
            if (resultado)
            {
                _ExpedienteReal.Incapacidades = _LogicaExpedientes.obtenerIncapacidadesColaborador(_CedulaColaboradorActual);
                return resultado;
            }
            return false;
        }

        public List<Capacitacion> obtenerCapacitacionesColaborador()
        {
            if (_ExpedienteReal.Capacitaciones == null)
            {
                _ExpedienteReal.Capacitaciones = _LogicaExpedientes.obtenerCapacitacionesColaborador(_CedulaColaboradorActual);
            }
            return _ExpedienteReal.Capacitaciones;
        }

        public Contrato obtenerContratoColaborador()
        {
            if (_ExpedienteReal.Contrato == null)
            {
                _ExpedienteReal.Contrato = _LogicaExpedientes.obtenerContratoColaborador(_CedulaColaboradorActual);
            }
            return _ExpedienteReal.Contrato;
        }

    }
}