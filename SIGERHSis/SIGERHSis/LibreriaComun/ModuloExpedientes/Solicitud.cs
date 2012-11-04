using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloExpedientes
{
    public class Solicitud
    {

        private DateTime _FechaInicial;
        private DateTime _FechaFinal;
        private String _Motivo;
        private Boolean _Estado;


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

        public String Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }

        public Boolean Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}