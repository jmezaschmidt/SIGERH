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

<<<<<<< HEAD
        public ProxyExpediente()
        {
=======
        public ProxyExpediente() {
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
            _ExpedienteReal = new Expediente();
            _LogicaExpedientes = new LogicaExpedientes();
            _CedulaColaboradorActual = -1;
        }

<<<<<<< HEAD
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
=======
        private Colaborador obtenerColaborador(int pCedulaClaborador)
        {
            _ExpedienteReal.Colaborador = _LogicaExpedientes.obtenerColaborador(pCedulaClaborador);
            return _ExpedienteReal.Colaborador;
        }

        public Colaborador obtenerInformacionGeneral(int pCedulaClaborador)
        {
            if (_CedulaColaboradorActual != pCedulaClaborador)
            {
                _ExpedienteReal = new Expediente();
                _ExpedienteReal.Colaborador = obtenerColaborador(pCedulaClaborador);
            }

            Colaborador colaborador = new Colaborador();
            colaborador.Cedula = _ExpedienteReal.Colaborador.Cedula;
            colaborador.Nombre = _ExpedienteReal.Colaborador.Nombre;
            colaborador.FechaNacimiento = _ExpedienteReal.Colaborador.FechaNacimiento;
            colaborador.Puesto = _ExpedienteReal.Colaborador.Puesto;
            colaborador.Departamento = _ExpedienteReal.Colaborador.Departamento;
            colaborador.FechaIngreso = _ExpedienteReal.Colaborador.FechaIngreso;
            colaborador.Estado = _ExpedienteReal.Colaborador.Estado;

            _CedulaColaboradorActual = pCedulaClaborador;

            return colaborador;
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
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
<<<<<<< HEAD
                _ExpedienteReal.Permisos = _LogicaExpedientes.obtenerPermisosColaborador(_CedulaColaboradorActual);
=======
                obtenerPermisosColaborador();
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
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
<<<<<<< HEAD
                _ExpedienteReal.Vacaciones = _LogicaExpedientes.obtenerVacacionesColaborador(_CedulaColaboradorActual);
=======
                obtenerVacacionesColaborador();
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
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
<<<<<<< HEAD
                _ExpedienteReal.Incapacidades = _LogicaExpedientes.obtenerIncapacidadesColaborador(_CedulaColaboradorActual);
=======
                obtenerIncapacidadesColaborador();
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
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

<<<<<<< HEAD
=======
        #region Properties Expediente
        /*
        public DateTime FechaCreacion
        {
            get { return _ExpedienteReal.FechaCreacion; }
            set { _ExpedienteReal.FechaCreacion = value; }
        }

        public Colaborador Colaborador
        {
            get { return _ExpedienteReal.Colaborador; }
            set { _ExpedienteReal.Colaborador = value; }
        }

        public List<Solicitud> Permisos
        {
            get { return _ExpedienteReal.Permisos; }
            set { _ExpedienteReal.Permisos = value; }
        }

        public List<Vacaciones> Vacaciones
        {
            get { return _ExpedienteReal.Vacaciones; }
            set { _ExpedienteReal.Vacaciones = value; }
        }

        public List<Solicitud> Incapacidades
        {
            get { return _ExpedienteReal.Incapacidades; }
            set { _ExpedienteReal.Incapacidades = value; }
        }

        public List<Ausencia> HistorialAusencias
        {
            get { return _ExpedienteReal.HistorialAusencias; }
            set { _ExpedienteReal.HistorialAusencias = value; }
        }

        public List<Capacitacion> Capacitaciones
        {
            get { return _ExpedienteReal.Capacitaciones; }
            set { _ExpedienteReal.Capacitaciones = value; }
        }

        public List<Proyecto> Proyecto
        {
            get { return _ExpedienteReal.Proyecto; }
            set { _ExpedienteReal.Proyecto = value; }
        }

        public Contrato Contrato
        {
            get { return _ExpedienteReal.Contrato; }
            set { _ExpedienteReal.Contrato = value; }
        }
        */
        #endregion
        
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
    }
}