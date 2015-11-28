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

    public List<Line> GetAllLines()
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



    public List<Ridership> GetAllRiders()
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
    public List<Ridership> GetRiders(string name)
    {
      var data = new List<Ridership>();
      var q = from station in db.Stations
              where station.Name == name
              join rider in db.Riderships on station.StationID equals rider.StationID into stationgroup
              from info in stationgroup
              orderby info.TheDate
              select info;



      foreach (var x in q)
      {
        var rider = new Ridership(x.RiderID, x.StationID, x.TheDate, x.DailyTotal, x.TypeOfDay);
        data.Add(rider);
      }
      return data;
    }
    public List<Station> GetAllStations()
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

    public Ridership GetStation(string name , DateTime date)
    {
      var q = from station in db.Stations
              where station.Name == name 
              join rider in db.Riderships on station.StationID equals rider.StationID into stationgroup
              from info in stationgroup
              where info.TheDate == date
              orderby info.DailyTotal
              select info;


      foreach(var x in q){
        var oneStation = new Ridership(x.RiderID, x.StationID, x.TheDate, x.DailyTotal, x.TypeOfDay);
        return oneStation;
      }
      return null;
    }

    public List<StopDetail> GetAllStopDetails()
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


    public List<Stop> GetAllStops()
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

    public List<Stop> GetStops(string station_name)
    {
      var data =  new List<Stop>();
      var q = from station in db.Stations
              join stop in db.Stops on station.StationID equals stop.StationID into stopgroup
              from station2 in stopgroup
              where station.Name == station_name
              select station2;
      foreach (var x in q)
      {
        var stop_info = new Stop(x.StopID, x.StationID, x.Name, x.Direction, x.ADA, x.Latitude, x.Longitude);
        data.Add(stop_info);
      }
      return data;
    }

    public List<Stop> GetColorStops(string color)
    {
      var data = new List<Stop>();
      var q = from line in db.Lines
              where line.Color == color
              join stops in db.StopDetails on line.LineID equals stops.LineID into stopGroup
              from info in stopGroup
              join names in db.Stops on info.StopID equals names.StopID into grp
              from info2 in grp
              select info2;
   
      foreach (var x in q)
      {
        var stop_info = new Stop(x.StopID, x.StationID, x.Name, x.Direction, x.ADA, x.Latitude, x.Longitude);
        data.Add(stop_info);
      }
      return data;
    }

    public List<Stop> GetStops(int StationID)
    {
      var data = new List<Stop>();
      var q = from stop in db.Stops
              where stop.StationID == StationID
              select stop;

      foreach (var x in q)
      {
        var stop_info = new Stop(x.StopID, x.StationID, x.Name, x.Direction, x.ADA, x.Latitude, x.Longitude);
        data.Add(stop_info);
      }
      return data;
    }

    public Stop GetSingleStop(string stationName, string stop_name)
    {
      var q = from station in db.Stations
              join stops in db.Stops on station.StationID equals stops.StationID into stopgroup
              from stop in stopgroup
              where stop.Name == stop_name && station.Name == stationName
              select stop;

      foreach (var x in q)
      {
        var stop_info = new Stop(x.StopID, x.StationID, x.Name, x.Direction, x.ADA, x.Latitude, x.Longitude);
        return stop_info;
      }
      return null;
    }
    public Line GetLineFromStop(Stop s)
    {
      Line line = null;

      var q = from stop_detail in db.StopDetails
              join selected_line in db.Lines on stop_detail.LineID equals selected_line.LineID into line_group
              from new_line in line_group
              where stop_detail.StopID == s.stop_id
              select new_line;
      
      foreach (var x in q)
      {
        line = new Line(x.LineID,x.Color);
      }
      return line;
    }
    public Line GetLine(int line_id)
    {
      Line line = null;
      var data = from selected_line in db.Lines
                 where selected_line.LineID == line_id
                 select line;

      foreach (var x in data)
      {
        line = new Line(x.line_id, x.color);
      }
      return line;
    }
    public List<string> GetOneInfo(DateTime date)
    {
      var info = from rider in db.Riderships
                 where rider.TheDate == date
                 join name in db.Stations on rider.StationID equals name.StationID into infogroup
                 from station in infogroup 
                 select new  { stationName = station.Name,
                              total = rider.DailyTotal,
                 };

      var infolist = new List<string>();
      foreach (var x in info)
      {
        infolist.Add(string.Format("{0}:{1}",x.stationName,x.total));
      }
      return infolist;
    }
    

    

  }//class
}//namespace
