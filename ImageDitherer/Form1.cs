using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDitherer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			trackBar1.Value = trackBar1.Maximum;
			label2.Text = trackBar1.Value.ToString();
		}


		private void DitheredPicture_Click(object sender, EventArgs e)
		{
						
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OriginalPicture.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		float Constrain(float low, float value, float high)
		{
			return (value < low ? low :
					value > high ? high :
					value);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Bitmap originalPicture = new Bitmap(OriginalPicture.Image);
			Bitmap newPicture = new Bitmap(OriginalPicture.Image);
			DitheredPicture.Image = newPicture;
			for (int y = 0; y < OriginalPicture.Height - 1; y++)
			{
				for (int x = 1; x < OriginalPicture.Width - 1; x++)
				{
					if (checkBox1.Checked)
					{
						Color p = originalPicture.GetPixel(x, y);
						//extract pixel component ARGB
						int greya = p.A;
						int greyr = p.R;
						int greyg = p.G;
						int greyb = p.B;

						//find average
						int avg = (greyr + greyg + greyb) / 3;

						//set new pixel value
						originalPicture.SetPixel(x, y, Color.FromArgb(greya, avg, avg, avg));
					}

					Color colour = originalPicture.GetPixel(x, y);
					float oldR = colour.R;
					float oldG = colour.G;
					float oldB = colour.B;

					int factorOfColours = trackBar1.Value;

					int newR = (int)Math.Round(factorOfColours * (double)oldR / 255) * (255 / factorOfColours);
					int newG = (int)Math.Round(factorOfColours * (double)oldG / 255) * (255 / factorOfColours);
					int newB = (int)Math.Round(factorOfColours * (double)oldB / 255) * (255 / factorOfColours);


					newPicture.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
					DitheredPicture.Image = newPicture;
					if((x + y) % 80 == 0)
					{
						DitheredPicture.Refresh();
					}

					float errR = oldR - newR;
					float errG = oldG - newG;
					float errB = oldB - newB;

					Color c = originalPicture.GetPixel(x + 1, y);
					float r = c.R;
					float g = c.G;
					float b = c.B;
					r = r + errR * 7f / 16f;
					g = g + errG * 7f / 16f;
					b = b + errB * 7f / 16f;
					r = Constrain(0, r, 255);
					g = Constrain(0, g, 255);
					b = Constrain(0, b, 255);


					originalPicture.SetPixel(x + 1, y, Color.FromArgb((int)r, (int)g, (int)b));

					c = originalPicture.GetPixel(x - 1, y + 1);
					r = c.R;
					g = c.G;
					b = c.B;
					r = r + errR * 3f / 16f;
					g = g + errG * 3f / 16f;
					b = b + errB * 3f / 16f;
					r = Constrain(0, r, 255);
					g = Constrain(0, g, 255);
					b = Constrain(0, b, 255);


					originalPicture.SetPixel(x - 1, y + 1, Color.FromArgb((int)r, (int)g, (int)b));

					c = originalPicture.GetPixel(x, y + 1);
					r = c.R;
					g = c.G;
					b = c.B;
					r = r + errR * 5f / 16f;
					g = g + errG * 5f / 16f;
					b = b + errB * 5f / 16f;
					r = Constrain(0, r, 255);
					g = Constrain(0, g, 255);
					b = Constrain(0, b, 255);


					originalPicture.SetPixel(x, y + 1, Color.FromArgb((int)r, (int)g, (int)b));

					originalPicture.SetPixel(x - 1, y + 1, Color.FromArgb((int)r, (int)g, (int)b));

					c = originalPicture.GetPixel(x + 1, y + 1);
					r = c.R;
					g = c.G;
					b = c.B;
					r = r + errR * 1f / 16f;
					g = g + errG * 1f / 16f;
					b = b + errB * 1f / 16f;
					r = Constrain(0, r, 255);
					g = Constrain(0, g, 255);
					b = Constrain(0, b, 255);

					originalPicture.SetPixel(x + 1, y + 1, Color.FromArgb((int)r, (int)g, (int)b));
				}
			}

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label2.Text = trackBar1.Value.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			
		}
	}
}
