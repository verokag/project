using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion 
{
    public class MarcaEntidad : IComparable<MarcaEntidad>
    {
        private int _MarcaId;
        private string _Nombre;
        private List<ModeloEntidad> _Modelos;

        public MarcaEntidad() 
        {
            _MarcaId = 0;
            _Nombre = string.Empty;
            _Modelos = new List<ModeloEntidad>();
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

        public List<ModeloEntidad> Modelos
        {
            get { return _Modelos; }
            set { _Modelos = value; }
        }

        public int CompareTo(MarcaEntidad M) 
        {
            return this.Nombre.CompareTo(M.Nombre);
        }

    }
}
