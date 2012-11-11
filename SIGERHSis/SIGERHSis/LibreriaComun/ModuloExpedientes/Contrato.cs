using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGERHSis.LibreriaComun.ModuloExpedientes
{
    public class Contrato
    {

        private int _CantidadHorasLaborales;
        private DateTime _FechaCreacion;
        private String _Estado;


        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public DateTime FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public int CantidadHorasLaborales
        {
            get { return _CantidadHorasLaborales; }
            set { _CantidadHorasLaborales = value; }
        }
    }
}