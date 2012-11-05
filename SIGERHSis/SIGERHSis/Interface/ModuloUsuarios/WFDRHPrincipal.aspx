﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/WFDRH.Master" AutoEventWireup="true" CodeBehind="WFDRHPrincipal.aspx.cs" Inherits="SIGERHSis.Interface.ModuloUsuarios.WFDRHPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script type="text/javascript">
    function searchTable(inputVal) {
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
            <input id="search" type="text" onkeyup="searchTable($(this).val())"/>
            <label>
            e.g. bar, parking, tv</label>
        </p>
        <table id="tblData" bgcolor="#ACAAFC" class="target" width="100%">
            <tr>
                <th width="10%">
                    #</th>
                <th width="35%">
                    Hotel Name</th>
                <th width="55%">
                    Facilities</th>
            </tr>
            <tr>
                <td class="odd">
                    1</td>
                <td class="odd">
                    Manu Maharani</td>
                <td class="odd">
                    Attached Bath, Bar, Swimming Pool,
                </td>
            </tr>
            <tr>
                <td class="even">
                    2</td>
                <td class="even">
                    Hill View</td>
                <td class="even">
                    TV, In-Room Safe, Bar</td>
            </tr>
            <tr>
                <td class="odd">
                    3</td>
                <td class="odd">
                    Hotel Suba Galaxy</td>
                <td class="odd">
                    Paid Internet Access, Coffee Shop, Spa</td>
            </tr>
            <tr>
                <td class="even">
                    4</td>
                <td class="even">
                    The Residence Hotel</td>
                <td class="even">
                    Doctor on Call, Parking</td>
            </tr>
            <tr>
                <td class="odd">
                    5</td>
                <td class="odd">
                    The Taj</td>
                <td class="odd">
                    Currency Exchange, Bar, Golf</td>
            </tr>
            <tr>
                <td class="even">
                    6</td>
                <td class="even">
                    Mumbai Grand</td>
                <td class="even">
                    Jacuzzi, Spa, Coffee Shop</td>
            </tr>
            <tr>
                <td class="odd">
                    7</td>
                <td class="odd">
                    The Promenade</td>
                <td class="odd">
                    Cable TV, Coffee Shop, Spa</td>
            </tr>
            <tr>
                <td class="even">
                    8</td>
                <td class="even">
                    Hotel Regency</td>
                <td class="even">
                    Mini Bar,Golf, Spa, Sauna</td>
            </tr>
            <tr>
                <td class="odd">
                    9</td>
                <td class="odd">
                    Park Plaza</td>
                <td class="odd">
                    Currency Exchange, Bar, Golf</td>
            </tr>
            <tr>
                <td class="even">
                    10</td>
                <td class="even">
                    The Mapple Inn</td>
                <td class="even">
                    Jacuzzi, Spa, Coffee Shop</td>
            </tr>
            <tr>
                <td class="odd">
                    11</td>
                <td class="odd">
                    Cidade de Goa</td>
                <td class="odd">
                    Cable TV, Coffee Shop, Spa</td>
            </tr>
            <tr>
                <td class="even">
                    12</td>
                <td class="even">
                    Saurabh Mountview</td>
                <td class="even">
                    Doctor, Free Parking</td>
            </tr>
        </table>
    </div>
</asp:Content>
