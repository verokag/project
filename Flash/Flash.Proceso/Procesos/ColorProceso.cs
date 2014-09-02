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
    public class ColorProceso : Base
    {
        /// <summary>
        /// Método que se utiliza para procesar la selección de colores de la base de datos.
        /// </summary>
        /// <param name="Color"></param>
        /// <returns>
        ///     List 
        /// </returns>
        public List<ColorEntidad> SeleccionarColores(ColorEntidad Color)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            ColorAcceso ColorAccesoObjeto = new ColorAcceso();
            string CadenaConexion = string.Empty;

            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = ColorAccesoObjeto.SeleccionarMarcas(Color, CadenaConexion);

            List<ColorEntidad> Colores = new List<ColorEntidad>();


            if (Resultado.ResultadoDatos.Tables.Count != 0)
            {

                DataTable dt = Resultado.ResultadoDatos.Tables[0];

                ColorEntidad ColorDB;
                foreach (DataRow item in dt.Rows)
                {

                    ColorDB = new ColorEntidad();
                    ColorDB.ColorId = int.Parse(item["ColorId"].ToString());
                    ColorDB.Nombre = item["Nombre"].ToString();

                    Colores.Add(ColorDB);
                    Colores.Sort();

                }

                return Colores;
            }

            return new List<ColorEntidad>();
        }

    }
}
