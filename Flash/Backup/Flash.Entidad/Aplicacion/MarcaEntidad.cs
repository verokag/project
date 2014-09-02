using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class MarcaEntidad
    {
        private int _MarcaId;
        private string _Nombre;

        public MarcaEntidad() 
        {
            _MarcaId = 0;
            _Nombre = string.Empty;
        }

        public int MarcaId
        {
            get { return _MarcaId; }
            set { _MarcaId = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
