<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpedienteJefe.Master" AutoEventWireup="true" CodeBehind="WebFormInfoGeneralExpedienteJefe.aspx.cs" Inherits="SIGERHSis.Interface.WebFormInfoGeneralExpedienteJefe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #ige_content 
        {
            background-color: #f1a30b;
            width: 625px;
            height: 169px;
            margin-top: 50px;
            text-align: left;
            font-size: 20px;
            font-family: Arial;
            padding: 20px;
        }
        p 
        {
            margin-top: 5px;
            margin-bottom: 0px;
        }
        #Div1
        {
            float: left;
        }
        #Div2
        {
            float: right;
        }
        label 
        {
            font-weight: bold;
            color: #000736;
        }
            
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ige_content">
        <div id="Div1">
            <p style="margin-top: 0px;"><label>Nombre: </label>Mauricio Muñoz Chaves</p>
            <p><label>Cédula: </label>114740899</p>
            <p><label>Fecha de Nacimiento: </label>01/03/1991</p>
            <p><label>Puesto: </label>Jefe</p>
            <p><label>Departamento: </label>TI</p>
            <p><label>Fecha de Ingreso: </label>20/09/2012</p>
        </div>
        <div id="Div2">
            <asp:Image ID="foto" runat="server" Height="134px" Width="102px" 
                style="margin-left: 0px" ImageUrl="~/Images/foto.JPG"/>
        </div>
            
    </div>
</asp:Content>
