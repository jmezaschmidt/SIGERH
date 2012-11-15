<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFDRHPrincipal.aspx.cs" Inherits="SIGERHSis.Interface.ModuloUsuarios.WFDRHPrincipal" %>
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

<script type="text/javascript">
    function calledFn(texto) {
        /*document.getElementById('campoTabla').innerHTML(texto);*/
        /*document.getElementById('prueba').innerHTML=texto;*/
        /*document.getElementById("prueba").innerHTML("<h1>Número ingresado</h1>");*/

        alert('kmfjnjnfjnfjn');

    } 
    </script>

<script type="text/javascript">
    function cargarDatosTabla(texto) {
        document.getElementById('<%=tblData.ClientID%>').innerHTML = texto;
        /*document.getElementById('tabla').innerHTML = texto;*/
    } 
</script>
<script type="text/javascript">
    $(function () {
        $("#btnVerExpedientes").click(function () {
            var marcado;
            var radios = document.getElementsByName('myradio');
            for (i = 0; i < radios.length; i++) {
                if (radios[i].checked == true) {
                    marcado = radios[i].value;
                }
            }
            alert("Está marcado el radio button: " + marcado);
        })
    })
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tables" style="font-family: 'Segoe UI'">
            <div>
            <label style="color: #E96E19; font-size: xx-large;">
            <strong>Colaboradores</strong>
            </label>
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
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnVerExpediente" runat="server" Text="Ver Expediente" 
                onclick="btnVerExpediente_Click" />

    </div>
</asp:Content>

