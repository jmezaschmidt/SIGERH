using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGERHSis.LibreriaComun.ModuloUsuarios;
using SIGERHSis.Logica.ModuloUsuarios;

namespace SIGERHSis.Controladores.ModuloUsuarios
{
    public class ControladorUsuarios
    {
        private LogicaUsuarios _LogicaUsuarios;

        public ControladorUsuarios()
        {
            _LogicaUsuarios = new LogicaUsuarios();
        }

        public Boolean autenticarUsuario()
        {
            return _LogicaUsuarios.autenticarUsuario();
        }
    }
}