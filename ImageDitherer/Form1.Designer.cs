namespace ImageDitherer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.OriginalPicture = new System.Windows.Forms.PictureBox();
			this.DitheredPicture = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DitheredPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// OriginalPicture
			// 
			this.OriginalPicture.Image = ((System.Drawing.Image)(resources.GetObject("OriginalPicture.Image")));
			this.OriginalPicture.Location = new System.Drawing.Point(12, 12);
			this.OriginalPicture.MaximumSize = new System.Drawing.Size(512, 512);
			this.OriginalPicture.Name = "OriginalPicture";
			this.OriginalPicture.Size = new System.Drawing.Size(512, 512);
			this.OriginalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.OriginalPicture.TabIndex = 0;
			this.OriginalPicture.TabStop = false;
			// 
			// DitheredPicture
			// 
			this.DitheredPicture.Location = new System.Drawing.Point(624, 12);
			this.DitheredPicture.MaximumSize = new System.Drawing.Size(512, 512);
			this.DitheredPicture.Name = "DitheredPicture";
			this.DitheredPicture.Size = new System.Drawing.Size(512, 512);
			this.DitheredPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.DitheredPicture.TabIndex = 1;
			this.DitheredPicture.TabStop = false;
			this.DitheredPicture.Click += new System.EventHandler(this.DitheredPicture_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(560, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "===>";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(213, 541);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "LoadNewImage";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(836, 541);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Dither";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(836, 570);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(48, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Grey";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 3;
			this.trackBar1.Location = new System.Drawing.Point(689, 588);
			this.trackBar1.Maximum = 5;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(350, 45);
			this.trackBar1.TabIndex = 6;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1059, 588);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "0";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 645);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DitheredPicture);
			this.Controls.Add(this.OriginalPicture);
			this.Name = "Form1";
			this.Text = "ImageDitherer";
			((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DitheredPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox OriginalPicture;
		private System.Windows.Forms.PictureBox DitheredPicture;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label2;
	}
}

