<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/Proyectos.Master" AutoEventWireup="true" CodeBehind="WFRDHCrearProyecto.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFRDHCrearProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblCrearProyecto" runat="server" Text="Crear Proyecto"></asp:Label>
    <br />
    <asp:Label ID="lblNombreProyecto" runat="server" Text="Nombre del proyecto: "></asp:Label>
    <asp:TextBox ID="TextBoxNombreProyecto" runat="server"></asp:TextBox>
    <div style="float: left">
    
    Fecha inicial: <asp:TextBox ID="fechaInicial" runat="server" type="date"></asp:TextBox>
    &nbsp;</div>
    <div>
  
    Fecha final: <asp:TextBox ID="fechaFinal" runat="server" type="date"></asp:TextBox>
  &nbsp;</div>
    
    Descripcion:
    
    <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
    <asp:Button ID="btnCrearProyecto" runat="server" Text="Crear Proyecto" 
        onclick="btnCrearProyecto_Click" />
    <asp:Label ID="LabelResultado" runat="server"></asp:Label>
</asp:Content>

