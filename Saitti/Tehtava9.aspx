<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava9.aspx.cs" Inherits="Tehtava9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Train Schedules</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlStations" runat="server"></asp:DropDownList>
        <asp:Button ID="btnGetDepartingTrains" runat="server" Text="Hae lähtevät junat" OnClick="btnGetDepartingTrains_Click" /><br />
        <asp:GridView ID="gvTrains" runat="server"></asp:GridView>
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
