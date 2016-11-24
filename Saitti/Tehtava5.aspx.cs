using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava5 : System.Web.UI.Page
{
    protected static DemoxOyEntities ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            ctx = new DemoxOyEntities();
            FillControls();
        }

    }
    protected void GetAllCustomers()
    {
        gvAsiakkaat.DataSource = ctx.asiakas.ToList();
        gvAsiakkaat.DataBind();
    }

    protected void FillControls()
    {
        // Asetetaan DropDownListiin maat vain kerran per maa
        var result = ctx.asiakas.Select(c => c.maa).Distinct();
        ddlCustomerCountry.SelectedIndex = -1;
        ddlCustomerCountry.DataSource = result.ToList();
        ddlCustomerCountry.DataBind();
        ddlCustomerCountry.Items.Insert(0, string.Empty); // Lisätään tyhjä rivi ensimmäiseksi valinnaksi sivua ladattaessa

    }

    protected void btnGetAllCustomers_Click(object sender, EventArgs e)
    {
        GetAllCustomers();
    }

    protected void btnGetAllCustomersFromCountry_Click(object sender, EventArgs e)
    {

    }
}