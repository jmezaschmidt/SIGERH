using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloExpedientes
{
    public class Solicitud
    {
        private DateTime _FechaSolicitud;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;
        private String _Motivo;
        private String _Estado;
        private int _Id;


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

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public DateTime FechaSolicitud
        {
            get { return _FechaSolicitud; }
            set { _FechaSolicitud = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


    }
}