<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormReportarAusencia.aspx.cs" Inherits="SIGERHSis.Interface.WebFormReportarAusencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #content
        {
            padding: 20px;
            font-family: Arial;
        }
        #grid 
        {
            float: left;
            width: 345px;
            height: 301px;
             overflow: scroll;
        }
        #filtrar 
        {
            text-align: center;
            width: 337px;
            margin-top: 30px;
            float: left;
        }
        #filtrar p
        {
            margin: 8px;
        }
        #info 
        {
            background-color: #f1a30b;
            text-align: left;
            font-size: 15px;
            float: right;
            height: 134px;
            width: 395px;
            padding: 20px;
        }
        #info p 
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
        #info label 
        {
            font-weight: bold;
            color: #000736;
        }
          
        }
        #comentario
        {
            height: 75px;
            width: 350px;
        }
        #ausencia
        {
            text-align: left;
            float: right;
            width: 435px;
            margin-top: 25px;
        }
        #comentario 
        {
            width: 350px;
            height: 70px;
        } 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="grid">
            <asp:GridView ID="GridViewEmpleados" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                Width="314px" Height="80px" AutoGenerateColumns="False" 
                DataSourceID="XmlDataSource1" >
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" 
                        SortExpression="Nombre" />
                    <asp:BoundField HeaderText="Cedula" DataField="Cedula" 
                        SortExpression="Cedula" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
                DataFile="~/XML/expedientes.xml"></asp:XmlDataSource>
        </div>
 
        <div id="info">
            <div id="Div1">
            <p style="margin-top: 0px;"><label>Nombre: </label>Mauricio Muñoz Chaves</p>
            <p><label>Cédula: </label>114740899</p>
            <p><label>Fecha de Nacimiento: </label>01/03/1991</p>
            <p><label>Puesto: </label>Jefe</p>
            <p><label>Departamento: </label>TI</p>
            <p><label>Fecha de Ingreso: </label>20/09/2012</p>
        </div>
        <div id="Div2">
            <asp:Image ID="foto" runat="server" Height="123px" Width="96px" 
                style="margin-left: 0px" ImageUrl="~/Images/foto.JPG"/>
        </div>
        </div>

        <div id="ausencia">
            <p><strong>Reportar Ausencia</strong></p>
            <textarea id="comentario" cols="20" rows="2"></textarea>
            <br />
            <br />
            <asp:Button ID="btnReportar" runat="server" Text="Reportar" />
        </div>

        <div id="filtrar">
            <p><strong>Departamento</strong></p>
            <asp:DropDownList ID="departamentos" runat="server">
                <asp:ListItem>-- Todos --</asp:ListItem>
            </asp:DropDownList>
        </div>

    </div>
</asp:Content>

