
using System;
using System.Collections.Generic;


namespace BusinessTier
{

  public class Line
  {
    public readonly int line_id;
    public readonly string color;
    //public readonly StopDetial stops;

    public Line(int line_id, string color)
    {
      this.line_id = line_id;
      this.color = color;
    }

  }

  public class Ridership
  {
    public readonly int rider_id;
    public readonly int station_id;
    public readonly int current_date;  //Maybe change this data type to parse it easier 
    public readonly int daily_total;
    public readonly string type_of_day;

    public Ridership(int rider_id, int station_id, int current_date, int daily_total, string type_of_day)
    {
      this.rider_id = rider_id;
      this.station_id = station_id;
      this.current_date = current_date;
      this.daily_total = daily_total;
      this.type_of_day = type_of_day;

    }
  }


  public class Station
  {
    public readonly int station_id;
    public readonly int line_id;
    public readonly Ridership riders;
    //List of Stops

    public Station(int station_id, int line_id, Ridership riders)
    {
      this.station_id = station_id;
      this.line_id = line_id;
      this.riders = riders;
    }
  }

  public class Stop
  {
    public readonly int stop_id;
    public readonly int station_id;
    public readonly string name;
    public readonly string direction;
    public readonly int latitude;
    public readonly int longitude;
    //public readonly StopDetail stops;

    public Stop(int stop_id, int station_id, string name, string direction, int latitude, int longitude)
    {
      this.stop_id = stop_id;
      this.station_id = station_id;
      this.name = name;
      this.direction = direction;
      this.latitude = latitude;
      this.longitude = longitude;
    }
  }
  //testss

  public class StopDetail
  {
    public readonly int stop_id;
    public readonly int line_id;

    public StopDetail(int stop_id, int line_id)
    {
      this.stop_id = stop_id;
      this.line_id = line_id;
      //test
    }
  }

}
