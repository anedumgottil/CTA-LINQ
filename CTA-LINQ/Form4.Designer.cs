namespace CTA_LINQ
{
  partial class Form4
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
      this.label1 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.CTALineBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.CTALineBox)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(139, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(31, 99);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(400, 303);
      this.listBox1.TabIndex = 1;
      // 
      // CTALineBox
      // 
      this.CTALineBox.Location = new System.Drawing.Point(31, 10);
      this.CTALineBox.Name = "CTALineBox";
      this.CTALineBox.Size = new System.Drawing.Size(90, 83);
      this.CTALineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.CTALineBox.TabIndex = 2;
      this.CTALineBox.TabStop = false;
      this.CTALineBox.Click += new System.EventHandler(this.CTALineBox_Click);
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 437);
      this.Controls.Add(this.CTALineBox);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form4";
      this.Text = "Form4";
      ((System.ComponentModel.ISupportInitialize)(this.CTALineBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Label label1;
    public System.Windows.Forms.ListBox listBox1;
    public System.Windows.Forms.PictureBox CTALineBox;


  }
}