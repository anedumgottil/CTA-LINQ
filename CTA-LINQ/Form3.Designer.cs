namespace CTA_LINQ
{
  partial class Form3
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.button1 = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.CTALogoBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.CTALogoBox)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(17, 170);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(195, 316);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(283, 448);
      this.label2.MaximumSize = new System.Drawing.Size(250, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Min:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(596, 448);
      this.label3.MaximumSize = new System.Drawing.Size(250, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "Max:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(12, 96);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 6;
      this.dateTimePicker1.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(65, 128);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "Get Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(260, 12);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(517, 433);
      this.listBox2.TabIndex = 8;
      // 
      // CTALogoBox
      // 
      this.CTALogoBox.Location = new System.Drawing.Point(55, 0);
      this.CTALogoBox.Name = "CTALogoBox";
      this.CTALogoBox.Size = new System.Drawing.Size(100, 90);
      this.CTALogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.CTALogoBox.TabIndex = 9;
      this.CTALogoBox.TabStop = false;
      this.CTALogoBox.Click += new System.EventHandler(this.CTALogoBox_Click);
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(811, 504);
      this.Controls.Add(this.CTALogoBox);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listBox1);
      this.Name = "Form3";
      this.Text = "Daily Information";
      ((System.ComponentModel.ISupportInitialize)(this.CTALogoBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Button button1;
    public System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.PictureBox CTALogoBox;
  }
}