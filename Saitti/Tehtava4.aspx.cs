using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = JAMK.IT.DBDemoxOy.GetDataReal();
        gvAsiakkaat.DataSource = dt;
        gvAsiakkaat.DataBind();
    }
}