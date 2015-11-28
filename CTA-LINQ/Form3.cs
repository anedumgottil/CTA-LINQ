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
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
      CTALogoBox.ImageLocation = @"CTA-Logo.png";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.listBox2.Items.Clear();
      BusinessTier.Business bt = new BusinessTier.Business();


      var date = this.dateTimePicker1.Value;
      var info = bt.GetOneInfo(date);
      var min = info.First();
      var max = info.Last();
      foreach (var x in info)
      {
        this.listBox2.Items.Add(x);
      }
      this.label2.Text = String.Format("Max:{0} ",max);
      this.label3.Text = String.Format("Min:{0} ",min);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.label2.Text = "Max: ";
      this.label3.Text = "Min: ";
      this.listBox2.Items.Clear();
      BusinessTier.Business bt = new BusinessTier.Business();
      var name = this.listBox1.Text;
      var date = this.dateTimePicker1.Value;
      var data = bt.GetStation(name,date);

      if (data != null)
      {
        this.listBox2.Items.Add(String.Format("StationID:{0}  \t Total:{1} \t Type of Date:{2}", data.station_id, data.daily_total, data.type_of_day));

      }
  
    }

    private void CTALogoBox_Click(object sender, EventArgs e)
    {

    }
  }
}
