using System;
using System.Configuration;
using System.Globalization; // CultureInfo
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtKorkeus.Text.Length * txtLeveys.Text.Length * txtKarminLeveys.Text.Length > 0)
            {
                double leveys = Convert.ToDouble(txtLeveys.Text);
                double korkeus = Convert.ToDouble(txtKorkeus.Text);
                double karmi = Convert.ToDouble(txtKarminLeveys.Text);
                double pintaala = ((korkeus - (2 * karmi)) / 1000) * ((leveys - (2 * karmi)) / 1000); //m2 ­
                double piiri = 2 * ((leveys / 1000) + (korkeus / 1000)); // jm
                double aluhinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiininhinta"]); //€/m2
                double lasihinta = 45; //€/jm
                double tyomenekki = 150; //€/ikkuna
                double kate = 0.3; //kate 30% on 0.3
                //hinnan laskenta
                double hinta = (1 + kate) * ((pintaala * lasihinta) + (piiri * aluhinta) + tyomenekki);
                lblHinta.Text = hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-Fi"));
                lblKarminPiiri.Text = piiri.ToString();
                lblPintaala.Text = pintaala.ToString();
            }
            else
            {
                lblMessages.Text = "Tarkista syötteet, jokin puuttuu..";
            }
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}