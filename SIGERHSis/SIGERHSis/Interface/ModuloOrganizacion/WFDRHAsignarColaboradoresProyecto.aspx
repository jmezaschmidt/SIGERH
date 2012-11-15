<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/Proyectos.Master" AutoEventWireup="true" CodeBehind="WFDRHAsignarColaboradoresProyecto.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFDRHAsignarColaboradoresProyecto" %>
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
                <asp:Label ID="lblProyecto" runat="server" Text="Proyecto: "></asp:Label>
                <asp:DropDownList ID="DropDownListProyectos" runat="server">
                </asp:DropDownList>
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