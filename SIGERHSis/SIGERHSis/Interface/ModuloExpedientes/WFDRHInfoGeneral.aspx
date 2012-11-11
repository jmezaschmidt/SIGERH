<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRHExpediente.Master" AutoEventWireup="true" CodeBehind="WFDRHInfoGeneral.aspx.cs" Inherits="SIGERHSis.Interface.ModuloExpedientes.WFDRHInfoGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:Label ID="LabelInfoNombre" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelCedula" runat="server" Text="Cédula:"></asp:Label>
    <asp:Label ID="LabelInfoCedula" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelNacimiento" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
    <asp:Label ID="LabelInfoNacimiento" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelPuesto" runat="server" Text="Puesto:"></asp:Label>
    <asp:Label ID="LabelInfoPuesto" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelDepartamento" runat="server" Text="Departamento:"></asp:Label>
    <asp:Label ID="LabelInfoDepartemento" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelIngreso" runat="server" Text="Fecha de Ingreso:"></asp:Label>
    <asp:Label ID="LabelInfoIngreso" runat="server" Text=""></asp:Label>
    <br />
</asp:Content>
