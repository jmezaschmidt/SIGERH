using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloOrganizacion
{
    public class Contacto
    {
        private String _TipoContacto;
        private String _ValorContacto;

        public String TipoContacto
        {
            get { return _TipoContacto; }
            set { _TipoContacto = value; }
        }

        public String ValorContacto
        {
            get { return _ValorContacto; }
            set { _ValorContacto = value; }
        }
    }
}