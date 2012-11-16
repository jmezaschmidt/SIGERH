using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
<<<<<<< HEAD
using SIGERHSis.LibreriaComun.ModuloExpedientes;
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
using SIGERHSis.Logica.ModuloOrganizacion;

namespace SIGERHSis.Controladores.ModuloOrganizacion
{
    public class ControladorOrganizacion
    {
        private LogicaOrganizacion _LogicaOrganizacion;

        // Singleton
        private static ControladorOrganizacion _ControladorOrganizacion = new ControladorOrganizacion();

        private ControladorOrganizacion()
        {
            _LogicaOrganizacion = new LogicaOrganizacion();
        }

        public static ControladorOrganizacion obtenerControladorOrganizacion()
        {
            return _ControladorOrganizacion;
        }

        public List<Colaborador> obtenerColaboradores(Boolean pEstado)
        {
            return _LogicaOrganizacion.obtenerColaboradores(pEstado);
        }

        public List<Colaborador> obtenerColaboradoresFueraProyecto(String pProyecto)
        {
            return _LogicaOrganizacion.obtenerColaboradoresFueraProyecto(pProyecto);
        }

        public List<String> asignarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            return _LogicaOrganizacion.asignarColaboradoresProyecto(pColaboradores, pProyecto);
        }

        public Boolean crearProyecto(String pNombre, DateTime pFechaInicial, DateTime pFechaFinal, String pDescripcion)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.Nombre = pNombre;
            proyecto.FechaInicial = pFechaInicial;
            proyecto.FechaFinal = pFechaFinal;
            proyecto.Descripcion = pDescripcion;
            return _LogicaOrganizacion.crearProyecto(proyecto);
        }

<<<<<<< HEAD
        public List<Colaborador> obtenerColaboradoresFueraCapacitacion(int pIdCapacitacion)
=======
        public List<Colaborador> obtenerColaboradoresFuerCapacitacion(int pIdCapacitacion)
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
        {
            return _LogicaOrganizacion.obtenerColaboradoresFueraCapacitacion(pIdCapacitacion);
        }

        public List<String> asignarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            return _LogicaOrganizacion.asignarColaboradoresCapacitacion(pColaboradores, pIdCapacitacion);
        }

<<<<<<< HEAD
        public Boolean crearCapacitacion(String pNombre, DateTime pFechaInicial, DateTime pFechaFinal, String pDescripcion, int pDuracionEnHoras)
        {
            Capacitacion capacitacion = new Capacitacion();
            capacitacion.Nombre = pNombre;
            capacitacion.FechaInicial = pFechaInicial;
            capacitacion.FechaFinal = pFechaFinal;
            capacitacion.Descripcion = pDescripcion;
            capacitacion.DuracionEnHoras = pDuracionEnHoras;
            return _LogicaOrganizacion.crearCapacitacion(capacitacion);
        }

        public List<Proyecto> obtenerProyectos()
        {
            return _LogicaOrganizacion.obtenerProyectos();
        }

        public List<Capacitacion> obtenerCapacitaciones()
        {
            return _LogicaOrganizacion.obtenerCapacitaciones();
        }

        public List<Colaborador> obtenerColaboradoresProyecto(String pNombreProyecto)
        {
            return _LogicaOrganizacion.obtenerColaboradoresProyecto(pNombreProyecto);
        }

        public List<String> quitarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            return _LogicaOrganizacion.quitarColaboradoresProyecto(pColaboradores, pProyecto);
        }

        public List<Colaborador> obtenerColaboradoresCapacitacion(int pIdCapacitacion)
        {
            return _LogicaOrganizacion.obtenerColaboradoresCapacitacion(pIdCapacitacion);
        }

        public List<String> quitarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            return _LogicaOrganizacion.quitarColaboradoresCapacitacion(pColaboradores, pIdCapacitacion);
        }

        public Boolean asignarCapacitacionProyecto(String pNombreProyecto, int pIdCapacitacion)
        {
            return _LogicaOrganizacion.asignarCapacitacionProyecto(pNombreProyecto, pIdCapacitacion);
        }

        public List<String> obtenerDepartamentos()
        {
            return _LogicaOrganizacion.obtenerDepartamentos();
        }

<<<<<<< HEAD
        public List<String> obtenerPuestos()
        {
            return _LogicaOrganizacion.obtenerPuestos();
        }

        public Boolean crearDepartamento(String pNombre, String pDescripcion, String pPadre)
        {
            return _LogicaOrganizacion.crearDepartamento(pNombre, pDescripcion, pPadre);
        }
        public String verEstructuraOrganizacional()
        {
            return _LogicaOrganizacion.crearHTMLEstructuraOrg();
        }
=======
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
    }
}