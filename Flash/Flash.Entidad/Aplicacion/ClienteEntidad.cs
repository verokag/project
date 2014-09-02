using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class ClienteEntidad
    {
        private int _ClienteId;
        private string _Nombre;
        private string _ApellidoPaterno;
        private string _ApellidoMaterno;
        private string _Celular;
        private string _Telefono;

        public ClienteEntidad() 
        {
            _ClienteId = 0;
            _Nombre = string.Empty;
            _ApellidoPaterno = string.Empty;
            _ApellidoMaterno = string.Empty;
            _Celular = string.Empty;
            _Telefono = string.Empty;
        }

        public int ClienteId
        {
            get { return _ClienteId; }
            set { _ClienteId = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
        }

        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }




    }
}
