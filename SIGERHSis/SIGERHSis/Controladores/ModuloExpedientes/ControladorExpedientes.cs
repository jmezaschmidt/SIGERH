using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.Logica.ModuloExpedientes;

namespace SIGERHSis.Controladores.ModuloExpedientes
{
    public class ControladorExpedientes
    {
        private LogicaExpedientes _LogicaExpedientes;
        private ProxyExpediente _Expediente;

        public ControladorExpedientes()
        {
            _LogicaExpedientes = new LogicaExpedientes();
            _Expediente = new ProxyExpediente();
        }


        public Colaborador obtenerInformacionGeneral(int pCedulaClaborador)
        {
            return _Expediente.obtenerInformacionGeneral(pCedulaClaborador);
        }

        public DataTable obtenerContactos()
        {
            DataTable contactos = new DataTable();
            DataRow contacto;
            List<Contacto> listaContactos;

            contactos.Columns.Add(new DataColumn("Tipo Contacto", typeof(string)));
            contactos.Columns.Add(new DataColumn("Contacto", typeof(string)));

            listaContactos = _Expediente.obtenerContactos();

            for (int i = 0; i < listaContactos.Count(); i++)
            {
                contacto = contactos.NewRow();
                contacto["Tipo Contacto"] = listaContactos.ElementAt(i).TipoContacto;
                contacto["Contacto"] = listaContactos.ElementAt(i).ValorContacto;
                contactos.Rows.Add(contacto);
            }

            return contactos;
            
        }

    }
}