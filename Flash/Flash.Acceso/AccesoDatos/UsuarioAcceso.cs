using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Flash.Entidad.General;
using Flash.Entidad.Aplicacion;
using Flash.Comun.Constante;


namespace Flash.Acceso.AccesoDatos

{
    public class UsuarioAcceso
    {
         public ResultadoEntidad SeleccionarUsuario(UsuarioEntidad UsuarioEntidadObject, string CadenaConexion)
        {
            DataSet ResultadoDatos = new DataSet();
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand Comando;
            SqlParameter Parametro;
            SqlDataAdapter Adaptador;
            ResultadoEntidad Resultado = new ResultadoEntidad();

            try
            {
                Comando = new SqlCommand("SeleccionarUsuarioProcedimiento", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Parametro = new SqlParameter("UsuarioId", SqlDbType.SmallInt);
                Parametro.Value = UsuarioEntidadObject.UsuarioId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Nombre", SqlDbType.VarChar);
                Parametro.Value = UsuarioEntidadObject.Nombre;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                Parametro.Value = UsuarioEntidadObject.ApellidoPaterno;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                Parametro.Value = UsuarioEntidadObject.ApellidoMaterno;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("NumeroEmpleado", SqlDbType.SmallInt);
                Parametro.Value = UsuarioEntidadObject.NumeroEmpleado;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("CuentaUsuario", SqlDbType.VarChar);
                Parametro.Value = UsuarioEntidadObject.CuentaUsuario;
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
    }
}
