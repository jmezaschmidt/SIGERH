<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFcrearDepartamento.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFcrearDepartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre de Departamento:"></asp:Label>
    <asp:TextBox ID="TextBoxNombre" runat="server" AutoPostBack="True"></asp:TextBox>
    
    <br />
    <asp:Label ID="Label2" runat="server" Text="Descripcion:"></asp:Label>
    <asp:TextBox ID="TextBoxDescripcion" runat="server" AutoPostBack="True"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Departamento Padre:"></asp:Label>
    <asp:DropDownList ID="ListDepartamento" runat="server" AutoPostBack="True">
</asp:DropDownList>
    <br />
    <asp:Button ID="BotonCrearDepartamento" runat="server" 
        Text="Crear Departamento" onclick="BotonCrearDepartamento_Click" />
    <asp:Label ID="labelResultado" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

