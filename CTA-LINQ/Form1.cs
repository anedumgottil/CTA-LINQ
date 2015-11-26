
//
// Needed
// Display all CTA Stations  (done)
// Total Ridership
// avg RiderShip (Daily)
// Stops at stations         (done)
// location
// total number of stations
//


//
// Extra
// Graph daily total (done)
// Avg RiderShip (monthly/yearly)
// Find Stations(by name) (maybe both)
// Change background color depending on statiion color
// Direction of travel compass
// Handicap blinker
// Info about a specific day (graph)
// closest station
// list of one line (color buttons)
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

namespace CTA_LINQ
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
      //displayAllStops();
      displayAllStations();
    }
    private void displayAllStops()
    {
      listBox1.Items.Clear();

      BusinessTier.Business bt = new BusinessTier.Business();

      var data = bt.GetallStop();

      var ordered_data = from ordered_stop in data
                         orderby ordered_stop.name ascending
                         select ordered_stop;

      foreach (var stop in ordered_data)
      {
        listBox1.Items.Add(stop.name);
      }
      int total = data.Count();
      label1.Text = string.Format("{0}", total);
    }
    private void displayAllStations()
    {
      listBox1.Items.Clear();

      BusinessTier.Business bt = new BusinessTier.Business();

      var data = bt.GetallStations();

      var ordered_data = from ordered_stations in data
                         orderby ordered_stations.name ascending
                         select ordered_stations;

      foreach (var station in ordered_data)
      {
        listBox1.Items.Add(station.name);
      }
      int total = data.Count();
      label1.Text = string.Format("{0}",total);

    }
    private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/Anedumgottil/CTA-LINQ");

      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var temp = new BusinessTier.Business();
      var data = temp.GetallLines();
      
      foreach (var x in data)
      {
        listBox1.Items.Add(x.line_id);
      }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      listBox2.Items.Clear();


      var line = this.listBox1.Text;

      BusinessTier.Business bt = new BusinessTier.Business();
      
      var data = bt.GetStops(line);

      foreach (var stop in data)
      {
        listBox2.Items.Add(stop.name);
      }

    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      listBox3.Items.Clear();

      var line = this.listBox1.Text;

      var stop = this.listBox2.Text;

      BusinessTier.Business bt = new BusinessTier.Business();

      var data = bt.GetSingleStop(line, stop);

      listBox3.Items.Add(data.ADA);

      listBox3.Items.Add(data.direction);

      listBox3.Items.Add(data.latitude);

      listBox3.Items.Add(data.longitude);

      listBox3.Items.Add(data.name);

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 
      // Display the results in a subform:
      //
      Form2 frm = new Form2();
      
      BusinessTier.Business bt = new BusinessTier.Business();

      var stations = bt.GetallStations();

      foreach (var station in stations)
      {
        frm.listBox1.Items.Add(station.name);
      }

      frm.ShowDialog();
    }
  }
}
