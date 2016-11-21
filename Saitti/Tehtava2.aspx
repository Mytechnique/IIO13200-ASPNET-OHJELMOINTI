<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava2.aspx.cs" Inherits="Tehtava2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Lotto</h1>
        Valitse Loton tyyppi arpoaksesi sen tyyppisen Lotto-rivin. Voit pelata niin monta kertaa kuin haluat, painamalla nappia uudestaan.
        <div id="buttonit">
            <asp:Button ID="btnSuomiLotto" runat="server" Text="Suomi Lotto" OnClick="btnSuomiLotto_Click"/>
            <asp:Button ID="btnVikingLotto" runat="server" Text="Viking Lotto" OnClick="btnVikingLotto_Click"/>
        </div>
        <div id="gridview">
            <asp:GridView ID="gvTulokset" runat="server" ShowHeader="false" Caption="Oikea rivi:" Width="70px"></asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
