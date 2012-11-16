﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
<<<<<<< HEAD
using SIGERHSis.LibreriaComun.ModuloExpedientes;
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

namespace SIGERHSis.AccesoDatos.ModuloOrganizacion
{
    public class AccesoDatosOrganizacion
    {
        private AccesoDatos _AccesoDatos;

        public AccesoDatosOrganizacion()
        {
            _AccesoDatos = new AccesoDatos();    
        }

        
        public List<Colaborador> obtenerColaboradores(Boolean pEstado)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            String[] nombreParametros = { "@habilitado" };

            IDataReader reader = _AccesoDatos.leer("sp_verColaboradores", nombreParametros, pEstado);

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
                _colaborador.Nombre = reader.GetString(0);
                _colaborador.Cedula = reader.GetInt32(1);
                _colaborador.Puesto = reader.GetString(2);
                _colaborador.Departamento = reader.GetString(3);
                colaboradores.Add(_colaborador);
            }

            reader.Close();
            return colaboradores;
        }

        public List<Colaborador> obtenerColaboradoresFueraProyecto(String pProyecto)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
<<<<<<< HEAD
            String[] nombreParametros = { "@nombre" };
=======
            String[] nombreParametros = { "@proyecto" };
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

            IDataReader reader = _AccesoDatos.leer("sp_verAspirantesProyecto", nombreParametros, pProyecto);

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
<<<<<<< HEAD
                _colaborador.Cedula = reader.GetInt32(0);
                _colaborador.Nombre = reader.GetString(1);
=======
                _colaborador.Nombre = reader.GetString(0);
                _colaborador.Cedula = reader.GetInt32(1);
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
                _colaborador.Puesto = reader.GetString(2);
                _colaborador.Departamento = reader.GetString(3);
                colaboradores.Add(_colaborador);
            }

            reader.Close();
            return colaboradores;
        }

        public List<String> asignarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            List<String> colaboradoresSinAsignar = new List<String>();
            String[] nombreParametros = { "@nombre", "@cedula" };

            for (int i = 0; i < pColaboradores.Count; i++)
            {
<<<<<<< HEAD
                Boolean resultado = _AccesoDatos.escribir("sp_asignarProyectoColaborador", nombreParametros, pProyecto, pColaboradores.ElementAt(i).Cedula);
=======
                Boolean resultado = _AccesoDatos.escribir("sp_asignarProyectoColaborador", nombreParametros, pColaboradores.ElementAt(i).Cedula, pProyecto);
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
                if (resultado == false)
                {
                    colaboradoresSinAsignar.Add(pColaboradores.ElementAt(i).Nombre);
                }
            }
            return colaboradoresSinAsignar;
        }

        public Boolean crearProyecto(Proyecto pProyecto)
        {
            String[] nombreParametros = { "@nombre", "@descripcion", "@fechaInicio", "@fechaFinal" };
            return _AccesoDatos.escribir("sp_crearProyecto", nombreParametros, pProyecto.Nombre, pProyecto.Descripcion, pProyecto.FechaInicial, pProyecto.FechaFinal);
        }

<<<<<<< HEAD
        public List<Colaborador> obtenerColaboradoresFueraCapacitacion(int pIdCapacitacion)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            String[] nombreParametros = { "@idCapacitacion" };

            IDataReader reader = _AccesoDatos.leer("sp_verAspirantesCapacitacion", nombreParametros, pIdCapacitacion);

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
                _colaborador.Nombre = reader.GetString(0);
                _colaborador.Cedula = reader.GetInt32(1);
                _colaborador.Puesto = reader.GetString(2);
                _colaborador.Departamento = reader.GetString(3);
                colaboradores.Add(_colaborador);
            }

            reader.Close();
            return colaboradores;
        }

        public List<String> asignarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            List<String> colaboradoresSinAsignar = new List<String>();
            String[] nombreParametros = { "@cedula", "@idCapacitacion" };
