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
            //CadenaConexion = "Data Source=SANDRA-PC; Initial Catalog=Flash; Persist Security Info=True;User ID=FlashAdmin;Password=Admin1000";

            //CadenaConexion = ConfigurationManager.ConnectionStrings[BaseDatos].ConnectionString;
            CadenaConexion = "Data Source=E-SVARAUJO\\MSSQLSERVER3; Initial Catalog=Flash; Persist Security Info=True;User ID=FlashAdmin;Password=Admin1000";
            


            return CadenaConexion;
        }

        public void Logger(String lines)
        {

            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log

            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt", true);
            file.WriteLine(lines);
            file.Close();

        }
    }
}
