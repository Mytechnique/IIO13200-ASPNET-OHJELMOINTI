﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppilaat.aspx.cs" Inherits="Oppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h2>Oppilaat</h2>
            <div>
                <asp:Button id="btnGet3" runat="server" Text="Hae 3 oppilasta" onClick="btnGet3_Click"/>
                <asp:Button id="btnGetAll" runat="server" Text="Hae kaikki oppilaat" onClick="btnGetAll_Click"/>
            </div>
        <div id="tulos">
            <asp:GridView ID="gvStudents" runat="server"/>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessage" runat="server" />
        </div>
    
    </div>
    </form>
</body>
</html>
