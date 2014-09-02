using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class RegistroEntidad : IComparable<RegistroEntidad>
    {
        private int _RegistroId;                //Id del registro en cuestión
        private int _AutomovilId;               //Id del vehículo que fue registrado
        private AutomovilEntidad _Automovil;    //Objeto tipo Automovil del Vehículo registrado
        private Int16 _FallaId;                 //Id de la falla que posee el vehículo
        private string _Descripcion;            //Descripción de la falla
        private string _FechaEntrada;           
        private string _FechaSalida;            //Fecha en que se liberó el trabajo
        private Int16 _UsuarioInserto;          //Usuario que registró el vehículo
        private FallaEntidad _Falla;            //Objeto tipo Falla donde se registra la falla del vehículo
        private string _FechaActual;            //Fecha actual que regresa de la base de datos. Campo meramente informativo


        public RegistroEntidad() 
        {
            _RegistroId = 0;
            _AutomovilId = 0;
            _Automovil = new AutomovilEntidad();
            _FallaId = 0;
            _Descripcion = string.Empty;
            _FechaEntrada = string.Empty;
            _FechaSalida = string.Empty;
            _UsuarioInserto = 0;
            _Falla = new FallaEntidad();
            _FechaActual = string.Empty;
        }

        public string FechaActual
        {
            get;
            set;
        }

        public FallaEntidad Falla
        {
            get { return _Falla; }
            set { _Falla = value; }
        }

        public int RegistroId
        {
            get { return _RegistroId; }
            set { _RegistroId = value; }
        }

        public AutomovilEntidad Automovil
        {
            get { return _Automovil; }
            set { _Automovil = value; }
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

        public int CompareTo(RegistroEntidad R) 
        {
            return this.FechaEntrada.CompareTo(R.FechaEntrada);
        }

    }
}
