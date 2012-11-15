using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.AccesoDatos.ModuloOrganizacion;

namespace SIGERHSis.Logica.ModuloOrganizacion
{
    public class LogicaOrganizacion
    {
        AccesoDatosOrganizacion _AccesoDatosOrganizacion;

        public LogicaOrganizacion()
        {
            _AccesoDatosOrganizacion = new AccesoDatosOrganizacion();
        }

        public List<Colaborador> obtenerColaboradores(Boolean pEstado)
        {
            return _AccesoDatosOrganizacion.obtenerColaboradores(pEstado);
        }

        public List<Colaborador> obtenerColaboradoresFueraProyecto(String pProyecto)
        {
            return _AccesoDatosOrganizacion.obtenerColaboradoresFueraProyecto(pProyecto);
        }

        public List<String> asignarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            return _AccesoDatosOrganizacion.asignarColaboradoresProyecto(pColaboradores, pProyecto);
        }

        public Boolean crearProyecto(Proyecto pProyecto)
        {
            return _AccesoDatosOrganizacion.crearProyecto(pProyecto);
        }

        public List<Colaborador> obtenerColaboradoresFueraCapacitacion(int pIdCapacitacion)
        {
            return _AccesoDatosOrganizacion.obtenerColaboradoresFueraCapacitacion(pIdCapacitacion);
        }

        public List<String> asignarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            return _AccesoDatosOrganizacion.asignarColaboradoresCapacitacion(pColaboradores, pIdCapacitacion);
        }

        public Boolean crearCapacitacion(Capacitacion pCapacitacion)
        {
            return _AccesoDatosOrganizacion.crearCapacitacion(pCapacitacion);
        }

        public List<Proyecto> obtenerProyectos()
        {
            return _AccesoDatosOrganizacion.obtenerProyectos();
        }

        public List<Capacitacion> obtenerCapacitaciones()
        {
            return _AccesoDatosOrganizacion.obtenerCapacitaciones();
        }

        public List<Colaborador> obtenerColaboradoresProyecto(String pNombreProyecto)
        {
            return _AccesoDatosOrganizacion.obtenerColaboradoresProyecto(pNombreProyecto);
        }

        public List<String> quitarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            return _AccesoDatosOrganizacion.quitarColaboradoresProyecto(pColaboradores, pProyecto);
        }

        public List<Colaborador> obtenerColaboradoresCapacitacion(int pIdCapacitacion)
        {
            return _AccesoDatosOrganizacion.obtenerColaboradoresCapacitacion(pIdCapacitacion);
        }
    }

}