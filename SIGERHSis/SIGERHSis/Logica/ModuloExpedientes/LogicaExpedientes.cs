using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.AccesoDatos.ModuloExpedientes;

namespace SIGERHSis.Logica.ModuloExpedientes
{
    public class LogicaExpedientes
    {

        AccesoDatosExpedientes _AccesoDatosExpedientes;

        public LogicaExpedientes()
        {
            _AccesoDatosExpedientes = new AccesoDatosExpedientes();
        }


        public Colaborador obtenerColaborador(int pCedulaClaborador)
        {
            return _AccesoDatosExpedientes.obtenerColaborador(pCedulaClaborador);
        }

    }
}