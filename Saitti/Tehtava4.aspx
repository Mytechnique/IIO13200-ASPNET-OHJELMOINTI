<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava4.aspx.cs" Inherits="Tehtava4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Tehtava 4</h1>
    <h2>Data haettu SQLDatSourcen Avulla:</h2><br />
    <asp:SqlDataSource id="srcAsiakkaat" runat="server" ConnectionString="<%$ ConnectionStrings:Asiakkaat %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
    <asp:GridView ID="gvAsiakkaatSQLSrc" runat="server" DataSourceID="srcAsiakkaat"></asp:GridView><br /><br />
    <h2>Data haettu DBDemoxOy luokan metodien avulla: </h2><br />
    <asp:GridView ID="gvAsiakkaat" runat="server"></asp:GridView>
</asp:Content>

