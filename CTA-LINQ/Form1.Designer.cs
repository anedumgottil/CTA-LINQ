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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.button1 = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.listBox3 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.Handicap = new System.Windows.Forms.PictureBox();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.button11 = new System.Windows.Forms.Button();
      this.CompassBox = new System.Windows.Forms.PictureBox();
      this.Longitude = new System.Windows.Forms.TextBox();
      this.Lattidude = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
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
            this.graphToolStripMenuItem});
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
      this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.graphToolStripMenuItem.Text = "Graph";
      // 
      // dailyToolStripMenuItem
      // 
      this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
      this.dailyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.dailyToolStripMenuItem.Text = "Daily Total";
      this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
      this.toolStripMenuItem1.Text = "One Day Information";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(634, 47);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
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
      // listBox3
      // 
      this.listBox3.FormattingEnabled = true;
      this.listBox3.Location = new System.Drawing.Point(736, 313);
      this.listBox3.Name = "listBox3";
      this.listBox3.Size = new System.Drawing.Size(165, 173);
      this.listBox3.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 506);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(634, 463);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Nothing?";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
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
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Red;
      this.button4.Cursor = System.Windows.Forms.Cursors.Default;
      this.button4.Location = new System.Drawing.Point(100, 506);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(48, 23);
      this.button4.TabIndex = 9;
      this.button4.Text = "RED";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Blue;
      this.button3.Cursor = System.Windows.Forms.Cursors.Default;
      this.button3.Location = new System.Drawing.Point(170, 506);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(36, 23);
      this.button3.TabIndex = 10;
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Green;
      this.button5.Cursor = System.Windows.Forms.Cursors.Default;
      this.button5.Location = new System.Drawing.Point(212, 506);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(36, 23);
      this.button5.TabIndex = 11;
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Brown;
      this.button6.Cursor = System.Windows.Forms.Cursors.Default;
      this.button6.Location = new System.Drawing.Point(254, 506);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(36, 23);
      this.button6.TabIndex = 12;
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Purple;
      this.button7.Cursor = System.Windows.Forms.Cursors.Default;
      this.button7.Location = new System.Drawing.Point(309, 506);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(36, 23);
      this.button7.TabIndex = 13;
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.Purple;
      this.button8.Cursor = System.Windows.Forms.Cursors.Default;
      this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.button8.Location = new System.Drawing.Point(370, 506);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(60, 23);
      this.button8.TabIndex = 14;
      this.button8.Text = "Express";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button9
      // 
      this.button9.BackColor = System.Drawing.Color.Yellow;
      this.button9.Cursor = System.Windows.Forms.Cursors.Default;
      this.button9.Location = new System.Drawing.Point(436, 506);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(36, 23);
      this.button9.TabIndex = 15;
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button10
      // 
      this.button10.BackColor = System.Drawing.Color.Pink;
      this.button10.Cursor = System.Windows.Forms.Cursors.Default;
      this.button10.Location = new System.Drawing.Point(491, 506);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(36, 23);
      this.button10.TabIndex = 16;
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new System.EventHandler(this.button10_Click);
      // 
      // button11
      // 
      this.button11.BackColor = System.Drawing.Color.Orange;
      this.button11.Cursor = System.Windows.Forms.Cursors.Default;
      this.button11.Location = new System.Drawing.Point(533, 506);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(36, 23);
      this.button11.TabIndex = 17;
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new System.EventHandler(this.button11_Click);
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
      // Longitude
      // 
      this.Longitude.Location = new System.Drawing.Point(417, 339);
      this.Longitude.Name = "Longitude";
      this.Longitude.ReadOnly = true;
      this.Longitude.Size = new System.Drawing.Size(100, 20);
      this.Longitude.TabIndex = 19;
      // 
      // Lattidude
      // 
      this.Lattidude.Location = new System.Drawing.Point(417, 394);
      this.Lattidude.Name = "Lattidude";
      this.Lattidude.ReadOnly = true;
      this.Lattidude.Size = new System.Drawing.Size(100, 20);
      this.Lattidude.TabIndex = 20;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(322, 346);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 21;
      this.label2.Text = "Longitude";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(322, 401);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "Lattidude";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 539);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Lattidude);
      this.Controls.Add(this.Longitude);
      this.Controls.Add(this.CompassBox);
      this.Controls.Add(this.button11);
      this.Controls.Add(this.button10);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.Handicap);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox3);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.button1);
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
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.ListBox listBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
    private System.Windows.Forms.PictureBox Handicap;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.PictureBox CompassBox;
    private System.Windows.Forms.TextBox Longitude;
    private System.Windows.Forms.TextBox Lattidude;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