=======
        public List<String> asignarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            List<String> colaboradoresSinAsignar = new List<String>();
            String[] nombreParametros = { "@idCapacitacion", "@cedula" };
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

            for (int i = 0; i < pColaboradores.Count; i++)
            {
                Boolean resultado = _AccesoDatos.escribir("sp_asignarCapacitacionColaborador", nombreParametros, pColaboradores.ElementAt(i).Cedula, pIdCapacitacion);
                if (resultado == false)
                {
                    colaboradoresSinAsignar.Add(pColaboradores.ElementAt(i).Nombre);
                }
            }
            return colaboradoresSinAsignar;
        }

<<<<<<< HEAD
        public Boolean crearCapacitacion(Capacitacion pCapacitacion)
        {
            String[] nombreParametros = { "@nombre", "@descripcion", "duracion", "@fechaInicial", "@fechaFinal" };
            return _AccesoDatos.escribir("sp_crearCapacitacion", nombreParametros, pCapacitacion.Nombre, pCapacitacion.Descripcion, 
                                        pCapacitacion.DuracionEnHoras, pCapacitacion.FechaInicial, pCapacitacion.FechaFinal);
        }

        public List<Proyecto> obtenerProyectos()
        {
            String[] nombreParametros = { };
            List<Proyecto> proyectos = new List<Proyecto>();

            IDataReader reader = _AccesoDatos.leer("sp_verProyectos", nombreParametros);

            while (reader.Read())
            {
                Proyecto _proyecto = new Proyecto();
                _proyecto.Nombre = reader.GetString(0);
                _proyecto.Descripcion = reader.GetString(1);
                _proyecto.FechaInicial = reader.GetDateTime(2);
                _proyecto.FechaFinal = reader.GetDateTime(3);
                _proyecto.Estado = reader.GetString(4);
                proyectos.Add(_proyecto);
            }

            reader.Close();
            return proyectos;
        }

        public List<Capacitacion> obtenerCapacitaciones()
        {
            String[] nombreParametros = { };
            List<Capacitacion> capacitaciones = new List<Capacitacion>();

            IDataReader reader = _AccesoDatos.leer("sp_verCapacitaciones", nombreParametros);

            while (reader.Read())
            {
                Capacitacion _capacitacion = new Capacitacion();
                _capacitacion.Id = reader.GetInt32(0);
                _capacitacion.Nombre = reader.GetString(1);
                _capacitacion.FechaInicial = reader.GetDateTime(2);
                _capacitacion.FechaFinal = reader.GetDateTime(3);
                _capacitacion.Descripcion = reader.GetString(4);
                _capacitacion.DuracionEnHoras = reader.GetInt32(5);
                capacitaciones.Add(_capacitacion);
            }

            reader.Close();
            return capacitaciones;
        }

        public List<Colaborador> obtenerColaboradoresProyecto(String pNombreProyecto)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            String[] nombreParametros = { "@nombre" };

            IDataReader reader = _AccesoDatos.leer("sp_verColaboradoresProyecto", nombreParametros, pNombreProyecto);

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
                _colaborador.Nombre = reader.GetString(0);
                _colaborador.Cedula = reader.GetInt32(1);
                _colaborador.Puesto = reader.GetString(2);
                _colaborador.Departamento = reader.GetString(3);
                colaboradores.Add(_colaborador);
            }

            reader.Close();
            return colaboradores;
        }

        public List<String> quitarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        {
            List<String> colaboradoresSinAsignar = new List<String>();
            String[] nombreParametros = { "@nombre", "@cedula" };

            for (int i = 0; i < pColaboradores.Count; i++)
            {
                Boolean resultado = _AccesoDatos.escribir("sp_eliminarProyectoColaborador", nombreParametros, pProyecto, pColaboradores.ElementAt(i).Cedula);
                if (resultado == false)
                {
                    colaboradoresSinAsignar.Add(pColaboradores.ElementAt(i).Nombre);
                }
            }
            return colaboradoresSinAsignar;
        }

        public List<Colaborador> obtenerColaboradoresCapacitacion(int pIdCapacitacion)
=======
        public List<Colaborador> obtenerColaboradoresFueraCapacitacion(int pIdCapacitacion)
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            String[] nombreParametros = { "@idCapacitacion" };

<<<<<<< HEAD
            IDataReader reader = _AccesoDatos.leer("sp_verColaboradoresCapacitacion", nombreParametros, pIdCapacitacion);
