
//
// Needed
// Display all CTA Stations  (done)
// Total Ridership
// avg RiderShip (Daily)
// Stops at stations         (done)
// location                  (done)??
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
// list of one line (color buttons)                               (done)
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

      var station = this.listBox1.Text;

      var stop = this.listBox2.Text;

      BusinessTier.Business bt = new BusinessTier.Business();

      
      var data = bt.GetSingleStop(station, stop);
     
      if (data != null)
      {
        var line = bt.GetLineFromStop(data);
        updateBackgroundColor(line.color);
        if (data.ADA)
        {
          Handicap.ImageLocation = @"Handicap-Light.png";
        }
        else
        {
          Handicap.ImageLocation = @"Handicap-Dark.png";
        }
 
       
        updateDirection(data.direction);
        
        Longitude.Text = Convert.ToString(data.longitude);
        Lattidude.Text = Convert.ToString(data.latitude);
     
      }

    }
    private void updateDirection(String direction)
    {
      if (direction.Equals("S"))
      {
        CompassBox.ImageLocation = @"Compass-South.png";
      }else if(direction.Equals("N"))
      {
        CompassBox.ImageLocation = @"Compass-North.png";
      }else if(direction.Equals("E"))
      {
        CompassBox.ImageLocation = @"Compass-East.png";
      }else if(direction.Equals("W"))
      {
        CompassBox.ImageLocation = @"Compass-West.png";
      }
    }

    private void updateBackgroundColor(String color)
    {
      if (color.Equals("Red"))
      {
        this.BackColor = System.Drawing.Color.Red;
      }
      else if (color.Equals("Blue"))
      {
        this.BackColor = System.Drawing.Color.SkyBlue;
      }
      else if (color.Equals("Green"))
      {
        this.BackColor = System.Drawing.Color.Green;
      }
      else if (color.Equals("Brown"))
      {
        this.BackColor = System.Drawing.Color.Chocolate;
      }
      else if (color.Equals("Purple") || color.Equals("Purple-Express"))
      {
        this.BackColor = System.Drawing.Color.Purple;
      }
      else if (color.Equals("Pink"))
      {
        this.BackColor = System.Drawing.Color.Pink;
      }
      else if (color.Equals("Yellow"))
      {
        this.BackColor = System.Drawing.Color.Yellow;
      }
      else if (color.Equals("Orange"))
      {
        this.BackColor = System.Drawing.Color.Coral;
      }
      else
      {
        this.BackColor = System.Drawing.Color.Gray;
      }
      
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

  
    

    private void redToolStripMenuItem_Click(object sender, EventArgs e)
    {

      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Red");
      frm.label1.Text = "Red Line Stops";
      frm.BackColor = System.Drawing.Color.Red;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void blueToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Blue");
      frm.label1.Text = "Blue Line Stops";
      frm.BackColor = System.Drawing.Color.LightBlue;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void greenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Green");
      frm.label1.Text = "Green Line Stops";
      frm.BackColor = System.Drawing.Color.Green;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void brownToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Brown");
      frm.label1.Text = "Brown Line Stops";
      frm.BackColor = System.Drawing.Color.Chocolate;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Purple");
      frm.label1.Text = "Purple Line Stops";
      frm.BackColor = System.Drawing.Color.Purple;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void purpleExpressToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Purple-Express");
      frm.label1.Text = "Purple-Express Line Stops";
      frm.BackColor = System.Drawing.Color.Purple;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Yellow");
      frm.label1.Text = "Yellow Line Stops";
      frm.BackColor = System.Drawing.Color.Yellow;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Pink");
      frm.label1.Text = "Pink Line Stops";
      frm.BackColor = System.Drawing.Color.Pink;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 frm = new Form4();

      BusinessTier.Business bt = new BusinessTier.Business();
      var data = bt.GetColorStops("Orange");
      frm.label1.Text = "Orange Line Stops";
      frm.BackColor = System.Drawing.Color.Coral;
      foreach (var x in data)
      {
        frm.listBox1.Items.Add(x.name);
      }
      frm.ShowDialog();
    }

    private void placeholderToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolTip1_Popup(object sender, PopupEventArgs e)
    {
      
    }
  }
}
