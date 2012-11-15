<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRHExpediente.Master" AutoEventWireup="true" CodeBehind="WFDRHPermisosExp.aspx.cs" Inherits="SIGERHSis.Interface.ModuloExpedientes.WFDRHPermisosExp" %>
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
    <asp:Button ID="btnAprobar" runat="server" Text="Aprobar" onclick="btnAprobar_Click" />
    <asp:Button ID="btnNegar" runat="server" Text="Negar" onclick="btnNegar_Click" />
    <asp:Label ID="lblMotivo" runat="server" Text="Motivo:"></asp:Label>
    <asp:Label ID="lblMotivoInfo" runat="server" Text="motivo"></asp:Label>
    </div>
</asp:Content>
