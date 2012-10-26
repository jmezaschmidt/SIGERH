<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageJefe.Master" AutoEventWireup="true" CodeBehind="WebFormSolicitudesPendientesJefe.aspx.cs" Inherits="SIGERHSis.Interface.WebFormSolicitudesPendientesJefe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="float: left; width: 49%;">

        <br />

        <asp:GridView ID="GridViewSolicitudes" runat="server"             
            style="font-family: Arial, Helvetica, sans-serif" 
            AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="Solicitud" HeaderText="Solicitud" 
                    SortExpression="Solicitud" />                
                <asp:TemplateField HeaderText="Ver">
                <ItemTemplate>
                    <input name="MyRadioButton" type="radio" />
                </ItemTemplate>
              </asp:TemplateField>

            </Columns>
        
        </asp:GridView>

        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XML/solicitudesPendientes.xml"></asp:XmlDataSource>

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
        <asp:Label ID="Label3" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
            Text="Elija tipo de solicitud"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ListTipoSolicitud" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonVerSolicitud" runat="server" Text="Ver Solicitud" 
            style="font-family: Arial, Helvetica, sans-serif" />

        <br />

    </div>
</asp:Content>
