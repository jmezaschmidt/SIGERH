<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFCrearContrato.aspx.cs" Inherits="SIGERHSis.Interface.ModuloExpedientes.WFCrearContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="CantidadHoras:"></asp:Label>
    <asp:TextBox ID="TextBoxCantidadHoras" runat="server" AutoPostBack="True"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>    
    <asp:Table ID="TableUsuarios" runat="server">
    </asp:Table>
    <br />
    <asp:Button ID="botonCrearContrato" runat="server" Text="Crear Contrato" 
        onclick="botonCrearContrato_Click" />
    <asp:Label ID="labelResultado" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>


