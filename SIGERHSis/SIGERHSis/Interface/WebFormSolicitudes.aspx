<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormSolicitudes.aspx.cs" Inherits="SIGERHSis.Interface.WebFormSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float: left; width: 49%;">

        <br />

        <asp:GridView ID="GridViewSolicitudes" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif" 
            DataSourceID="XmlDataSource1">
        
        </asp:GridView>

        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XML/expedientes.xml"></asp:XmlDataSource>

    </div>
    <div style="float: right; width: 50%;">

        <span class="style1"><strong>
        <br />
        <br />
        Elija el departamento<br />
        </strong></span>
        <br />
        <asp:DropDownList ID="ListDepartamento" runat="server">
        </asp:DropDownList>

        <br />
        <br />
        <asp:Label ID="Label1" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
            Text="Tipo de Solicitud"></asp:Label>

        <br />
        <br />
        <asp:Button ID="ButtonVerSolicitudes" runat="server" Text="Ver Solicitud" />

        <br />

    </div>

    </asp:Content>
