using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloExpedientes
{
    public class Capacitacion
    {

        private String _Nombre;
        private String _Descripcion;
        private int _DuracionEnHoras;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;
<<<<<<< HEAD
        private int _Id;
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

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

        public int DuracionEnHoras
        {
            get { return _DuracionEnHoras; }
            set { _DuracionEnHoras = value; }
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
<<<<<<< HEAD

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
=======
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
    }
}