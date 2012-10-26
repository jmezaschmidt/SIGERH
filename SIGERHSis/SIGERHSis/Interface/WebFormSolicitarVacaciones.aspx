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
            text-align: center;
        }
        #sub h1
        {
            text-align: center;
        }
        #sub input
        {
            margin-left: 10px;
        }
        table 
        {
            margin-bottom: 30px;
        }
        #btnSolicitar
        {
            margin-top: 30px;
        }
        #motivo 
        {
            font-family: Arial;
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
            <textarea id="motivo" cols="40" rows="5">Motivo</textarea><br />
            <asp:Button ID="btnSolicitar" runat="server" Text="Solicitar" />
        </div>
        
    </div>
</asp:Content>
