using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Contains get and set methods for Stations and Trains for TrainApp
/// </summary>
namespace TrainApp
{
    public class Stations
    {
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
    }

    public class Trains
    {
        public string trainNumber { get; set; }
        public string cancelled { get; set; }
        public string departureDate { get; set; }
    }
}