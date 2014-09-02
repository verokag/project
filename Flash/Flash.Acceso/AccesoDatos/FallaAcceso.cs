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
    public class FallaAcceso
    {

        public ResultadoEntidad SeleccionarFalla(FallaEntidad Falla, string CadenaConexion)
        {
            DataSet ResultadoDatos = new DataSet();
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand Comando;
            SqlParameter Parametro;
            SqlDataAdapter Adaptador;
            ResultadoEntidad Resultado = new ResultadoEntidad();


            try
            {
                Comando = new SqlCommand("SeleccionarFallaProcedimiento", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Parametro = new SqlParameter("FallaId", SqlDbType.SmallInt);
                Parametro.Value = Falla.FallaId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Nombre", SqlDbType.VarChar);
                Parametro.Value = Falla.Nombre;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("Alias", SqlDbType.VarChar);
                Parametro.Value = Falla.Alias;
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
