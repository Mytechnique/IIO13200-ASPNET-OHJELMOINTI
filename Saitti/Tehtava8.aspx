<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava8.aspx.cs" Inherits="Tehtava8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Elokuvien haku</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="float:left">
            <asp:ListBox ID="lbTheatres" runat="server" Height="400" OnSelectedIndexChanged="lbTeatterit_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        </div>
        <div style="float:left">  
            <asp:DataList ID="dlMovies" runat="server" RepeatColumns="12" RepeatDirection="Horizontal">
                <ItemTemplate>
                   <asp:Image ImageUrl='<%#Eval("MoviePortrait") %>' runat="server" />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    </form>
</body>
</html>
