<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava5.aspx.cs" Inherits="Tehtava5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="buttons">
        <asp:Button ID="btnGetAllCustomers" runat="server" Text="Hae kaikki asiakkaat" OnClick="btnGetAllCustomers_Click" />
        <asp:DropDownList ID="ddlCustomerCountry" runat="server"></asp:DropDownList>
        <asp:Button ID="btnGetAllCustomersFromCountry" runat="server" Text="Hae asiakkaat valitusta maasta" OnClick="btnGetAllCustomersFromCountry_Click" />
        <asp:Button ID="btnGetAllCustomersFromAllCountries" runat="server" Text="Hae asiakkaat maittain" />
    </div>

    <div id="data">
        <asp:GridView ID="gvAsiakkaat" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
