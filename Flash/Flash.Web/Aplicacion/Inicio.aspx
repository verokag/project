<%@ Page Title="" Language="C#" MasterPageFile="~/Incluir/Master/PlantillaGeneral.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Flash.Web.Aplicacion.Inicio1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenedorCuerpo" runat="server">


    <div class="DivContenido">
        <div class="DivContenidoTitulo">
            <div class="DivTitulo">Pantalla de inicio</div>
        </div>

        <div class="DivInformacionContenido">
            <table>
                <tr>
                    <td>
                        <div id="DivSeccionCatalogos" runat="server" class="DivContenidoOpcionesMenu">
                            <table class="TablaOpciones">
                                <tr>
                                    <td class="Titulo" colspan="3">
                                        <img alt="Catálogos" src="/Imagen/Icono/IconoMenuCatalogo.png" />&nbsp;
                                        Recepción de Automoviles
                                    </td>
                                </tr>
                            </table>
                            <table class="TablaOpciones">
                               <tr>
                                  <td>
                                     <div id="DivRecepción" runat="server" class="OpcionesMenuDesplazableTercia">
                                          <a href="/Aplicacion/Catalogo/Puesto.aspx">Recepción</a>
                                     </div>
                                  </td>
                               </tr> 
                            </table> 
                        </div>
                        <div id="DivSeccionReportes" runat="server" class="DivContenidoOpcionesMenu">
                            <table class="TablaOpciones">
                                <tr>
                                    <td class="Titulo" colspan="3">
                                        <img alt="Reportes" src="/Imagen/Icono/IconoMenuReporte.png" />&nbsp;
                                        Búsqueda de vehículos o clientes
                                    </td>
                                </tr>
                            </table>
                            <table class="TablaOpciones">
                              <tr>
                                 <td>
                                    <div id="DivReporteMantenimientosPorActivo" runat="server" class="OpcionesMenuDesplazableMedia">
                                          <a href="/Aplicacion/Reportes/ReporteMantenimientosPorActivo.aspx">Busqueda de vehículos</a>
                                    </div>
                                 </td>
                              </tr>
                            </table> 
                        </div>
                    
                        <div id="DivSeccionConfiguracion" runat="server" class="DivContenidoOpcionesMenu">
                            <table class="TablaOpciones">
                                <tr>
                                    <td class="Titulo" colspan="3">
                                        <img alt="Configuración" src="/Imagen/Icono/IconoMenuConfiguracion.png" />&nbsp;
                                        Configuración
                                    </td>
                                </tr>
                                <tr>
                                    <td class="Opcion"><a href="/Aplicacion/Configuracion/CambiarContrasenia.aspx">Cambiar contraseña</a></td>
                                    <td class="Opcion"><a href="RegistroEmpleado.aspx">Registrar Empleado nuevo</a></td>
                                    <td class="Opcion"></td>
                                </tr>
                                <tr>
                                    <td class="Opcion"></td>
                                    <td class="Opcion"></td>
                                    <td class="Opcion"></td>
                                </tr>
                            </table>
                        </div>
                    </td>
                </tr>
            </table>

            <br /><br /><br />
        </div>
    </div>
</asp:Content>
