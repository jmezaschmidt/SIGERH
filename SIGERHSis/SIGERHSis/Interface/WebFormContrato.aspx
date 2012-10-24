<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpediente.Master" AutoEventWireup="true" CodeBehind="WebFormContrato.aspx.cs" Inherits="SIGERHSis.Interface.WebFormContrato" %>
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
            
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ige_content">
        <p style="margin-top: 0px;"><label>Fecha de ingreso: </label>20/09/2012</p>
        <p><label>Jornada laboral: </label>Diurno - Tiempo completo</p>
        <p><label>Horas asignadas: </label>07:30am - 3:30pm</p>
        <p><label>Estado: </label>Activo</p>
    </div>
</asp:Content>
