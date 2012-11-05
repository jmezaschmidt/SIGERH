<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFLogin.aspx.cs" Inherits="SIGERHSis.Interface.ModuloUsuarios.WFLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../../css/Login.css" rel="stylesheet" type="text/css" />

    <title>Bievenidos!  SIGERH</title>
</head>
<body>
    

    <div id="header" align="center">
        <img id="imagen_SIGERH" alt="" src="../../Images/SIGERGH%20Logo.png" /></div>
    <div id="content">
        <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; color: #0099FF; margin-top: 20px;" 
            align="center">
        Inicio de Sesión
        </div>
        <div style="float: left; width: 250px; margin-top: 40px; margin-left: 75px">
        <div class="labelsLogin">
        Usuario:
        </div>
        <div>
            <asp:TextBox ID="textBoxUsuario" runat="server" ForeColor="#003399" Width="213px" 
                Height="26px" Font-Size="Larger"></asp:TextBox>
        </div>
        </div>       
        <div style="float: left; width: 300px; margin-top: 40px">
                <div class="labelsLogin">
                    <asp:Label ID="Label1" runat="server" Text="Contraseña:"></asp:Label>
                </div>
             <div>
                 <asp:TextBox ID="textBoxContrasena" runat="server"  ForeColor="#003399" Width="213px" 
                Height="26px" TextMode="Password" Font-Size="Larger"></asp:TextBox>
             </div>
          </div>
        <div style="margin-top: 130px">
            <div style="width: 185px; margin-left:75px; float: left; margin-right: 65px;">
            <asp:Label ID="Label2" runat="server" Text="Tipo de Usuario: " 
                CssClass="labelsLogin"></asp:Label>
            </div>
            <asp:DropDownList ID="dropDownListTipoU" runat="server" BackColor="White" 
                Font-Size="Larger" ForeColor="#003399">
            </asp:DropDownList>
        </div>
        <div align="center" style="margin-top: 30px">
            <asp:Button ID="buttonIngresar" runat="server" Text="Ingresar" BackColor="#3366FF" 
                Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="43px" 
                Width="130px" BorderStyle="None" />
        </div>
        </form>
    </div>
    <div id="footer" class="nombresFooter" align="center">
        
        <div class="nombresFooter">
            Alejandra Monge Granados
        </div>
        <div class="nombresFooter">
            Javier Meza Meza Schmidt
        </div>
        <div class="nombresFooter">
            Mauricio Munoz Chaves
        </div>
        <div style="margin-top: 20px">
            <asp:Image ID="imagenTec" runat="server" ImageUrl="~/Images/logoTec.jpg" 
                Width="200px" />
        </div>
     </div>
</body>
</html>
