using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Entidad.Aplicacion
{
    public class AutomovilEntidad
    {
        private int _AutomovilId;               //Id del vehículo
        private ClienteEntidad _Cliente;        //Dueño del vehículo
        private string _CodigoDeBarras;         //Nombre del usuario
        private int _ModeloId;                  //Id del modelo del vehículo
        private int _ColorId;                   //Id del color del vehículo
        private int _Anio;                      //Nombre de usuario que usará para ingresar al sistema
        private ColorEntidad _Color;            //Objeto de tipo Color para indicar el color del vehículo actual
        private ModeloEntidad _Modelo;          //Objeto Marca que hace referencia a la marca del Vehículo
        

        public AutomovilEntidad() 
        {
            _AutomovilId = 0;
            _Cliente = new ClienteEntidad();
            _CodigoDeBarras = string.Empty;
            _ModeloId = 0;
            _ColorId = 0;
            _Anio = 0;
            _Color = new ColorEntidad();
            _Modelo = new ModeloEntidad();
        }

        public int AutomovilId
        {
            get;
            set;
        }

        public ColorEntidad Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public ModeloEntidad Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        public ClienteEntidad Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public string CodigoDeBarras
        {
            get;
            set;
        }

        public int ModeloId
        {
            get;
            set;
        }

        public int ColorId
        {
            get;
            set;
        }


        public int Anio 
        {
            get;
            set; 
        }

    }
}
