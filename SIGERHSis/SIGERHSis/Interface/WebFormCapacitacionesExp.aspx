<%@ Page Title="" Language="C#" MasterPageFile="~/TemplatePageExpediente.Master" AutoEventWireup="true" CodeBehind="WebFormCapacitacionesExp.aspx.cs" Inherits="SIGERHSis.Interface.WebFormCapacitacionesExp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #content
        {
            padding: 20px;
            font-family: Arial;
        }
        #grid 
        {
            width: 685px;
            height: 200px;
        }
        #descripcion 
        {
            width: 54%;
            text-align: left;
            margin-top: 35px;
        }
        #descripcion p
        {
            text-align: justify;
            margin: 0px;
        }
        h1
        {
            font-size: 20px;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="grid">
            <asp:GridView ID="GridViewEmpleados" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                Width="685px" Height="80px" >
                <Columns>
                    <asp:BoundField HeaderText="Capacitación" />
                    <asp:BoundField HeaderText="Fecha Inicial" />
                    <asp:BoundField HeaderText="Fecha Final" />
                    <asp:BoundField HeaderText="Estado" />
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
        </div>

        <div id="descripcion">
            <h1>Descripción</h1>
            <p>Proin consectetur lacus at libero faucibus in faucibus purus tempor. Phasellus porta felis at neque vestibulum ornare. Sed sollicitudin hendrerit arcu vitae mollis. Sed eget diam mauris. Vestibulum eleifend massa non est dictum et volutpat nulla egestas. In sed lectus a tortor consectetur rhoncus. Sed a luctus est.</p>
        </div>
    </div>
</asp:Content>
