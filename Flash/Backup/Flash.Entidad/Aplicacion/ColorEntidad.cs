using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class ColorEntidad
    {
        private int _ColorId;
        private string _Nombre;

        public ColorEntidad() 
        {
            _ColorId = 0;
            _Nombre = string.Empty;
        }

        public int ColorId
        {
            get { return _ColorId; }
            set { _ColorId = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
