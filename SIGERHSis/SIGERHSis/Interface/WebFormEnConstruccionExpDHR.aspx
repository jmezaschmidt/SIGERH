<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpediente.Master" AutoEventWireup="true" CodeBehind="WebFormEnConstruccionExpDHR.aspx.cs" Inherits="SIGERHSis.Interface.WebFormEnConstruccionExpDHR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/en_construccion.gif" />
    <br />
    <asp:Label
        ID="Label1" runat="server" Text="Lo sentimos, página en construcción" 
        CssClass="textoLogin"></asp:Label>
</asp:Content>
