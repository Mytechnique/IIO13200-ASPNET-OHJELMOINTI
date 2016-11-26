<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Palautteet.aspx.cs" Inherits="Palautteet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Palautteen luku</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnXMLLoad" runat="server" Text="Load XML" OnClick="btnXMLLoad_Click" />
        <asp:Button ID="btnSQLLOAD" runat="server" Text="Load SQL" OnClick="btnSQLLOAD_Click" />
        <asp:GridView ID="gvResults" runat="server"></asp:GridView>
        <asp:Label ID="lblMessages" runat="server"></asp:Label>
        <br />
        <a href="Tehtava7.aspx">Lähetä uusi palaute</a>
    </div>
    </form>
</body>
</html>
