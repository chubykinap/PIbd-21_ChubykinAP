using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form : System.Windows.Forms.Form
	{
		Color color;
		Color dopColor;
		Color colorDop;
		int maxSpeed;
		int maxCrew;
		int displacement;

		private ITechnika inter;

		public Form()
		{
			InitializeComponent();
			color = Color.Gray;
			colorDop = Color.DarkGray;
			dopColor = Color.Gray;
			maxSpeed = 30;
			maxCrew = 300;
			displacement = 9000;
			button3.BackColor = color;
			button4.BackColor = dopColor;
			speed.Text = Convert.ToString(maxSpeed);
			disp.Text = Convert.ToString(displacement);
			crew.Text = Convert.ToString(maxCrew);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			inter = new Ship(maxSpeed, maxCrew, displacement, color, colorDop);
			Bitmap bmp = new Bitmap(picture.Width, picture.Height);
			Graphics gr = Graphics.FromImage(bmp);
			inter.drawSudno(gr);
			picture.Image = bmp;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (checkFields())
			{
				inter = new Cruiser(maxSpeed, maxCrew, displacement, color, box1.Checked, box2.Checked, dopColor, colorDop);
				Bitmap bmp = new Bitmap(picture.Width, picture.Height);
				Graphics gr = Graphics.FromImage(bmp);
				inter.drawSudno(gr);
				picture.Image = bmp;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				color = cd.Color;
				button3.BackColor = color;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				dopColor = cd.Color;
				button4.BackColor = dopColor;
			}
		}

		private bool checkFields()
		{
			if (!int.TryParse(speed.Text, out maxSpeed))
			{
				return false;
			}
			if (!int.TryParse(disp.Text, out displacement))
			{
				return false;
			}
			if (!int.TryParse(crew.Text, out maxCrew))
			{
				return false;
			}
			return true;
		}

		private void move_Click(object sender, EventArgs e)
		{
			if (inter != null)
			{
				Bitmap bmp = new Bitmap(picture.Width, picture.Height);
				Graphics gr = Graphics.FromImage(bmp);
				inter.moveSudno(gr);
				picture.Image = bmp;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				colorDop = cd.Color;
				button5.BackColor = colorDop;
			}
		}
	}
}