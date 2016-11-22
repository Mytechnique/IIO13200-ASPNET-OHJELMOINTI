using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava3 : System.Web.UI.Page
{
    DateTime now;
    DateTime selectedDate;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Määritellään tämän hetkinen aika
        now = DateTime.Now;

    }

    protected void clndrKalenteri_SelectionChanged(object sender, EventArgs e)
    {
        foreach(DateTime day in clndrKalenteri.SelectedDates)
        {
            // Päivämäärä lblValittu -labeliin valinnasta
            lblValittu.Text = day.Date.ToShortDateString();
            selectedDate = day.Date;

            // Vuosi valitusta päivästä lblVuosi -labeliin
            lblVuosi.Text = day.Year.ToString();

            // Päivien erotus pyöristettynä lblErotus -labeliin
            TimeSpan temp = now - selectedDate;
            int days = (int)Math.Abs(Math.Round(temp.TotalDays));
            lblErotus.Text = days.ToString();
        }



    }

    protected void btnVuosiTaaksepain_Click(object sender, EventArgs e)
    {
        // Pitää määritellä tämä, koska kalenteri aloittaa muuten vähennettäessä vuodet alusta (0000)
        if (clndrKalenteri.VisibleDate == DateTime.MinValue) { clndrKalenteri.VisibleDate = DateTime.Now; }
            clndrKalenteri.VisibleDate = clndrKalenteri.VisibleDate.AddYears(-1);
        
            
    }

    protected void btnVuosiEteenpain_Click(object sender, EventArgs e)
    {
        // Pitää määritellä tämä, koska kalenteri aloittaa muuten lisättäessä vuodet alusta (0000)
        if (clndrKalenteri.VisibleDate == DateTime.MinValue) { clndrKalenteri.VisibleDate = DateTime.Now; }
        clndrKalenteri.VisibleDate = clndrKalenteri.VisibleDate.AddYears(1);
    }
}