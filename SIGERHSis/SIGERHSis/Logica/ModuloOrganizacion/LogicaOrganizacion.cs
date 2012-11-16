﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
<<<<<<< HEAD
using SIGERHSis.LibreriaComun.ModuloExpedientes;
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
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

<<<<<<< HEAD
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
<<<<<<< HEAD

        public List<String> quitarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            return _AccesoDatosOrganizacion.quitarColaboradoresCapacitacion(pColaboradores, pIdCapacitacion);
        }

        public Boolean asignarCapacitacionProyecto(String pNombreProyecto, int pIdCapacitacion)
        {
            return _AccesoDatosOrganizacion.asignarCapacitacionProyecto(pNombreProyecto, pIdCapacitacion);
        }

        public List<String> obtenerDepartamentos()
        {
            return _AccesoDatosOrganizacion.obtenerDepartamentos();
        }

        public List<String> obtenerPuestos()
        {
            return _AccesoDatosOrganizacion.obtenerPuestos();
        }

        public Boolean crearDepartamento(String pNombre, String pDescripcion, String pPadre)
        {
            return _AccesoDatosOrganizacion.crearDepartamento(pNombre, pDescripcion, pPadre);
        }
        public String crearHTMLEstructuraOrg()
        {
            String html = "";
            List<Departamento> departamentos = _AccesoDatosOrganizacion.obtenerDepartamentosEstructura();

            html += "<ul id=" + "\"org\" style=\"display:none\"" + "><li>Departamentos<ul>";
            for (int i = 0; i < departamentos.Count; i++)
            {
                if (departamentos[i].Padre.Equals("Sin asignar"))
                {
                    html += "<li>" + departamentos[i].Nombre + "<ul>" + recorridoArbol(departamentos[i].Nombre);
                    html += "</ul></li>";
                }
            }
            html += "</ul></li><ul>";
            return html;
        }


        private String recorridoArbol(String padre)
        {
            String phtml = "";
            List<Departamento> departamentos = _AccesoDatosOrganizacion.obtenerDepartamentosEstructura();
            for (int i = 0; i < departamentos.Count; i++)
            {
                if (departamentos[i].Padre.Equals(padre))
                {
                    phtml += "<li>" + departamentos[i].Nombre + "<ul>";
                    phtml += recorridoArbol(departamentos[i].Nombre);
                    phtml += "</ul></li>";
                }
            }
            return phtml;
        }

=======
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
    }

}