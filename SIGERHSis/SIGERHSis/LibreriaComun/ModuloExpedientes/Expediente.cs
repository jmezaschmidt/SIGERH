using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.LibreriaComun.ModuloExpedientes
{
    public class Expediente : IExpediente
    {

        private DateTime _FechaCreacion;
        private Colaborador _Colaborador;
        private List<Permiso> _Permisos;
        private List<Vacaciones> _Vacaciones;
        private List<Incapacidad> _Incapacidades;
        private List<Ausencia> _HistorialAusencias;
        private List<Capacitacion> _Capacitaciones;
        private List<Proyecto> _Proyecto;
        private Contrato _Contrato;

        #region Properties

        public DateTime FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public Colaborador Colaborador
        {
            get { return _Colaborador; }
            set { _Colaborador = value; }
        }

        public List<Permiso> Permisos
        {
            get { return _Permisos; }
            set { _Permisos = value; }
        }

        public List<Vacaciones> Vacaciones
        {
            get { return _Vacaciones; }
            set { _Vacaciones = value; }
        }

        public List<Incapacidad> Incapacidades
        {
            get { return _Incapacidades; }
            set { _Incapacidades = value; }
        }

        public List<Ausencia> HistorialAusencias
        {
            get { return _HistorialAusencias; }
            set { _HistorialAusencias = value; }
        }

        public List<Capacitacion> Capacitaciones
        {
            get { return _Capacitaciones; }
            set { _Capacitaciones = value; }
        }

        public List<Proyecto> Proyecto
        {
            get { return _Proyecto; }
            set { _Proyecto = value; }
        }

        public Contrato Contrato
        {
            get { return _Contrato; }
            set { _Contrato = value; }
        }

        #endregion

    }
}