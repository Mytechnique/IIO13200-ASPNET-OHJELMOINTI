<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava6.aspx.cs" Inherits="Tehtava6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcRecords" DataFile="~/App_Data/LevykauppaX.xml" XPath="//record" runat="server"></asp:XmlDataSource>
    </div>
        <div>
            <asp:Repeater ID="Repeater1" DataSourceID="srcRecords" runat="server">
                <ItemTemplate>
                            <table>
                                <tr>
                                    <td><image src="Images/<%# Eval("ISBN")%>.jpg" alt="<%# Eval("ISBN")%>.jpg" style='width: 200px; height: 200px'></image></td>
                                    <td style="text-align:start"><h2><%# Eval("Artist") %> - <%# Eval("Title")%></h2>
                                    <br />
                                    <p><b>ISBN:</b> <a href="DetailedInfo.aspx?isbn=<%#Eval("ISBN") %>"><%#Eval("ISBN")%></a> <br />
                                    <b>Hinta:</b><%# Eval("Price") %>
                                    </p> <br />
                                    </td>
                                </tr>
                            </table>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
