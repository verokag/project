using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flash.Comun.Constante
{
    public class ConstantePrograma
    {
        //Nombre de la conección de la DB
        public const string FlashDB = "Flash";

        public enum IdentificacionUsuario 
        {
            ValorPorDefecto = 0,
            UsuarioContraseniaIncorrecta = 1,
            UsuarioInactivo = 2
        }
    }
}
