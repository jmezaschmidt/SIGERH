using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.Logica.ModuloOrganizacion;

namespace SIGERHSis.Controladores.ModuloOrganizacion
{
    public class ControladorOrganizacion
    {
        private LogicaOrganizacion _LogicaOrganizacion;

        public ControladorOrganizacion()
        {
            _LogicaOrganizacion = new LogicaOrganizacion();
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

    }
}