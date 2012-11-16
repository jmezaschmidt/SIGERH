<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/Capacitaciones.Master" AutoEventWireup="true" CodeBehind="WFDRHCrearCapacitacion.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFDRHCrearCapacitacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblCrearCapacitacion" runat="server" Text="Crear Capacitación"></asp:Label>
    <br />
    <asp:Label ID="lblNombreCapacitacion" runat="server" Text="Capacitación: "></asp:Label>
    <asp:TextBox ID="TextBoxNombreCapacitacion" runat="server"></asp:TextBox>
    <div style="float: left">
    
    Fecha inicial: <asp:TextBox ID="fechaInicial" runat="server" type="date"></asp:TextBox>
    &nbsp;</div>
    <div>
  
    Fecha final: <asp:TextBox ID="fechaFinal" runat="server" type="date"></asp:TextBox>
  &nbsp;</div>
    
    Descripcion:
    
    <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
    <asp:Label ID="lblDuracion" runat="server" Text="Duración en horas: "></asp:Label>
    <asp:TextBox ID="TextBoxDuracion" runat="server"></asp:TextBox>
    <asp:Button ID="btnCrear" runat="server" Text="Crear Capacitación" 
        onclick="btnCrear_Click"  />
    <asp:Label ID="LabelResultado" runat="server"></asp:Label>
</asp:Content>
