using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Flash.Entidad.Aplicacion;

namespace Flash.Entidad.Aplicacion
{
    public class ModeloEntidad : IComparable<ModeloEntidad>
    {

        private int _ModeloId;
        private string _Nombre;
        private MarcaEntidad _Marca;

        public ModeloEntidad() 
        {
            _ModeloId = 0;
            _Nombre = string.Empty;
             _Marca = new MarcaEntidad();
        }

        public int ModeloId
        {
            get { return _ModeloId; }
            set { _ModeloId = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public MarcaEntidad Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public int CompareTo(ModeloEntidad M) 
        {
            return this.Nombre.CompareTo(M.Nombre);
        }
    }
}
