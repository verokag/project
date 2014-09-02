<%@ Page Title="" Language="C#" MasterPageFile="~/Incluir/Master/PlantillaGeneral.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Flash.Web.Aplicacion.Inicio" %>

<%@ Register TagPrefix="wuc" TagName="Identificacion" Src="~/Incluir/WebUserControl/LoginControl.ascx" %>

<asp:Content ID="ContenedorEncabezado" ContentPlaceHolderID="Encabezado" runat="server">


</asp:Content>
<asp:Content ID="ContenidoCuerpo" ContentPlaceHolderID="ContenedorCuerpo" runat="server">
    <div class="DivContenido">
        <div class="DivContenidoTitulo">
            <div class="DivTitulo">Pantalla de inicio</div>
        </div>
        <div class="DivInformacionContenido">
            <table>
                <tr>
                    <td>
                        <wuc:Identificacion ID="ControlIdentificacion" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    
    </div>


</asp:Content>
