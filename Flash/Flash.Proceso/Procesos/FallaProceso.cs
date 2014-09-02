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

namespace Flash.Proceso.Procesos
{
    public class FallaProceso : Base
    {

        /// <summary>
        /// Método que se utiliza para procesar la selección de colores de la base de datos.
        /// </summary>
        /// <param name="Color"></param>
        /// <returns>
        ///     List 
        /// </returns>
        public List<FallaEntidad> SeleccionarFalla(FallaEntidad Falla)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            FallaAcceso FallaAccesoObjeto = new FallaAcceso();
            string CadenaConexion = string.Empty;

            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = FallaAccesoObjeto.SeleccionarFalla(Falla, CadenaConexion);

            List<FallaEntidad> Fallas = new List<FallaEntidad>();

            if (Resultado.ResultadoDatos.Tables.Count != 0)
            {

                DataTable dt = Resultado.ResultadoDatos.Tables[0];

                FallaEntidad FallaDB;
                foreach (DataRow item in dt.Rows)
                {

                    FallaDB = new FallaEntidad();
                    FallaDB.FallaId = int.Parse(item["FallaId"].ToString());
                    FallaDB.Alias = item["Alias"].ToString();
                    FallaDB.Nombre = item["Nombre"].ToString();

                    Fallas.Add(FallaDB);
                    Fallas.Sort();

                }

                return Fallas;
            }
            return new List<FallaEntidad>();
        }
    }
}
