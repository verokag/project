using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class UsuarioEntidad
    {
        private Int16 _UsuarioId;               //Identificador del usuario
        private string _Nombre;                 //Nombre del usuario
        private string _ApellidoPaterno;        //Apellido paterno del usuario
        private string _ApellidoMaterno;        //Apellido materno del usuario
        private int _NumeroEmpleado;             //Numero con el que se podrá reconocer al empleado
        private string _CuentaUsuario;          //Nombre de usuario que usará para ingresar al sistema
        private string _Contrasenia;            //Clave confidencial para el acceso

        public UsuarioEntidad() 
        {
            _UsuarioId = 0;
            _Nombre = string.Empty;
            _ApellidoPaterno = string.Empty;
            _NumeroEmpleado = 0;
            _CuentaUsuario = string.Empty;
            _Contrasenia = string.Empty;
        }

        public Int16 UsuarioId 
        {
            get { return _UsuarioId; }
            set{_UsuarioId=value;}
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

        public int NumeroEmpleado
        {
            get { return _NumeroEmpleado; }
            set { _NumeroEmpleado = value; }
        }

        public string CuentaUsuario
        {
            get { return _CuentaUsuario; }
            set { _CuentaUsuario = value; }
        }

        public string Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; }
        }
    }
}
