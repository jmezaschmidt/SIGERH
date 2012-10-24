<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePage.Master" AutoEventWireup="true" CodeBehind="WebFormAsignarCapacitaciones.aspx.cs" Inherits="SIGERHSis.Interface.WebFormAsignarCapacitaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="float: left; width: 49%;">

        <br />

        <asp:GridView ID="GridViewColaboradores" runat="server"             
            style="font-family: Arial, Helvetica, sans-serif" 
            AutoGenerateColumns="False" DataSourceID="XmlDataSource1" >
            <Columns>              

                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" 
                    SortExpression="Cedula" />
              

                <asp:TemplateField HeaderText="Asignar">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
              

            </Columns>
        
            <EmptyDataTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </EmptyDataTemplate>
        
        </asp:GridView>

        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XML/expedientes.xml"></asp:XmlDataSource>

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
            Text="Capacitacion a asignar"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ListCapacitaciones" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonAsignar" runat="server" Text="Asignar Proyecto" 
            style="font-family: Arial, Helvetica, sans-serif" />

        <br />

    </div>
</asp:Content>
