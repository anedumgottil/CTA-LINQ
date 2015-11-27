
//
// Needed
// Display all CTA Stations  (done)
// Total Ridership
// avg RiderShip (Daily)
// Stops at stations         (done)
// location                  (done)
// total number of stations  (done)
//


//
// Extra
// Graph daily total                                              (done)
// Avg RiderShip (monthly/yearly)
// Find Stations(by name) (maybe both)                            
// Change background color depending on statiion color
// Direction of travel compass
// Handicap blinker                                               (done)
// Info about a specific day                                      (done)
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
      Handicap.ImageLocation = @"Handicap-Dark.png";
    }
    private void displayAllStops()
    {
      listBox1.Items.Clear();

      BusinessTier.Business bt = new BusinessTier.Business();

      var data = bt.GetAllStops();

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

      var data = bt.GetAllStations();

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
      var data = temp.GetAllLines();
      
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
      if (data != null)
      {
        listBox3.Items.Add(data.ADA);
        if (data.ADA)
        {
          //Image image = Image()
          //Handicap.ImageLocation = "http://www.clker.com/cliparts/9/u/7/b/Y/V/handicap-logo-hi.png";
          Handicap.ImageLocation = @"Handicap-Light.png";
        }
        else
        {
          Handicap.ImageLocation = @"Handicap-Dark.png";
        }
        
        listBox3.Items.Add(data.direction);

        listBox3.Items.Add(data.latitude); 

        listBox3.Items.Add(data.longitude);
      }
      
      

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

      var stations = bt.GetAllStations();

      foreach (var station in stations)
      {
        frm.listBox1.Items.Add(station.name);
      }

      frm.ShowDialog();
    }

    private void Handicap_Click(object sender, EventArgs e)
    {

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Form3 frm = new Form3();

      BusinessTier.Business bt = new BusinessTier.Business();

      var stations = bt.GetAllStations();

      foreach (var station in stations)
      {
        frm.listBox1.Items.Add(station.name);
      }

      frm.ShowDialog();

    }

    private void button4_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Red");
      frm.label1.Text = "Red Line Stops";
      frm.BackColor = Color.FromName("Red");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Blue");
      frm.label1.Text = "Blue Line Stops";
      frm.BackColor = Color.FromName("Blue");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Green");
      frm.label1.Text = "Green Line Stops";
      frm.BackColor = Color.FromName("Green");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Brown");
      frm.label1.Text = "Brown Line Stops";
      frm.BackColor = Color.FromName("Brown");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Purple");
      frm.label1.Text = "Purple Line Stops";
      frm.BackColor = Color.FromName("Purple");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Purple-Express");
      frm.label1.Text = "Purple-Express Line Stops";
      frm.BackColor = Color.FromName("Purple");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button9_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Yellow");
      frm.label1.Text = "Yellow Line Stops";
      frm.BackColor = Color.FromName("Yellow");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Pink");
      frm.label1.Text = "Pink Line Stops";
      frm.BackColor = Color.FromName("Pink");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void button11_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Orange");
      frm.label1.Text = "Orange Line Stops";
      frm.BackColor = Color.FromName("Orange");
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }
  }
}
