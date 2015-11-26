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
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      BusinessTier.Business bt = new BusinessTier.Business();
      var name = listBox1.Text;
      var stationInfo = bt.GetRiders(name);
      var minDate = stationInfo[0].current_date;
      var maxDate = stationInfo[(stationInfo.Count) - 1].current_date;
      
      //MessageBox.Show(string.Format("{0},{1}",minDate,maxDate));

      dateTimePicker1.MaxDate = maxDate;
      dateTimePicker1.MinDate = minDate;
      dateTimePicker2.MaxDate = maxDate;
      dateTimePicker2.MinDate = minDate;
      

      dateTimePicker1.Value = minDate;
      dateTimePicker2.Value = maxDate;

      var start = dateTimePicker1.Value;
      var end = dateTimePicker2.Value;


    }

    private void button1_Click(object sender, EventArgs e)
    {
      BusinessTier.Business bt = new BusinessTier.Business();
      var name = listBox1.Text;
      var info = bt.GetRiders(name);

      var rangeData = from m in info
                      where m.current_date <= dateTimePicker2.Value && m.current_date >= dateTimePicker1.Value
                      select m;


      foreach (var x in rangeData)
      {
        this.chart1.Series["Test"].Points.AddXY(x.current_date.Day, x.daily_total);
      }
    }
  }
}
