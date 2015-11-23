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
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(12, 27);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(292, 459);
      this.listBox1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(897, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
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
      this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.placeholderToolStripMenuItem.Text = "[Placeholder]";
      // 
      // sourceToolStripMenuItem
      // 
      this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
      this.sourceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.sourceToolStripMenuItem.Text = "Source";
      this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(897, 528);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "CTA Data Analysis";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
  }
}

