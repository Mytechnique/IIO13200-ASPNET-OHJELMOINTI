
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="w3container w3-light-green">
            <h1>IIO13200. NET Ohjelmointi</h1>
            <h2>1.kontaktikerta</h2>
            <p>H8599:n oma webbisaitti.</p>
            <h1>Perus HTML kontrolleja</h1>
            <a href="VKTehtava01.aspx">VK01</a><br />
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
        </div>
    </form>
</body>
</html>