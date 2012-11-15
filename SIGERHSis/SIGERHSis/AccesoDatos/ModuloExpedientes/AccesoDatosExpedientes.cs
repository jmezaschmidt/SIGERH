using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.AccesoDatos.ModuloExpedientes
{
    public class AccesoDatosExpedientes
    {

        private AccesoDatos _AccesoDatos;
        
        public AccesoDatosExpedientes() {
            _AccesoDatos = new AccesoDatos();    
        }


        public Colaborador obtenerColaborador(int pCedulaClaborador)
        {
            Colaborador colaborador = new Colaborador();
            List<Contacto> contactos = new List<Contacto>();
            String[] nombreParametros = { "@cedula" };

            IDataReader reader = _AccesoDatos.leer("sp_verExpedienteColaborador", nombreParametros, pCedulaClaborador);
            
            if (reader.Read())
            {

                colaborador.Nombre = reader.GetString(0);
                colaborador.Cedula = reader.GetInt32(1);
                colaborador.FechaNacimiento = reader.GetDateTime(2);
                colaborador.Puesto = reader.GetString(3);
                colaborador.Departamento = reader.GetString(4);
                colaborador.FechaIngreso = reader.GetDateTime(5);
                colaborador.Estado = reader.GetString(6);
            }

            reader.Close();
            
            reader = _AccesoDatos.leer("sp_verContactosColaborador", nombreParametros, pCedulaClaborador);
            
            while (reader.Read())
            {
                Contacto _contacto = new Contacto();
                _contacto.ValorContacto = reader.GetString(0);
                _contacto.TipoContacto = reader.GetString(1);
                contactos.Add(_contacto);
            }

            colaborador.Contactos = contactos;

            reader.Close();
            return colaborador;
        }

        public List<Solicitud> obtenerSolicitudesColaborador(int pCedulaClaborador, String pTipoSolicitud)
        {
            List<Solicitud> solicitudes = new List<Solicitud>();
            String[] nombreParametros = { "@cedula", "@tipoSolicitud" };

            IDataReader reader = _AccesoDatos.leer("sp_verSolicitudesColaboradorTipo", nombreParametros, pCedulaClaborador, pTipoSolicitud);

            while (reader.Read())
            {
                Solicitud _solicitud = new Solicitud();
                _solicitud.Id = reader.GetInt32(0);
                _solicitud.FechaSolicitud = reader.GetDateTime(1);
                _solicitud.Motivo = reader.GetString(2);
                _solicitud.FechaInicial = reader.GetDateTime(3);
                _solicitud.FechaFinal = reader.GetDateTime(4);
                _solicitud.Estado = reader.GetString(5);
                solicitudes.Add(_solicitud);
            }

            reader.Close();
            return solicitudes;
        }

        public List<Capacitacion> obtenerCapacitacionesColaborador(int pCedulaClaborador)
        {
            List<Capacitacion> capacitaciones = new List<Capacitacion>();
            String[] nombreParametros = { "@cedula" };

            IDataReader reader = _AccesoDatos.leer("sp_verCapacitacionColaborador", nombreParametros, pCedulaClaborador);

            while (reader.Read())
            {
                Capacitacion _capacitacion = new Capacitacion();
                _capacitacion.Nombre = reader.GetString(0);
                _capacitacion.Descripcion = reader.GetString(1);
                _capacitacion.DuracionEnHoras = reader.GetInt32(2);
                _capacitacion.FechaInicial = reader.GetDateTime(3);
                _capacitacion.FechaFinal = reader.GetDateTime(4);
                capacitaciones.Add(_capacitacion);
            }

            reader.Close();
            return capacitaciones;
        }

        public Boolean cambiarEstadoSolicitud(int pIdSolicitud, String pNuevoEstado)
        {
            String[] nombreParametros = { "@idSolicitud", "@estado" };
            return _AccesoDatos.escribir("sp_modificarEstadoSolicitud", nombreParametros, pIdSolicitud, pNuevoEstado);
        }

        public Contrato obtenerContratoColaborador(int pCedulaClaborador)
        {
            Contrato contrato = new Contrato();
            String[] nombreParametros = { "@cedula" };

            IDataReader reader = _AccesoDatos.leer("sp_verContratoColaborador", nombreParametros, pCedulaClaborador);

            if (reader.Read())
            {
                contrato.CantidadHorasLaborales = reader.GetInt32(0);
                contrato.FechaCreacion = reader.GetDateTime(1);
                contrato.Estado = reader.GetString(2);
            }

            reader.Close();
            return contrato;
        }

        public Boolean crearColaborador(String pNombre, String pApellidoUno, String pApellidoDos, int pCedula,
                                        DateTime pFechaNac, String pTipoUsuario, String pDepart, String pPuesto)
        {
            String[] nombreParametros = { "@nombre", "@apellido1", "@apellido2", "@cedula", "@fechaNacimiento", "@tipoUsuario", "@departamento", "@puesto" };
            return _AccesoDatos.escribir("sp_crearColaborador", nombreParametros, pNombre, pApellidoUno, 
                                        pApellidoDos, pCedula, pFechaNac, pTipoUsuario, pDepart, pPuesto);
        }

            
    }
}