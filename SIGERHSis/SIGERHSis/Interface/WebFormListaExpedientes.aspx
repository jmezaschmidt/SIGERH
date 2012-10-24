<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormListaExpedientes.aspx.cs" Inherits="SIGERHSis.Interface.WebFormListaExpedientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float: left; width: 49%;">

        <br />

        <asp:GridView ID="GridViewExpedientes" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            style="font-family: Arial, Helvetica, sans-serif">
        
        </asp:GridView>

    </div>
    <div style="float: right; width: 50%;">

        <br />
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Text="Elija el departamento"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ListDepartamento" runat="server">
        </asp:DropDownList>

        <br />
        <br />
        <br />
        <asp:Button ID="ButtonVerExpediente" runat="server" Text="Ver Expediente" 
            style="font-family: Arial, Helvetica, sans-serif" />

        <br />

    </div>

    </asp:Content>
