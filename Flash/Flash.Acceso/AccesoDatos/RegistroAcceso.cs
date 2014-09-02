using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flash.Acceso.AccesoDatos;
using Flash.Comun;
using Flash.Entidad.Aplicacion;
using Flash.Entidad.General;
using System.Data;
using System.Data.SqlClient;

namespace Flash.Acceso.AccesoDatos
{
    public class RegistroAcceso
    {
        public ResultadoEntidad SeleccionarRegistros(RegistroEntidad RegistroEntidad, string CadenaConexion) 
        {

            DataSet ResultadoDatos = new DataSet();
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand Comando;
            SqlParameter Parametro;
            SqlDataAdapter Adaptador;
            ResultadoEntidad Resultado = new ResultadoEntidad();


            try
            {
                Comando = new SqlCommand("SeleccionarRegistrosProcedimiento", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Parametro = new SqlParameter("RegistroId", SqlDbType.SmallInt);
                Parametro.Value = RegistroEntidad.RegistroId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("AutomovilId", SqlDbType.SmallInt);
                Parametro.Value = RegistroEntidad.AutomovilId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("FallaId", SqlDbType.SmallInt);
                Parametro.Value = RegistroEntidad.FallaId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("FechaEntrada", SqlDbType.VarChar);
                Parametro.Value = RegistroEntidad.FechaEntrada;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("FechaSalida", SqlDbType.VarChar);
                Parametro.Value = RegistroEntidad.FechaSalida;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("UsuarioInserto", SqlDbType.VarChar);
                Parametro.Value = RegistroEntidad.UsuarioInserto;
                Comando.Parameters.Add(Parametro);

                Adaptador = new SqlDataAdapter(Comando);
                ResultadoDatos = new DataSet();

                Conexion.Open();
                Adaptador.Fill(ResultadoDatos);
                Conexion.Close();

                Resultado.ResultadoDatos = ResultadoDatos;

                return Resultado;
            }
            catch (SqlException Excepcion)
            {
                Resultado.ErrorId = Excepcion.Number;
                Resultado.DescripcionError = Excepcion.Message;

                return Resultado;
            }

        }

        public ResultadoEntidad CrearRegistros(RegistroEntidad Registro, string CadenaConexion)
        {
            DataSet ResultadoDatos = new DataSet();
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand Comando;
            SqlParameter Parametro;
            SqlDataAdapter Adaptador;
            ResultadoEntidad Resultado = new ResultadoEntidad();


            try
            {
                Comando = new SqlCommand("InsertarRegistroProcedimiento", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Parametro = new SqlParameter("FechaEntrada", SqlDbType.VarChar);
                Parametro.Value = Registro.FechaEntrada;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("UsuarioInserto", SqlDbType.Int);
                Parametro.Value = Registro.UsuarioInserto;
                Comando.Parameters.Add(Parametro);


                Parametro = new SqlParameter("Cliente", SqlDbType.VarChar);
                Parametro.Value = Registro.Automovil.Cliente.Nombre;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Apellido", SqlDbType.VarChar);
                Parametro.Value = Registro.Automovil.Cliente.ApellidoPaterno;
                Comando.Parameters.Add(Parametro);


                Parametro = new SqlParameter("Cel", SqlDbType.VarChar);
                Parametro.Value = Registro.Automovil.Cliente.Celular;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Tel", SqlDbType.VarChar);
                Parametro.Value = Registro.Automovil.Cliente.Telefono;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("ColorId", SqlDbType.SmallInt);
                Parametro.Value = Registro.Automovil.ColorId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("AnioId", SqlDbType.SmallInt);
                Parametro.Value = Registro.Automovil.Anio;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("ModeloId", SqlDbType.SmallInt);
                Parametro.Value = Registro.Automovil.Modelo.ModeloId;
                Comando.Parameters.Add(Parametro);


                Parametro = new SqlParameter("FallaId", SqlDbType.SmallInt);
                Parametro.Value = Registro.FallaId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Descripcion", SqlDbType.VarChar);
                Parametro.Value = Registro.UsuarioInserto;
                Comando.Parameters.Add(Parametro);



                Parametro = new SqlParameter("FechaSalida", SqlDbType.VarChar);
                Parametro.Value = Registro.FechaSalida;
                Comando.Parameters.Add(Parametro);



            
  

                Adaptador = new SqlDataAdapter(Comando);
                ResultadoDatos = new DataSet();


                Conexion.Open();
                //Comando.ExecuteNonQuery();
                Comando.ExecuteScalar();
                Adaptador.Fill(ResultadoDatos);
                Conexion.Close();

                Resultado.ResultadoDatos = ResultadoDatos;

                return Resultado;
            }
            catch (SqlException Excepcion)
            {
                Resultado.ErrorId = Excepcion.Number;
                Resultado.DescripcionError = Excepcion.Message;

                return Resultado;
            }
        }
    }
}
