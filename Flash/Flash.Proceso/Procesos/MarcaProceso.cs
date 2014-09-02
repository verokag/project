/*
 * Clase: MarcaProceso
 * Autor: Francisco Cordero M.
 * Descripción: Clase que se encarga de manipular la información referente a las marcas de los vehículos.
 * Fecha de Creación: 23-jul-2014
 * Última modificación: 23-jul-2014
 * 
 */

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
    public class MarcaProceso : Base
    {

        /// <summary>
        /// Método que se utiliza para procesar la selección de marcas de la base de datos.
        /// </summary>
        /// <param name="Marca"></param>
        /// <returns>
        ///     List 
        /// </returns>
        public List<MarcaEntidad> SeleccionarMarcas(MarcaEntidad Marca)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            MarcaAcceso MarcaAccesoObjeto = new MarcaAcceso();
            string CadenaConexion = string.Empty;

            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = MarcaAccesoObjeto.SeleccionarMarcas(Marca, CadenaConexion);

            List<MarcaEntidad> Marcas = new List<MarcaEntidad>();


            if (Resultado.ResultadoDatos.Tables.Count != 0)
            {

                DataTable dt = Resultado.ResultadoDatos.Tables[0];

                MarcaEntidad MarcaDB;
                foreach (DataRow item in dt.Rows)
                {

                    MarcaDB = new MarcaEntidad();
                    MarcaDB.MarcaId = int.Parse(item["MarcaId"].ToString());
                    MarcaDB.Nombre = item["Nombre"].ToString();

                    Marcas.Add(MarcaDB);
                    Marcas.Sort();

                }

                return Marcas;
            }

            return new List<MarcaEntidad>();
        }

    }
}
