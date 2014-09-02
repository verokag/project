using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

using Flash.Acceso.AccesoDatos;
using Flash.Entidad.General;
using Flash.Entidad.Aplicacion;
using Flash.Comun.Constante;
using Flash.Comun.Constante.Seguridad;

namespace Flash.Proceso.Procesos

{
    public class UsuarioProceso : Base
    {
        public ResultadoEntidad IdentificarUsuario(UsuarioEntidad UsuarioEntidadObjeto) 
        {
            string ContraseniaEncriptada = string.Empty;
            string DatabasePassword = string.Empty;
            ResultadoEntidad Resultado = new ResultadoEntidad();
            UsuarioAcceso UsuarioObjetoAcceso = new UsuarioAcceso();
            string CadenaConexion = string.Empty;

            CadenaConexion = SeleccionarConexion(ConstantePrograma.FlashDB);

            Resultado = UsuarioObjetoAcceso.SeleccionarUsuario(UsuarioEntidadObjeto, CadenaConexion);

            if (Resultado.ErrorId == (int)ConstantePrograma.IdentificacionUsuario.ValorPorDefecto) 
            {
                if (Resultado.ResultadoDatos.Tables[0].Rows.Count == 0) 
                {
                    Resultado.ErrorId = (int)ConstantePrograma.IdentificacionUsuario.UsuarioContraseniaIncorrecta;
                    return Resultado;
                }
                else
                {
                    ContraseniaEncriptada = EncriptarTexto.Encriptar(UsuarioEntidadObjeto.Contrasenia);

                    DatabasePassword = Resultado.ResultadoDatos.Tables[0].Rows[0]["Contrasenia"].ToString();
                    if (ContraseniaEncriptada == DatabasePassword) 
                    {
                        UsuarioEntidadObjeto.UsuarioId = Int16.Parse(Resultado.ResultadoDatos.Tables[0].Rows[0]["UsuarioId"].ToString());
                        UsuarioEntidadObjeto.Nombre = Resultado.ResultadoDatos.Tables[0].Rows[0]["Nombre"].ToString();
                        UsuarioEntidadObjeto.ApellidoPaterno = Resultado.ResultadoDatos.Tables[0].Rows[0]["ApellidoPaterno"].ToString();
                        UsuarioEntidadObjeto.ApellidoMaterno = Resultado.ResultadoDatos.Tables[0].Rows[0]["ApellidoMaterno"].ToString();
                        UsuarioEntidadObjeto.NumeroEmpleado = Int16.Parse(Resultado.ResultadoDatos.Tables[0].Rows[0]["NumeroEmpleado"].ToString());
                        UsuarioEntidadObjeto.CuentaUsuario = Resultado.ResultadoDatos.Tables[0].Rows[0]["CuentaUsuario"].ToString();
                        UsuarioEntidadObjeto.Contrasenia = Resultado.ResultadoDatos.Tables[0].Rows[0]["Contrasenia"].ToString();

                        return Resultado;
                    }

                    Resultado.ErrorId = (int)ConstantePrograma.IdentificacionUsuario.UsuarioContraseniaIncorrecta;
                    return Resultado;
                }
            }

            return Resultado;
        }
    }
}
