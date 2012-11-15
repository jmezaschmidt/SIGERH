using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloExpedientes;

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
            String[] nombreParametros = { "@nombre" };

            IDataReader reader = _AccesoDatos.leer("sp_verAspirantesProyecto", nombreParametros, pProyecto);

            while (reader.Read())
            {
                Colaborador _colaborador = new Colaborador();
                _colaborador.Cedula = reader.GetInt32(0);
                _colaborador.Nombre = reader.GetString(1);
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
                Boolean resultado = _AccesoDatos.escribir("sp_asignarProyectoColaborador", nombreParametros, pProyecto, pColaboradores.ElementAt(i).Cedula);
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
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            String[] nombreParametros = { "@idCapacitacion" };

            IDataReader reader = _AccesoDatos.leer("sp_verColaboradoresCapacitacion", nombreParametros, pIdCapacitacion);

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

    }
}