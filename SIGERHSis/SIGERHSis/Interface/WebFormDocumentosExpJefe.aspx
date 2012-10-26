<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpedienteJefe.Master" AutoEventWireup="true" CodeBehind="WebFormDocumentosExpJefe.aspx.cs" Inherits="SIGERHSis.Interface.WebFormDocumentosExpJefe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        #ige_content 
        {
            background-color: #f1a30b;
            width: 625px;
            text-align: left;
            margin-top: 50px;
            font-size: 20px;
            font-family: Arial;
            padding: 20px;
        }
        p 
        {
            margin: 10px 0 0 0;
        }
        label 
        {
            font-weight: bold;
            color: #000736;
        }
        #links 
        {
            float: left;
        }
        #imagen 
        {
            float: right;
        }
            
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="ige_content">
        <div id="links">
            <p style="margin-top: 0px;"><a href="">Currículo.pdf</a></p>
            <p><a href="">Fotografía_tamaño_pasaporte.png</a></p>
            <p><a href="">Contrato_firmado.pdf</a></p>
        </div>
        <div id="imagen">
            <asp:Image ID="Image1" runat="server" Height="82px" 
                ImageUrl="~/Images/download.png" Width="83px" />        
        </div>
    </div>
</asp:Content>
