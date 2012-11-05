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

            IDataReader reader = _AccesoDatos.leer("sp_verInfoExpediente", nombreParametros, pCedulaClaborador);

            reader.Read();

            colaborador.Nombre = reader.GetString(0);
            colaborador.Cedula = reader.GetInt32(1);
            colaborador.FechaNacimiento = reader.GetDateTime(2);
            colaborador.Puesto = reader.GetString(3);
            colaborador.Departamento = reader.GetString(4);
            colaborador.FechaIngreso = reader.GetDateTime(5);
            colaborador.Estado = reader.GetString(6);

            reader.Close();

            /*reader = _AccesoDatos.leer("sp_", nombreParametros, pCedulaClaborador);

            while (reader.Read())
            {
                Contacto _contacto = new Contacto();
                _contacto.TipoContacto = reader.GetString(0);
                _contacto.ValorContacto = reader.GetString(1);
                contactos.Add(_contacto);
            }

            colaborador.Contactos = contactos;

            reader.Close();*/
            return colaborador;
        }

    }
}