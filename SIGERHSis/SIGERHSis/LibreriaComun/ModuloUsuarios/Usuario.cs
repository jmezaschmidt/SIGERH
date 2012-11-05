using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloUsuarios
{
    public class Usuario
    {

        private String _Nickname;
        private String _Password;
        private String _TipoUsuario;

        private static Usuario _UsuarioActual = new Usuario();

        private Usuario() { }


        public static Usuario obtenerUsuarioActual()
        {
            return _UsuarioActual;
        }

        public String Nickname
        {
            get { return _Nickname; }
            set { _Nickname = value; }
        }

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public String TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }

    }
}