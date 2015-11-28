namespace CTA_LINQ
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.purpleExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Handicap = new System.Windows.Forms.PictureBox();
      this.CompassBox = new System.Windows.Forms.PictureBox();
      this.Lattidude = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.StationSearchBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.Longitude = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Handicap)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CompassBox)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(12, 27);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(292, 459);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.linesToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(913, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      // 
      // menuToolStripMenuItem
      // 
      this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem,
            this.sourceToolStripMenuItem});
      this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
      this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.menuToolStripMenuItem.Text = "Menu";
      // 
      // placeholderToolStripMenuItem
      // 
      this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
      this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.placeholderToolStripMenuItem.Text = "[Placeholder]";
      this.placeholderToolStripMenuItem.Click += new System.EventHandler(this.placeholderToolStripMenuItem_Click);
      // 
      // sourceToolStripMenuItem
      // 
      this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
      this.sourceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.sourceToolStripMenuItem.Text = "Source";
      this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
      // 
      // graphToolStripMenuItem
      // 
      this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.toolStripMenuItem1});
      this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
      this.graphToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.graphToolStripMenuItem.Text = "Visulaize ";
      // 
      // dailyToolStripMenuItem
      // 
      this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
      this.dailyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.dailyToolStripMenuItem.Text = "Daily Total";
      this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItem1.Text = "Daily Information";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // linesToolStripMenuItem
      // 
      this.linesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.purpleExpressToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.orangeToolStripMenuItem});
      this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
      this.linesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.linesToolStripMenuItem.Text = "Lines";
      // 
      // redToolStripMenuItem
      // 
      this.redToolStripMenuItem.Name = "redToolStripMenuItem";
      this.redToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.redToolStripMenuItem.Text = "Red";
      this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
      // 
      // blueToolStripMenuItem
      // 
      this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
      this.blueToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.blueToolStripMenuItem.Text = "Blue";
      this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
      // 
      // greenToolStripMenuItem
      // 
      this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
      this.greenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.greenToolStripMenuItem.Text = "Green";
      this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
      // 
      // brownToolStripMenuItem
      // 
      this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
      this.brownToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.brownToolStripMenuItem.Text = "Brown";
      this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
      // 
      // purpleToolStripMenuItem
      // 
      this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
      this.purpleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.purpleToolStripMenuItem.Text = "Purple";
      this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
      // 
      // purpleExpressToolStripMenuItem
      // 
      this.purpleExpressToolStripMenuItem.Name = "purpleExpressToolStripMenuItem";
      this.purpleExpressToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.purpleExpressToolStripMenuItem.Text = "Purple Express";
      this.purpleExpressToolStripMenuItem.Click += new System.EventHandler(this.purpleExpressToolStripMenuItem_Click);
      // 
      // yellowToolStripMenuItem
      // 
      this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
      this.yellowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.yellowToolStripMenuItem.Text = "Yellow";
      this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
      // 
      // pinkToolStripMenuItem
      // 
      this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
      this.pinkToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.pinkToolStripMenuItem.Text = "Pink";
      this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
      // 
      // orangeToolStripMenuItem
      // 
      this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
      this.orangeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.orangeToolStripMenuItem.Text = "Orange";
      this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(325, 27);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(291, 173);
      this.listBox2.TabIndex = 3;
      this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(82, 509);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // Handicap
      // 
      this.Handicap.Location = new System.Drawing.Point(516, 206);
      this.Handicap.Name = "Handicap";
      this.Handicap.Size = new System.Drawing.Size(100, 95);
      this.Handicap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.Handicap.TabIndex = 7;
      this.Handicap.TabStop = false;
      this.Handicap.Click += new System.EventHandler(this.Handicap_Click);
      // 
      // CompassBox
      // 
      this.CompassBox.Location = new System.Drawing.Point(325, 209);
      this.CompassBox.Name = "CompassBox";
      this.CompassBox.Size = new System.Drawing.Size(100, 92);
      this.CompassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.CompassBox.TabIndex = 18;
      this.CompassBox.TabStop = false;
      // 
      // Lattidude
      // 
      this.Lattidude.Location = new System.Drawing.Point(417, 390);
      this.Lattidude.Name = "Lattidude";
      this.Lattidude.ReadOnly = true;
      this.Lattidude.Size = new System.Drawing.Size(100, 20);
      this.Lattidude.TabIndex = 20;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(322, 338);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 18);
      this.label2.TabIndex = 21;
      this.label2.Text = "Longitude";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(322, 389);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 18);
      this.label3.TabIndex = 22;
      this.label3.Text = "Lattidude";
      // 
      // StationSearchBox
      // 
      this.StationSearchBox.Location = new System.Drawing.Point(622, 54);
      this.StationSearchBox.Name = "StationSearchBox";
      this.StationSearchBox.Size = new System.Drawing.Size(248, 20);
      this.StationSearchBox.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 508);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 13);
      this.label4.TabIndex = 24;
      this.label4.Text = "Total Stations:";
      // 
      // Longitude
      // 
      this.Longitude.Location = new System.Drawing.Point(417, 339);
      this.Longitude.Name = "Longitude";
      this.Longitude.ReadOnly = true;
      this.Longitude.Size = new System.Drawing.Size(100, 20);
      this.Longitude.TabIndex = 19;
      // 
      // toolTip1
      // 
      this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 539);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.StationSearchBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Lattidude);
      this.Controls.Add(this.Longitude);
      this.Controls.Add(this.CompassBox);
      this.Controls.Add(this.Handicap);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "CTA Data Analysis";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Handicap)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CompassBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
    private System.Windows.Forms.PictureBox Handicap;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.PictureBox CompassBox;
    private System.Windows.Forms.TextBox Lattidude;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem purpleExpressToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
    private System.Windows.Forms.TextBox StationSearchBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox Longitude;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

