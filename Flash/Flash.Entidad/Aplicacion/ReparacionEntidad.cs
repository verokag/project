using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class ReparacionEntidad
    {
        private int _ReparacionId;
        private string _Descripcion;
        private decimal _Monto;

        public ReparacionEntidad() 
        {
            _ReparacionId = 0;
            _Descripcion = string.Empty;
            _Monto = 0;
        }

        public int ReparacionId
        {
            get { return _ReparacionId; }
            set { _ReparacionId = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
    }
}
