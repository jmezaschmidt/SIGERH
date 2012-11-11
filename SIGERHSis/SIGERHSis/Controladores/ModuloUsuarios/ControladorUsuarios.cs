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
        private Usuario _UsuarioActual;

        private static ControladorUsuarios _ControladorUsuarios = new ControladorUsuarios();

        private ControladorUsuarios()
        {
            _LogicaUsuarios = new LogicaUsuarios();
            _UsuarioActual = Usuario.obtenerUsuarioActual();
        }

        public static ControladorUsuarios obtenerControladorUsuarios()
        {
            return _ControladorUsuarios;
        }

        public Boolean autenticarUsuario(String pUsuario, String pPassw, String pTipoUsuario)
        {
            _UsuarioActual.Nickname = pUsuario;
            _UsuarioActual.Password = pPassw;
            _UsuarioActual.TipoUsuario = pTipoUsuario;
            return _LogicaUsuarios.autenticarUsuario();
        }

        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }
    }
}