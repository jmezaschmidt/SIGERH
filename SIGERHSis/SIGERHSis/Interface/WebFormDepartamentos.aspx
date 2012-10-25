<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormDepartamentos.aspx.cs" Inherits="SIGERHSis.Interface.WebFormDepartamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float: left; width: 49%;">

        <br />
        <asp:Label ID="Label8" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Text="Estructura Organizacional"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonCrearDept" runat="server" Height="26px" 
             Text="Crear Departamento" Width="129px" />
&nbsp;
        <asp:Button ID="ButtonModificarDept" runat="server" 
            Text="Modificar Departamento" />
&nbsp;
        <asp:Button ID="ButtonDeshabilitarDept" runat="server" 
            Text="Deshabilitar Departamento" />

        <br />

        <br />

        <asp:GridView ID="GridViewDepartamentos" runat="server"             
            style="font-family: Arial, Helvetica, sans-serif" 
            AutoGenerateColumns="False" DataSourceID="XmlDataSource1" >
            <Columns>
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" 
                    SortExpression="Estado" />
            </Columns>
        
        
        </asp:GridView>

        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XML/departamentos.xml"></asp:XmlDataSource>

    </div>
    <div style="float: right; width: 50%; text-align: left;">

        <br />
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Text="Informacion del departamento"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif" Text="Departamento:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif" Text="Sede:"></asp:Label>
        <br />
        <br /><asp:Label ID="Label6" runat="server" Text="Estado:" 
            style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
        

        <br />
        <br />
        <asp:Label ID="Label7" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif" Text="Jefe Departamento:"></asp:Label>
        

        <br />

    </div>


</asp:Content>
