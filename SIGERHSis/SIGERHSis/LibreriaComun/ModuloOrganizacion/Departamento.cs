using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloOrganizacion
{
    public class Departamento
    {

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private String _descripcion;

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private Boolean _habilitado;

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
        private String _padre;

        public String Padre
        {
            get { return _padre; }
            set { _padre = value; }
        }
    
    }
}