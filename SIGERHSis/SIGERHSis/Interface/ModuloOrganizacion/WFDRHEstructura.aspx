<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WDRHDepartamentos.Master" AutoEventWireup="true" CodeBehind="WFDRHEstructura.aspx.cs" Inherits="SIGERHSis.Interface.ModuloOrganizacion.WFDRHEstructura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js"></script>
    <link href="../../css/jOrgChart.css" rel="stylesheet" type="text/css" />
    <script src="../../jquery.jOrgChart.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript">
    jQuery(document).ready(function () {
        $("#org").jOrgChart();
    });
</script>
    <title></title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <div id="organigrama" runat="server" style="overflow: scroll; height:270px; width: 100%;">
    
    </div>
    
</asp:Content>
