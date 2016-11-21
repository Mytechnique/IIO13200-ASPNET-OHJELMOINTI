<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava3.aspx.cs" Inherits="Tehtava3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Valitsemasi haluamasi päivä: valittu: <asp:Label ID="lblValittu" runat="server"></asp:Label>
        Vuosi: <asp:Label ID="lblVuosi" runat="server" Text=""></asp:Label> <br />
        Valitun päivän ja tämän päivän erotus: <asp:Label ID="lblErotus" runat="server" Font-Bold="true"></asp:Label> <br />
        <div id="buttons">
            <asp:Button ID="btnVuosiTaaksepain" runat="server" Text="< vuosi" OnClick="btnVuosiTaaksepain_Click"/>
            <asp:Button ID="btnVuosiEteenpain" runat="server" Text="vuosi >" OnClick="btnVuosiEteenpain_Click" />
        </div>
        <div id="kalenteri">
            <asp:Calendar ID="clndrKalenteri" runat="server" OnSelectionChanged="clndrKalenteri_SelectionChanged"></asp:Calendar>
        </div>
        
    </div>
    </form>
</body>
</html>
