﻿using System;
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

    protected void GetAllCustomersFromCountry()
    {
        var result = ctx.asiakas
            .Where(c => c.maa == ddlCustomerCountry.SelectedValue).ToList();
        gvAsiakkaat.DataSource = result.ToList();
        gvAsiakkaat.DataBind();
    }

    protected void GetAllCustomersByCountry()
    {
      //  var country = ctx.asiakas.Select(c => c.maa).Distinct();
        foreach (var c in ddlCustomerCountry.Items)
        {
            lblMessages.Text +=
                string.Format("<br> <h2>{0}</h2>", c.ToString());
            var currentCountry = c.ToString();
            foreach (var x in ctx.asiakas.Where(x => x.maa == currentCountry))
            {
                lblMessages.Text +=
                    string.Format("<br> {0} {1}", x.asnimi, x.yhteyshlo);
            }
        }
  
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
        lblMessages.Text = "";
    }

    protected void btnGetAllCustomersFromCountry_Click(object sender, EventArgs e)
    {
        GetAllCustomersFromCountry();
        lblMessages.Text = "";
    }

    protected void btnGetAllCustomersFromAllCountries_Click(object sender, EventArgs e)
    {
        GetAllCustomersByCountry();
        gvAsiakkaat.DataSource = null;
        gvAsiakkaat.DataBind();
    }
}