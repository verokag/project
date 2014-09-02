using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Flash.Entidad.Aplicacion;
using Flash.Entidad.General;
using Flash.Proceso.Procesos;
using Flash.Comun.Constante;
using Flash.Comun.Constante.Seguridad;

namespace Flash.Web.Incluir.WebUserControl
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            IdentificarUsuario(CuentaUsuario.Text.Trim(), Contrasenia.Text.Trim());
        }

        protected void OlvidoContrasenia_Click(object sender, EventArgs e)
        {
            //RecuperarContrasenia.Inicio();
        }
        #endregion

        #region Métodos

        protected void IdentificarUsuario(string CuentaUsuario, string Password)
        {
            ResultadoEntidad Resultado = new ResultadoEntidad();
            UsuarioEntidad UsuarioEntidadObjeto = new UsuarioEntidad();
            UsuarioProceso UsuarioProcesoObjeto = new UsuarioProceso();

            UsuarioEntidadObjeto.CuentaUsuario = CuentaUsuario;
            UsuarioEntidadObjeto.Contrasenia = Password;

            Resultado = UsuarioProcesoObjeto.IdentificarUsuario(UsuarioEntidadObjeto);

            switch (Resultado.ErrorId)
            {
                case (int)ConstantePrograma.IdentificacionUsuario.ValorPorDefecto:

                    //Response.Redirect(ConfigurationManager.AppSettings["Flash.web.UserIndexURL"].ToString(), true);
                    Response.Redirect("Aplicacion/Inicio.aspx", true);
                        ///Aplicacion/Inicio.aspx
                    break;

                case (int)ConstantePrograma.IdentificacionUsuario.UsuarioContraseniaIncorrecta:
                    
                    EtiquetaMensaje.Text = TextoError.UsuarioContraseniaIncorrecta + "<br />";
                    break;

                case (int)ConstantePrograma.IdentificacionUsuario.UsuarioInactivo:
                    EtiquetaMensaje.Text = TextoError.UsuarioInactivo + "<br />";
                    break;

                default:
                    EtiquetaMensaje.Text = Resultado.DescripcionError + "<br />";
                    break;
            }


        }
       
        #endregion
        

    }
}