﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="Flash.Web.Incluir.WebUserControl.LoginControl" %>

<link href="../../Css/Tabla.css" rel="Stylesheet" type="text/css" />

<asp:UpdatePanel ID="IdentificacionPanelActualizacion" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
       

        <div id="DivControlIdentificacion">
            <table class="TablaIdentificacion">
                <tr>
                    <td><img alt="Identificación de usuario" src="../../Imagen/Logo/FlashCirculo.png" /></td>
                    <td class="Separador"></td>
                    <td><span class="TituloGrisTituloIdentificacion">Identificación</span> <span class="TituloGrisTituloIdentificacion">de usuario</span></td>
                </tr>
            </table>

            <br />
            <div class="DivInformacionCuenta">
                Usuario
                <br />
                <asp:TextBox ID="CuentaUsuario" MaxLength="65" runat="server" Width="200px" Text=""></asp:TextBox>
                <br /><br />
                Contraseña
                <br />
                <asp:TextBox ID="Contrasenia" runat="server" Width="200px" Text="" TextMode="Password"></asp:TextBox>
                <br /><br />
                <asp:CheckBox ID="RecordarContrasenia" runat="server" /> Recordar contraseña

                <br /><br />
                <div class="DivBotonAceptar">
                    <asp:Button ID="BotonAceptar" runat="server" Text="Aceptar" onclick="BotonAceptar_Click" />

                    <br /><br />
                    <asp:RequiredFieldValidator ControlToValidate="CuentaUsuario" Display="Dynamic" ErrorMessage="" ID="ValidadorCuentaUsuario" SetFocusOnError="true" ValidationGroup="IdentificarUsuario" runat="server"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ControlToValidate="Contrasenia" Display="Dynamic" ErrorMessage="" ID="ValidarContrasenia" SetFocusOnError="true" ValidationGroup="IdentificarUsuario" runat="server"></asp:RequiredFieldValidator>
                    <asp:Label CssClass="TextoError" ID="EtiquetaMensaje" runat="server" Text=""></asp:Label>
                    <asp:LinkButton CssClass="TextoChico" ID="OlvidoContrasenia" runat="server" Text="¿Olvidó su contraseña?" onclick="OlvidoContrasenia_Click"></asp:LinkButton>
                </div>
            </div>
        </div>

        <script language="javascript" type="text/javascript">
            $(function() {
                var CuentaUsuarioCampo = "";
                var ContraseniaCampo = "";
                var CookieCampo = "";
                var RecordarContraseniaCampo = "";
                var CuentaUsuario;
                var Contrasenia;
                var Cookie;
                var RecordarContrasenia;

                CuentaUsuarioCampo = "<%= CuentaUsuario.ClientID %>";
                ContraseniaCampo = "<%= Contrasenia.ClientID %>";
                CookieCampo = "<%= CookieOculto.ClientID %>";
                RecordarContraseniaCampo = "<%= RecordarContrasenia.ClientID %>";

                CuentaUsuario = document.getElementById(CuentaUsuarioCampo);
                Contrasenia = document.getElementById(ContraseniaCampo);
                Cookie = document.getElementById(CookieCampo);
                RecordarContrasenia = document.getElementById(RecordarContraseniaCampo);

                if(CuentaUsuario != null)
                {
                    CuentaUsuarioCampo = "#" + CuentaUsuarioCampo;

                    if(CuentaUsuario.value == "")
                    {
                        CuentaUsuario.value = "ejemplo@dominio.com";
                        $(CuentaUsuarioCampo).addClass("CuentaEjemplo");
                    }
                    else
                    {
                        $(CuentaUsuarioCampo).removeClass("CuentaEjemplo");

                        if(Contrasenia != null)
                        {
                            if(Cookie.value == "")
                            {
                                Contrasenia.focus();
                            }
                            else
                            {
                                Contrasenia.value = Cookie.value;
                                RecordarContrasenia.checked = true;
                            }
                        }
                    }

                    $(CuentaUsuarioCampo).focus(function() {
                        if(CuentaUsuario.value == "ejemplo@dominio.com")
                        {
                            CuentaUsuario.value = "";
                            $(CuentaUsuarioCampo).removeClass("CuentaEjemplo");
                        }
                    });

                    $(CuentaUsuarioCampo).focusout(function() {
                        if(CuentaUsuario.value == "")
                        {
                            CuentaUsuario.value = "ejemplo@dominio.com";
                            $(CuentaUsuarioCampo).addClass("CuentaEjemplo");
                        }
                    });
                }
            });
        </script>

        <asp:HiddenField ID="CookieOculto" runat="server" Value="#" />
        <asp:HiddenField ID="UrlDestinoOculto" runat="server" Value="#" />
    </ContentTemplate>

    <Triggers>
        
    </Triggers>
</asp:UpdatePanel>