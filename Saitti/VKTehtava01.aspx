<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VKTehtava01.aspx.cs" Inherits="VKTehtava01" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="w3container w3-light-blue">
    <h2>Ikkunan dimensiot</h2>
        <table>
            <tr>
                <td>Leveys (L)</td>
                <td>
                    <asp:TextBox ID="txtLeveys" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>

            <tr>
                <td>Korkeus (H)</td>
                <td> <asp:TextBox ID="txtKorkeus" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>

             <tr>
                <td>Leveys (W)</td>
                <td>
                    <asp:TextBox ID="txtKarmiLeveys" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>
        </table>

        <asp:Button ID="btnLaske" runat="server" Text="Laske tarjoushinta" OnClick="btnLaske_Click" class="w3-blue"/>

        <table>
            <tr>
                <td>Ikkunan pinta-ala: </td>
                <td>
                    <asp:Label ID="lblPintaala" runat="server"></asp:Label></td>
                <td>m2</td>
            </tr>

            <tr>
                <td>Karmin piiri: </td>
                <td> <asp:Label ID="lblKarminpiiri" runat="server"></asp:Label></td>
                <td>m</td>
            </tr>

             <tr>
                <td>Tarjoushinta (Ilman ALV)</td>
                <td>
                    <asp:Label ID="lblHinta" runat="server"></asp:Label></td>
                <td>€</td>
            </tr>
        </table>
    </div>

        <!--Ilmoitukset käyttäjälle -->
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
