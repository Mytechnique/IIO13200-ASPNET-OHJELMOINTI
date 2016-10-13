<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedon välitys demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Source -sivu</h1>
        <p>
        Lähettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
        <!-- tässä valmis lista josta voi valita sopivan valmiin lauseen -->
            <asp:DropDownList ID="ddlMessages" runat="server" 
                OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" 
                AutoPostBack="True"></asp:DropDownList>
        <br />
        <!-- vaihtoehto 1: QueryString -->
        <asp:Button ID="btnQueryString" 
            runat="server" Text="Käytä QueryString"
            onclick="btnQueryString_Click" /><br />
        <!-- vaihtoehto 2: HttpPost -->
        <asp:Button ID="btnHttpPost" 
            runat="server" Text="Käytä HttpPost"
            PostBackUrl="~/Tapa2.aspx" /><br />
        <!-- vaihtoehto 3: session -->
        <asp:Button ID="btnSession" 
            runat="server" Text="Käytä Session"
            onclick="btnSession_Click" /><br />
        <!-- vaihtoehto 4: cookie -->
        <asp:Button ID="btnCookie" 
            runat="server" Text="Käytä keksiä "
            onclick="btnCookie_Click" /><br />
        <!-- vaihtoehto 5: Public Property -->
        <asp:Button ID="btnProperty" 
            runat="server" Text="Käytä ominaisuutta (Public property) "
            onclick="btnProperty_Click" /><br />

        </p>
    </div>
    </form>
</body>
</html>
