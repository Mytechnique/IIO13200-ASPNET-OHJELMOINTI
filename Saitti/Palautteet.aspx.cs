using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Palautteet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnXMLLoad_Click(object sender, EventArgs e)
    {
        string connection_string = ConfigurationManager.AppSettings["XML"];
        gvResults.DataSource = null;
        gvResults.DataBind();
        lblMessages.Text = "";
        try
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Server.MapPath(connection_string));
            gvResults.DataSource = dataSet;
            gvResults.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }

    protected void btnSQLLOAD_Click(object sender, EventArgs e)
    {

    }
}