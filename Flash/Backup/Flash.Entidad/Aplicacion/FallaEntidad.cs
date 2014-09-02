using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class FallaEntidad
    {
        private int _FallaId;
        private string _Alias;
        private string _Nombre;

        public FallaEntidad() 
        {
            _FallaId = 0;
            _Alias = string.Empty;
            _Nombre = string.Empty;
        }

        public int FallaId
        {
            get { return _FallaId; }
            set { _FallaId = value; }
        }

        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
