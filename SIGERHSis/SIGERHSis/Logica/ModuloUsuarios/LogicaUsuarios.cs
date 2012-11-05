using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloUsuarios;
using SIGERHSis.AccesoDatos.ModuloUsuarios;

namespace SIGERHSis.Logica.ModuloUsuarios
{
    public class LogicaUsuarios
    {
        private AccesoDatosUsuarios _AccesoDatosUsuarios;

        public LogicaUsuarios()
        {
            _AccesoDatosUsuarios = new AccesoDatosUsuarios();
        }

        public Boolean autenticarUsuario()
        {
            return _AccesoDatosUsuarios.autenticarUsuario();
        }
    }
}