using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloOrganizacion
{
    public class Proyecto
    {

        private String _Nombre;
        private String _Descripcion;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;
        private List<Colaborador> _Miembros;


        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public DateTime FechaInicial
        {
            get { return _FechaInicial; }
            set { _FechaInicial = value; }
        }

        public DateTime FechaFinal
        {
            get { return _FechaFinal; }
            set { _FechaFinal = value; }
        }

        public List<Colaborador> Miembros
        {
            get { return _Miembros; }
            set { _Miembros = value; }
        }
    }
}