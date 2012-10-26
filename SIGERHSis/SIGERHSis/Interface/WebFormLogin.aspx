<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="SIGERHSis.Interface.WebFormLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="header">
    </div>
    <div id="content" class="loginContent">
        <form id="form2" runat="server">
        <div style=>
            <div style="float: left; width: 40%; margin-top: 140px; margin-left: 100px; height: 32px;">
                <asp:Label ID="Label1" runat="server" Text="Usuario: " CssClass="textoLogin"></asp:Label>
            </div>
            <div style="width: 45%; float: right; margin-top: 140px;">
               <asp:TextBox ID="TextBox1" runat="server" CssClass="textoInputLogin"></asp:TextBox>
            </div>
        </div>
       <div>
            <div style="float: left; width: 40%; margin-top: 30px;margin-left: 100px;">
                <asp:Label ID="Label2" runat="server" Text="Contraseña: " CssClass="textoLogin"></asp:Label>
            </div>
            <div style="width: 45%; float: right; margin-top: 30px;">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textoInputLogin" 
                    TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div>
            <div style="float: left; width: 40%; margin-top: 30px;margin-left: 100px;">
                <asp:Label ID="Label3" runat="server" Text="Tipo de Usuario: " 
                    CssClass="textoLogin"></asp:Label>
            </div>
            <div style="width: 45%; float: right; margin-top: 30px;">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="textoInputLogin" 
                    Height="16px" Width="121px">
                </asp:DropDownList>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Ingresar" CssClass="botonLogin" onclick="Button1_Click" 
               />
        </div>
        
        </form>

    </div>
    <div id="footer">
    </div>
    
</body>
</html>
