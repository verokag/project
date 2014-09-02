using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Web;

namespace Flash.Proceso
{
    public class Base
    {
        protected string SeleccionarConexion(string BaseDatos)
        {
            string CadenaConexion = string.Empty;

            //CadenaConexion = ConfigurationManager.ConnectionStrings[BaseDatos].ConnectionString;
            CadenaConexion = "Server=DON-PC; initial catalog=Flash; User Id=Flash.App; Password=elmaguas15;";

            return CadenaConexion;
        }
    }
}
