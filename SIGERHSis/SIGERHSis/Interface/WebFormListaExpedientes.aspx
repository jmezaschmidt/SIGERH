<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormListaExpedientes.aspx.cs" Inherits="SIGERHSis.Interface.WebFormListaExpedientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 313px;
        }
        .style3
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                <div>
                    <span class="style3"><strong>Expedientes</strong></span><strong><br 
                        class="style3" />
                    </strong>
                </div>
                <asp:GridView ID="GridViewExpedientes" runat="server"                    
                    
    style="text-align: left; font-family: Arial, Helvetica, sans-serif" 
    AutoGenerateColumns="False" DataKeyNames="idEstado" 
    DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="idEstado" HeaderText="idEstado" 
                            InsertVisible="False" ReadOnly="True" SortExpression="idEstado" />
                        <asp:BoundField DataField="EstadoDepto" HeaderText="EstadoDepto" 
                            SortExpression="EstadoDepto" />
                    </Columns>
                </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:DB_SIGERHConnectionString %>" 
    SelectCommand="SELECT * FROM [EstadoDepartamento]"></asp:SqlDataSource>
    
                
            </td>
            <td>
                <br />
                <br />
                <span class="style3"><strong>Seleccionar Derpartamento</strong></span><strong><br 
                    class="style3" />
                </strong>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    style="font-family: Arial, Helvetica, sans-serif">
                </asp:DropDownList>

                <br />
                <br />
                <br />
                <asp:Button ID="ButtonVerExpediente" runat="server"
                    style="font-family: Arial, Helvetica, sans-serif" Text="Ver Expediente" />

            </td>
        </tr>
    </table>

</asp:Content>
