using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flash.Acceso.AccesoDatos;
using Flash.Entidad.General;
using Flash.Entidad.Aplicacion;
using Flash.Comun.Constante;
using System.Data;
using System.Collections.Generic;

namespace Flash.Proceso.Procesos
{
    public class ModeloProceso : Base
    {

        /// <summary>
        /// Método que se utiliza para procesar la selección de modelos de la base de datos.
        /// </summary>
        /// <param name="Modelo"></param>
        /// <returns>
        ///     List 
        /// </returns>
        public List<ModeloEntidad> SeleccionarModelos(ModeloEntidad Modelo)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            ModeloAcceso ModeloAccesoObjeto = new ModeloAcceso();

            string CadenaConexion = string.Empty;

            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = ModeloAccesoObjeto.SeleccionarMarcasYModelos(Modelo, CadenaConexion);

            List<ModeloEntidad> Modelos = new List<ModeloEntidad>();


            if (Resultado.ResultadoDatos.Tables.Count != 0)
            {

                DataTable dt = Resultado.ResultadoDatos.Tables[0];

                ModeloEntidad ModeloDB;
                foreach (DataRow item in dt.Rows)
                {

                    ModeloDB = new ModeloEntidad();

                    ModeloDB.Nombre = item["NombreModelo"].ToString();
                    ModeloDB.Marca.Nombre = item["NombreMarca"].ToString();

                    ModeloDB.ModeloId = int.Parse(item["ModeloId"].ToString());
                    ModeloDB.Marca.MarcaId = int.Parse(item["MarcaId"].ToString());

                    Modelos.Add(ModeloDB);
                    Modelos.Sort();

                }

                return Modelos;
            }
            return new List<ModeloEntidad>();
        }

    }
}
