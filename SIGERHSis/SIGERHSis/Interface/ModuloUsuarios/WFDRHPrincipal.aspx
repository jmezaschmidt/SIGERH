<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFDRHPrincipal.aspx.cs" Inherits="SIGERHSis.Interface.ModuloUsuarios.WFDRHPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    function calledFn() {
        alert("code fired");
    } 
    </script> 
<script type="text/javascript">
    function searchTable() {
        var inputVal = document.getElementById('TextBox1').value;
        var table = $('#tblData');
        table.find('tr').each(function (index, row) {
            var allCells = $(row).find('td');
            if (allCells.length > 0) {
                var found = false;
                allCells.each(function (index, td) {
                    var regExp = new RegExp(inputVal, 'i');
                    if (regExp.test($(td).text())) {
                        found = true;
                        return false;
                    }
                });
                if (found == true) $(row).show(); else $(row).hide();
            }
        });
    }

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tables">
        <p>
            <label for="search">
            <strong>Enter keyword to search </strong>
            </label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <input id="search" type="text" onkeyup="searchTable()"/>
            <label>
            e.g. bar, parking, tv</label>
        </p>
       <div style="overflow: scroll;height:400px">
         <table width="100%" id="tblData"  bgcolor="#ACAAFC">
         <tbody>
          <tr>
            <td colspan="2"><h2>Colaboradores</h2></td>
          </tr>
          <tr>
            <td>Nombre</td>
            <td>Cédula</td>
            <td>Puesto</td>
            <td>Departamento</td>
          </tr>
          <tr>
            <td>CAsa</td>
            <td>perro</td>
            <td>Pue</td>
            <td>Dep</td>
          </tr>
          </tbody>
        </table>

        </div>
        
    </div>
</asp:Content>
