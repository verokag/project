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
    public class ModeloAcceso
    {
        /// <summary>
        /// Método que se utuliza para hacer la extracción de los modelos y marcasde los vehículos de la base de datos
        /// </summary>
        /// <param name="Modelo"></param>
        /// <param name="CadenaConexion"></param>
        /// <returns>
        ///     ResultadoEntidad
        /// </returns>
        public ResultadoEntidad SeleccionarMarcasYModelos(ModeloEntidad Modelo, string CadenaConexion)
        {
            DataSet ResultadoDatos = new DataSet();
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand Comando;
            SqlParameter Parametro;
            SqlDataAdapter Adaptador;
            ResultadoEntidad Resultado = new ResultadoEntidad();


            try
            {
                Comando = new SqlCommand("SeleccionarMarcasYModelosProcedimiento", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Parametro = new SqlParameter("MarcaId", SqlDbType.SmallInt);
                Parametro.Value = Modelo.Marca.MarcaId;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("NombreMarca", SqlDbType.VarChar);
                Parametro.Value = Modelo.Marca.Nombre;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("NombreModelo", SqlDbType.VarChar);
                Parametro.Value = Modelo.Nombre;
                Comando.Parameters.Add(Parametro);

                Parametro = new SqlParameter("ModeloId", SqlDbType.SmallInt);
                Parametro.Value = Modelo.ModeloId;
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