=======
            IDataReader reader = _AccesoDatos.leer("sp_verAspirantesCapacitacion", nombreParametros, pIdCapacitacion);
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
                _colaborador.Nombre = reader.GetString(0);
                _colaborador.Cedula = reader.GetInt32(1);
                _colaborador.Puesto = reader.GetString(2);
                _colaborador.Departamento = reader.GetString(3);
                colaboradores.Add(_colaborador);
            }

            reader.Close();
            return colaboradores;
        }

<<<<<<< HEAD
        public List<String> quitarColaboradoresCapacitacion(List<Colaborador> pColaboradores, int pIdCapacitacion)
        {
            List<String> colaboradoresSinAsignar = new List<String>();
            String[] nombreParametros = { "@idCapacitacion", "@cedula" };

            for (int i = 0; i < pColaboradores.Count; i++)
            {
                Boolean resultado = _AccesoDatos.escribir("sp_eliminarCapacitacionColaborador", nombreParametros, pIdCapacitacion, pColaboradores.ElementAt(i).Cedula);
                if (resultado == false)
                {
                    colaboradoresSinAsignar.Add(pColaboradores.ElementAt(i).Nombre);
                }
            }
            return colaboradoresSinAsignar;
        }

        public Boolean asignarCapacitacionProyecto(String pNombreProyecto, int pIdCapacitacion)
        {
            String[] nombreParametros = { "@nombreProyecto", "@idCapacitacion" };
            return _AccesoDatos.escribir("sp_asignarCapacitacionProyecto", nombreParametros, pNombreProyecto, pIdCapacitacion);
        }

        
        public List<String> obtenerPuestos()
        {
            List<String> puestos = new List<String>();
            String[] nombreParametros = { };

            IDataReader reader = _AccesoDatos.leer("sp_verPuestos", nombreParametros);

            while (reader.Read())
            {
                puestos.Add(reader.GetString(0));
            }

            reader.Close();
            return puestos;
        }

        public Boolean crearDepartamento(String pNombre, String pDescripcion, String pPadre)
        {
            String[] nombreParametros = { "@nombre", "@descripcion", "@padre" };
            return _AccesoDatos.escribir("sp_crearDepartamento", nombreParametros, pNombre, pDescripcion, pPadre);
        }

        public List<Departamento> obtenerDepartamentosEstructura()
        {
            List<Departamento> departamentos = new List<Departamento>();
            String[] nombreParametros = { };
            IDataReader reader = _AccesoDatos.leer("sp_verDepartamentos", nombreParametros);

            while (reader.Read())
            {
                Departamento departamento = new Departamento();
                departamento.Nombre = reader.GetString(0);
                departamento.Descripcion = reader.GetString(1);
                departamento.Habilitado = reader.GetBoolean(2);
                departamento.Padre = reader.GetString(3);
                departamentos.Add(departamento);
            }

            reader.Close();
            return departamentos;
        }
        public List<String> obtenerDepartamentos()
        {
            List<String> departamentos = new List<String>();
            String[] nombreParametros = { };

            IDataReader reader = _AccesoDatos.leer("sp_verDepartamentos", nombreParametros);

            while (reader.Read())
            {
                departamentos.Add(reader.GetString(0));
            }

            reader.Close();
            return departamentos;
        }

=======
<<<<<<< HEAD
        //public List<String> quitarColaboradoresProyecto(List<Colaborador> pColaboradores, String pProyecto)
        //{
        //    List<String> colaboradoresSinAsignar = new List<String>();
        //    String[] nombreParametros = { "@nombre", "@cedula" };

        //    for (int i = 0; i < pColaboradores.Count; i++)
        //    {
        //        Boolean resultado = _AccesoDatos.escribir("sp_eliminarProyectoColaborador", nombreParametros, pProyecto, pColaboradores.ElementAt(i).Cedula);
        //        if (resultado == false)
        //        {
        //            colaboradoresSinAsignar.Add(pColaboradores.ElementAt(i).Nombre);
        //        }
        //    }
        //    return colaboradoresSinAsignar;
        //}
=======

>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d

    }
}