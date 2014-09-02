using System;
using System.Collections;

using Flash.Acceso.AccesoDatos;
using Flash.Entidad.General;
using Flash.Entidad.Aplicacion;
using Flash.Comun.Constante;
using System.Data;
using System.Collections.Generic;


namespace Flash.Proceso.Procesos
{
    public class RegistroProceso : Base
    {

        public List<RegistroEntidad> SeleccionarRegistros(RegistroEntidad RegistroEntrada)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            RegistroAcceso RegistroAccesoObjeto = new RegistroAcceso();
            string CadenaConexion = string.Empty;
            RegistroEntidad Registro = new RegistroEntidad();
            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = RegistroAccesoObjeto.SeleccionarRegistros(Registro, CadenaConexion);

            List<RegistroEntidad> Registros = new List<RegistroEntidad>();

            //RegistroEntidad Registro = new RegistroEntidad();


            if (Resultado.ResultadoDatos.Tables.Count != 0)
            {

                DataTable dt = Resultado.ResultadoDatos.Tables[0];

                foreach (DataRow item in dt.Rows)
                {
                    try
                    {

                        //Obteniendo la información del Registro
                        Registro.RegistroId = int.Parse(item["RegistroId"].ToString());
                        Registro.AutomovilId = int.Parse(item["AutomovilId"].ToString());

                        //Registro.Automovil.AutomovilId = Registro.AutomovilId; 
                        Registro.FallaId = Int16.Parse(item["FallaId"].ToString());
                        Registro.Descripcion = item["Descripcion"].ToString();
                        Registro.FechaActual = item["FechaActual"].ToString();
                        Registro.FechaEntrada = item["FechaEntrada"].ToString();
                        Registro.FechaSalida = item["FechaSalida"].ToString();

                        //Obteniendo la información del vehículo
                        Registro.Automovil.Anio = Int16.Parse(item["Anio"].ToString());
                        Registro.Automovil.Modelo.Nombre = item["Modelo"].ToString();
                        Registro.Automovil.Modelo.Marca.Nombre = item["Marca"].ToString();
                        Registro.Automovil.Color.Nombre = item["Color"].ToString();
                        Registro.Falla.Alias = item["FallaAlias"].ToString();
                        Registro.Falla.Nombre = item["Falla"].ToString();

                        //Obteniendo la información del Cliente
                        Registro.Automovil.Cliente.Nombre = item["NombreCliente"].ToString() + " " + item["Apellidos"].ToString();
                        Registro.Automovil.Cliente.Telefono = item["Telefono"].ToString();


                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.Write(e.ToString());
                    }
                    Registros.Add(Registro);

                    Registro = new RegistroEntidad();

                }
                Registros.Sort();

                return Registros;
            }
            return new List<RegistroEntidad>();
        }

        public void CrearRegistros(RegistroEntidad registro)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            RegistroAcceso RegistroAccesoObjeto = new RegistroAcceso();
            string CadenaConexion = string.Empty;
            RegistroEntidad Registro = new RegistroEntidad();
            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = RegistroAccesoObjeto.CrearRegistros(registro, CadenaConexion);



        }
    }
}
