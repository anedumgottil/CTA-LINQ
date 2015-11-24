//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTAData;

namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private CTADataContext db = new CTADataContext();
  

    //
    // Constructor:
    //
    public Business()
    {
     
    }

    public List<Line> GetallLines()
    {
      var data = new List<Line>();
      var q = from m in db.Lines
              orderby m.LineID
              select m;

      foreach (var x in q)
      {
        var l = new Line(x.LineID, x.Color);
        data.Add(l);
      }
      return data;
    }

    public List<Ridership> GetallRiders()
    {
      var data = new List<Ridership>();
      var q = from m in db.Riderships
              orderby m.RiderID
              select m;

      foreach (var x in q)
      {
        var rider = new Ridership(x.RiderID, x.StationID, x.TheDate, x.DailyTotal, x.TypeOfDay);
        data.Add(rider);
      }
      return data;
    }

    public List<Station> GetallStations()
    {
      var data = new List<Station>();
      var q = from m in db.Stations
              orderby m.StationID
              select m;

      foreach (var x in q)
      {
        var location = new Station(x.StationID, x.Name);
        data.Add(location);
      }
      return data;
    }

    public List<StopDetail> GetallStopDetail()
    {
      var data = new List<StopDetail>();
      var q = from m in db.StopDetails
              orderby m.StopID
              select m;

      foreach (var x in q)
      {
        var stop_info = new StopDetail(x.StopID, x.LineID);
        data.Add(stop_info);
      }
      return data;
    }


    public List<Stop> GetallStop()
    {
      var data = new List<Stop>();
      var q = from m in db.Stops
              orderby m.StopID
              select m;

      foreach (var x in q)
      {

        var stop_info = new Stop(x.StopID, x.StationID, x.Name, x.Direction,x.ADA, x.Latitude, x.Longitude);
        data.Add(stop_info);
      }
      return data;
    }


    

    

  }//class
}//namespace
