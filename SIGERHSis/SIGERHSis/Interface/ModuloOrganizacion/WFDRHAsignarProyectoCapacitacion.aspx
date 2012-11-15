<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/Capacitaciones.Master" AutoEventWireup="true" CodeBehind="WFDRHAsignarProyectoCapacitacion.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFDRHAsignarProyectoCapacitacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
            //agregar una nueva columna con todo el texto 
            //contenido en las columnas de la grilla 
            // contains de Jquery es CaseSentive, por eso a minúscula
            $(".filtrar tr:has(td)").each(function () {
                var t = $(this).text().toLowerCase();
                $("<td class='indexColumn'></td>")
                .hide().text(t).appendTo(this);
            });
            //Agregar el comportamiento al texto (se selecciona por el ID) 
            $("#search").keyup(function () {
                var s = $(this).val().toLowerCase().split(" ");
                $(".filtrar tr:hidden").show();
                $.each(s, function () {
                    $(".filtrar tr:visible .indexColumn:not(:contains('"
                     + this + "'))").parent().hide();
                    if (this == '') {
                        $(".filtrar tr:hidden").show();
                    }
                });

            });
        });
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tables" style="font-family: 'Segoe UI'">
            <div>
                <asp:Label ID="lblProyecto" runat="server" Text="Capacitación: "></asp:Label>
                <asp:DropDownList ID="DropDownListProyectos" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownListProyectos_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
                <asp:Label ID="lblNombreInfo" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblDuracion" runat="server" Text="Duración en horas: "></asp:Label>
                <asp:Label ID="lblDuracionInfo" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblFechaIncial" runat="server" Text="Fecha Inicial: "></asp:Label>
                <asp:Label ID="lblFechaIncialInfo" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblFechaFinal" runat="server" Text="Fecha Final: "></asp:Label>
                <asp:Label ID="lblFechaFinalInfo" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblDescripcion" runat="server" Text="Descripción: "></asp:Label>
                <asp:Label ID="lblDescripcionInfo" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnAsignarProyecto" runat="server" 
                    Text="Asignar Proyecto" onclick="btnAsignarProyecto_Click"/>
            </div>
            <div>
            <label for="search" style="margin-left: 163px; color: #B5D942;">
            <strong>Buscar:</strong>
            <input id="search" type="text"/>
            </label>
                <img alt="" src="../../Images/lupa2.PNG" />
            </div>
            
        <div id="tabla" style="overflow: scroll; height:270px; width: 100%;"> 
        <asp:Table ID="tblData" class="filtrar" runat="server">
        </asp:Table>
        </div>
    
    </div>
</asp:Content>