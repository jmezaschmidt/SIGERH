using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SIGERHSis.LibreriaComun.ModuloUsuarios;

namespace SIGERHSis.AccesoDatos.ModuloUsuarios
{
    public class AccesoDatosUsuarios
    {
        private AccesoDatos _AccesoDatos;
        
        public AccesoDatosUsuarios() {
            _AccesoDatos = new AccesoDatos();    
        }

        public Boolean autenticarUsuario()
        {
            Usuario usuario = Usuario.obtenerUsuarioActual();
            String nickname = usuario.Nickname;
            String password = usuario.Password;
            String tipoUsuario = usuario.TipoUsuario;
            Boolean resultado;

            String[] nombreParametros = { "@nickname", "@passwrod", "@tipoUsuario" };

            IDataReader reader = _AccesoDatos.leer("sp_autenticarUsuario", nombreParametros, nickname, password, tipoUsuario);

            reader.Read();
            resultado = reader.GetBoolean(0);
            reader.Close();
            return resultado;
        }

    }
}