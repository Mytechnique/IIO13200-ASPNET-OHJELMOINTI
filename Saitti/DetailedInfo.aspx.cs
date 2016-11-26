using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class DetailedInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string isbn = Request.QueryString["isbn"];
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(Server.MapPath("~/App_Data/LevykauppaX.xml"));
        XmlNodeList records = xmldoc.SelectNodes("/Records/genre/record[@ISBN='" + isbn + "']");
        foreach (XmlNode r in records)
        {
            levyInfo.InnerHtml += "<img src='Images/" + isbn + ".jpg' style='width: 200px; height: 200px'/><br>";
            levyInfo.InnerHtml += "<h2>" + r.Attributes["Artist"].Value + " - " + r.Attributes["Title"].Value + "</h2>";
            levyInfo.InnerHtml += "<b>ISBN:</b> " + isbn + "<br>";
            levyInfo.InnerHtml += "<b>Hinta:</b> " + r.Attributes["Price"].Value + "<br>";
        }
        XmlNodeList songs = xmldoc.SelectNodes("/Records/genre/record[@ISBN='" + isbn + "']/song");
        foreach (XmlNode s in songs)
        {
            levyKappaleet.InnerHtml += s.Attributes["name"].Value + "<br>";
        }
    }
}