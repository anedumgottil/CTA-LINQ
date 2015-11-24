
//
// Needed
// Display all CTA Stations
// Total Ridership
// avg RiderShip (Daily)
// Stops at stations
// location
// total number of stations
//


//
// Extra
// Graph daily total
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

      listBox1.Items.Clear();

      
    }

    private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/Anedumgottil/CTA-LINQ");

      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var temp = new BusinessTier.Business("Test");
      var data = temp.GetallLines();
      foreach (var x in data)
      {
        listBox1.Items.Add(x.line_id);
      }
    }
  }
}
