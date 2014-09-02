using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class ModeloEntidad
    {

        private int _ModeloId;
        private int _MarcaId;
        private string _Nombre;

        public ModeloEntidad() 
        {
            _ModeloId = 0;
            _MarcaId = 0;
            _Nombre = string.Empty;
        }

        public int ModeloId
        {
            get { return _ModeloId; }
            set { _ModeloId = value; }
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
