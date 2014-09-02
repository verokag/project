using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class RegistroEntidad     
    {
        private int _RegistroId;
        private int _AutomovilId;
        private Int16 _FallaId;
        private string _Descripcion;
        private string _FechaEntrada;
        private string _FechaSalida;
        private Int16 _UsuarioInserto;


        public RegistroEntidad() 
        {
            _RegistroId = 0;
            _AutomovilId = 0;
            _FallaId = 0;
            _Descripcion = string.Empty;
            _FechaEntrada = string.Empty;
            _FechaSalida = string.Empty;
            _UsuarioInserto = 0;
        }

        public int RegistroId
        {
            get { return _RegistroId; }
            set { _RegistroId = value; }
        }

        public int AutomovilId
        {
            get { return _AutomovilId; }
            set { _AutomovilId = value; }
        }

        public Int16 FallaId
        {
            get { return _FallaId; }
            set { _FallaId = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string FechaEntrada
        {
            get { return _FechaEntrada; }
            set { _FechaEntrada = value; }
        }

        public string FechaSalida
        {
            get { return _FechaSalida; }
            set { _FechaSalida = value; }
        }

        public Int16 UsuarioInserto
        {
            get { return _UsuarioInserto; }
            set { _UsuarioInserto = value; }
        }

    }
}
