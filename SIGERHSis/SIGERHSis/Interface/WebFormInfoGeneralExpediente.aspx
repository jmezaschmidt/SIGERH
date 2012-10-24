<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpediente.Master" AutoEventWireup="true" CodeBehind="WebFormInfoGeneralExpediente.aspx.cs" Inherits="SIGERHSis.Interface.WebFormInfoGeneralExpediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: left;
            width: 401px;
        }
        #ige_content 
        {
            background-color: #F8B30C;
            width: 522px;
            height: 188px;
            text-align: left;
            margin-top: 50px;
        }
        p 
        {
            margin: 10px 0 0 20px;
        }
        #Div1
        {
            float: left;
        }
        #Div2
        {
            float: right;
            margin: 30px 30px 0 0;
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
            <p><label>Nombre: </label>Mauricio Muñoz Chaves</p>
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
