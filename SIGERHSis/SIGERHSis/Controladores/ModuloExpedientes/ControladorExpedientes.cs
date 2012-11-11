using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.Logica.ModuloExpedientes;

namespace SIGERHSis.Controladores.ModuloExpedientes
{
    public class ControladorExpedientes
    {
        private LogicaExpedientes _LogicaExpedientes;
        private ProxyExpediente _Expediente;

        public ControladorExpedientes()
        {
            _LogicaExpedientes = new LogicaExpedientes();
            _Expediente = new ProxyExpediente();
        }


        public Colaborador obtenerInformacionGeneral(int pCedulaClaborador)
        {
            return _Expediente.obtenerInformacionGeneral(pCedulaClaborador);
        }

        public List<Contacto> obtenerContactosPxy()
        {
            List<Contacto> listaContactos = _Expediente.obtenerContactos();
            return listaContactos;
        }

        public List<Permiso> obtenerPermisosColaboradorPxy()
        {
            List<Permiso> listaPermisos = _Expediente.obtenerPermisosColaborador();
            return listaPermisos;
        }
        // ---->
        public Boolean cambiarEstadoPermisoPxy(int pIdSolicitud, String pNuevoEstado)
        {
            return _Expediente.cambiarEstadoPermiso(pIdSolicitud, pNuevoEstado);
        }

        public List<Vacaciones> obtenerVacacionesColaboradorPxy()
        {
            List<Vacaciones> listaVacaciones = _Expediente.obtenerVacacionesColaborador();
            return listaVacaciones;
        }

        public Boolean cambiarEstadoVacacionesPxy(int pIdSolicitud, String pNuevoEstado)
        {
            return _Expediente.cambiarEstadoVacaciones(pIdSolicitud, pNuevoEstado);
        }

        public List<Incapacidad> obtenerIncapacidadesColaboradorPxy()
        {
            List<Incapacidad> listaIncapacidades = _Expediente.obtenerIncapacidadesColaborador();
            return listaIncapacidades;
        }

        public Boolean cambiarEstadoIncapacidadesPxy(int pIdSolicitud, String pNuevoEstado)
        {
            return _Expediente.cambiarEstadoIncapacidades(pIdSolicitud, pNuevoEstado);
        }

        public List<Capacitacion> obtenerCapacitacionesColaboradorPxy()
        {
            List<Capacitacion> listaCapacitaciones = _Expediente.obtenerCapacitacionesColaborador();
            return listaCapacitaciones;
        }

        public Contrato obtenerContratoColaboradorPxy()
        {
            return _Expediente.obtenerContratoColaborador();
        }


    }
}