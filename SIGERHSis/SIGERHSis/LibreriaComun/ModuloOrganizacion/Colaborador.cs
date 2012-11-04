using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloOrganizacion
{
    public class Colaborador
    {

        private int _Cedula;
        private String _Nombre;
        private DateTime _FechaNacimiento;
        private String _Puesto;
        private String _Departamento;
        private List<String> _Contactos;


        public int Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public String Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }

        public String Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        public List<String> Contactos
        {
            get { return _Contactos; }
            set { _Contactos = value; }
        }


    }
}