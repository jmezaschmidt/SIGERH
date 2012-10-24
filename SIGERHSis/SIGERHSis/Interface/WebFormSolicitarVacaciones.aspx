<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageUsuario.Master" AutoEventWireup="true" CodeBehind="WebFormSolicitarVacaciones.aspx.cs" Inherits="SIGERHSis.Interface.WebFormSolicitarVacaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #content
        {
            padding: 20px;
            font-family: Arial;
        }
        #sub
        {
            width: 50%;
            text-align: left;
        }
        #sub h1
        {
            text-align: center;
        }
        #sub input
        {
            margin-left: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="sub">
            <h1>Solicitar Vacaciones</h1>
            <table>
              <tr>
                <td width="100"><label>Fecha Inicial:</label></td>
                <td width="140"><input type="date"></td>
              </tr>
              <tr>
                <td><label>Fecha Final:</label></td>
                <td><input type="date"></td>
              </tr>
            </table>
            <textarea id="TextArea1" cols="20" rows="2"></textarea>
            <asp:Button ID="btnSolicitar" runat="server" Text="Solicitar" />
        </div>
        
    </div>
</asp:Content>
