using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainApp;
using System.Text;
using Newtonsoft.Json;

public partial class Tehtava9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitStations();
        }
    }

    protected string GetStationJsonFromWeb()
    {
        string url = "http://rata.digitraffic.fi/api/v1/metadata/stations/";
        using (WebClient wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8; // Ä ja Ö kirjaimia haetussa datassa
            var json = wc.DownloadString(url);
            return json;
            
        }
    }

    protected string GetTrains(string station)
    {
        string url = "http://rata.digitraffic.fi/api/v1/live-trains?station=" + station;
        using (WebClient wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8; // Ä ja Ö kirjaimia haetussa datassa
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void InitStations()
    {
        string data = GetStationJsonFromWeb();
        List<Stations> s = JsonConvert.DeserializeObject<List<Stations>>(data);
        foreach(var station in s)
        {
            ddlStations.Items.Add(new ListItem(station.stationName, station.stationShortCode));
        }
    }

    protected void btnGetDepartingTrains_Click(object sender, EventArgs e)
    {

        string data = GetTrains(ddlStations.SelectedValue.ToString());
        List<Trains> trains = JsonConvert.DeserializeObject<List<Trains>>(data);

        if (trains.Count != 0)
        {
            lblInfo.Text = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainNumber", typeof(string));
            dt.Columns.Add("Peruutettu", typeof(bool));
            dt.Columns.Add("Pvm", typeof(string));
            foreach (var train in trains)
            {
                dt.Rows.Add(train.trainNumber, train.cancelled, train.departureDate);
            }
            gvTrains.DataSource = dt;
            gvTrains.DataBind();
        }
        else
        {
            gvTrains.DataSource = null;
            gvTrains.DataBind();
            lblInfo.Text = "Paikkakunnalla " + ddlStations.SelectedValue.ToString() + " ei valitettavasti kulje tänään junia.";
        }
    } 
}