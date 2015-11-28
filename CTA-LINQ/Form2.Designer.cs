namespace CTA_LINQ
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(281, 40);
      this.chart1.Name = "chart1";
      this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
      series1.ChartArea = "ChartArea1";
      series1.IsVisibleInLegend = false;
      series1.Legend = "Legend1";
      series1.Name = "Test";
      series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(573, 363);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(12, 40);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 1;
      // 
      // dateTimePicker2
      // 
      this.dateTimePicker2.Location = new System.Drawing.Point(12, 91);
      this.dateTimePicker2.Name = "dateTimePicker2";
      this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker2.TabIndex = 2;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(12, 134);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(200, 264);
      this.listBox1.TabIndex = 3;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(57, 404);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(98, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Graph Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(920, 458);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.dateTimePicker2);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.chart1);
      this.Name = "Form2";
      this.Text = "Daily Total";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    public System.Windows.Forms.DateTimePicker dateTimePicker1;
    public System.Windows.Forms.DateTimePicker dateTimePicker2;
    public System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;
  }
}