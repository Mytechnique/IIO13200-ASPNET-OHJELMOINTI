/*
 * Mytechnique - H8599
 * 15.9.2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Configuration;


public partial class VKTehtava01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        //lasketaan ikkunan tarjoushinta
        try
        {
            //käyttäjän syötteet on AINA syytä tarkistaa
            if(txtKorkeus.Text.Length * txtLeveys.Text.Length * txtKarmiLeveys.Text.Length > 0)
            {
                double leveys = Convert.ToDouble(txtLeveys.Text);
                double korkeus = Convert.ToDouble(txtKorkeus.Text);
                double karmi = Convert.ToDouble(txtKarmiLeveys.Text);
                double pintaala = ((korkeus - (2*karmi)) / 1000) * ((leveys - (2*karmi))/ 1000); //m²
                double piiri = 2 * ((leveys / 1000) + (korkeus / 1000)); //jm
                double aluhinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiininhinta"]); //€/jm
                double lasihinta = Convert.ToDouble(ConfigurationManager.AppSettings["lasihinta"]); //€/m²
                double tyomenekki = Convert.ToDouble(ConfigurationManager.AppSettings["tyomenekki"]); //€/ikkuna
                double kate = Convert.ToDouble(ConfigurationManager.AppSettings["kate"]); ; //kate 30% on 0.3
                //hinnan laskenta
                double hinta = (1 + kate) * ((pintaala * lasihinta) + (piiri * aluhinta) + tyomenekki);
                //tulos
                lblHinta.Text = hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-FI")); //Formatoi currencyksi
                lblKarminpiiri.Text = piiri.ToString();
                lblPintaala.Text = pintaala.ToString();
            }
            else
            {
                lblMessages.Text = "Tarkista syötteet, jokin puuttuu";
            }
        }
        catch(Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}