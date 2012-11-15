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

        // Singleton
        private static ControladorExpedientes _ControladorExpedientes = new ControladorExpedientes();

        private ControladorExpedientes()
        {
            _LogicaExpedientes = new LogicaExpedientes();
            _Expediente = new ProxyExpediente();
        }

        public static ControladorExpedientes obtenerControladorExpedientes()
        {
            return _ControladorExpedientes;
        }

        public void iniciarExpediente(int pCedulaColaborador)
        {
            _Expediente.iniciarExpediente(pCedulaColaborador);
        }

        public Colaborador obtenerInformacionGeneral()
        {
            return _Expediente.obtenerInformacionGeneral();
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

        public Boolean crearColaborador(String pNombre, String pApellidoUno, String pApellidoDos, int pCedula,
                                        DateTime pFechaNac, String pTipoUsuario, String pDepart, String pPuesto)
        {
            return _LogicaExpedientes.crearColaborador(pNombre, pApellidoUno, pApellidoDos, pCedula, pFechaNac, pTipoUsuario, pDepart, pPuesto);
        }

        public Boolean crearContrato(int pCedula, int pCantidadHoras)
        {
            return _LogicaExpedientes.crearContrato(pCedula, pCantidadHoras);
        }

        public Boolean crearSolicitud(int pCedula, DateTime pFechaInicial, DateTime pFechaFinal, String pMotivo, String pTipoSolicitud)
        {
            Solicitud solicitud = new Solicitud();
            solicitud.FechaInicial = pFechaInicial;
            solicitud.FechaFinal = pFechaFinal;
            solicitud.Motivo = pMotivo;
            return _LogicaExpedientes.crearSolicitud(pCedula, solicitud, pTipoSolicitud);
        }

    }
}