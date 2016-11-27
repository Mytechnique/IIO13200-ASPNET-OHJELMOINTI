using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Xml;
using System.Web.UI.WebControls;

public partial class Tehtava8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitTheatres();
        }
    }

    protected void InitTheatres()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("http://www.finnkino.fi/xml/TheatreAreas/");
        XmlNodeList nodes = doc.SelectNodes("/TheatreAreas/TheatreArea");
        foreach (XmlNode node in nodes)
        {
            lbTheatres.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
        }
    }

    protected void lbTeatterit_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("MoviePortrait", typeof(string));
        XmlDocument doc = new XmlDocument();
        doc.Load("http://www.finnkino.fi/xml/Schedule/?area=" + lbTheatres.SelectedValue.ToString());
        XmlNodeList nodes = doc.SelectNodes("/Schedule/Shows/Show");
        foreach (XmlNode node in nodes)
        {
            string imgUrl = node.SelectSingleNode("Images/EventSmallImagePortrait").InnerText;
            dt.Rows.Add(imgUrl);
        }
        dlMovies.DataSource = dt;
        dlMovies.DataBind();
    }
}