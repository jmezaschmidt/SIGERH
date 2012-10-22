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
        .style4
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:GridView ID="GridViewExpedientes" runat="server"                    
                    style="text-align: left; font-family: Arial, Helvetica, sans-serif">
                    <Columns>
                        <asp:TemplateField HeaderText="Ver">
                          <ItemTemplate> 
                                <asp:RadioButton ID="RowSelector" runat="server" GroupName="SuppliersGroup" />  
                          </ItemTemplate>                          
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
    <table class="style1">
        <tr>
            <td class="style2">
                <div class="style4">
                    <span class="style3"><strong>Expedientes</strong></span><strong><br 
                        class="style3" />
                    </strong>
                </div>
                
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
