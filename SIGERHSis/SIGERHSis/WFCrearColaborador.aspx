<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFCrearColaborador.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFCrearColaborador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="TextBoxNombre" runat="server" AutoPostBack="True"></asp:TextBox>

    <br />
    <asp:Label ID="Label2" runat="server" Text="Apellido1:"></asp:Label>
    <asp:TextBox ID="TextBoxApellido1" runat="server" AutoPostBack="True"></asp:TextBox>

    <br />
    <asp:Label ID="Label3" runat="server" Text="Apellido2:"></asp:Label>
    <asp:TextBox ID="TextBoxApellido2" runat="server" AutoPostBack="True"></asp:TextBox>

    <br />
    <asp:Label ID="Label4" runat="server" Text="Cedula:"></asp:Label>
    <asp:TextBox ID="TextBoxCedula" runat="server" AutoPostBack="True"></asp:TextBox>

    <br />
    <asp:Label ID="Label5" runat="server" Text="fechaNacimiento:"></asp:Label>
    <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
    
    <br />
    <asp:Label ID="Label6" runat="server" Text="Tipo de Usuairio:"></asp:Label>
    <asp:DropDownList ID="ListTipoUsuario" runat="server" AutoPostBack="True">
        <asp:ListItem>Colaborador</asp:ListItem>
        <asp:ListItem>Administrador</asp:ListItem>
        <asp:ListItem>DireccionRH</asp:ListItem>
        <asp:ListItem>Jefe</asp:ListItem>
    </asp:DropDownList>

    <br />
    <asp:Label ID="Label7" runat="server" Text="Departamento:"></asp:Label>
    <asp:DropDownList ID="ListDepartamento" runat="server" AutoPostBack="True">
    </asp:DropDownList>

    <br />
    <asp:Label ID="Label8" runat="server" Text="Puesto"></asp:Label>
    <asp:DropDownList ID="ListPuesto" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <asp:Button ID="botonCrearUsuario" runat="server" 
        onclick="botonCrearUsuario_Click" Text="Crear Usuario" />
    <asp:Label ID="labelResultado" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

