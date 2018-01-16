using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
	public partial class Form1 : Form
	{
		Parking parking;
		Form2 form = new Form2();

		public Form1()
		{
			InitializeComponent();
			parking = new Parking(5);
			for (int i = 1; i < 6; i++)
			{
				listBox1.Items.Add("Порт №" + i);
			}
			listBox1.SelectedIndex = parking.getLVL;
			DrawPort();
		}

		private void DrawPort()
		{
			if (listBox1.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(picture.Width, picture.Height);
				Graphics g = Graphics.FromImage(bmp);
				parking.Draw(g);
				picture.Image = bmp;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (maskedTextBox1.Text != "")
			{
				ITechnika ship = parking.GetInParking(Convert.ToInt32(maskedTextBox1.Text) - 1);
				if (ship != null)
				{
					Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
					Graphics gr = Graphics.FromImage(bmp);
					ship.setPos(15, 10);
					ship.drawSudno(gr);
					pictureTake.Image = bmp;
					DrawPort();
				}
				else
				{
					MessageBox.Show("Здесь пусто");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			parking.LevelUp();
			listBox1.SelectedIndex = parking.getLVL;
			DrawPort();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			parking.LevelDown();
			listBox1.SelectedIndex = parking.getLVL;
			DrawPort();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			form = new Form2();
			form.AddEvent(AddShip);
			form.Show();
		}

		private void AddShip(ITechnika ship)
		{
			if (ship != null)
			{
				int place = parking.PutInParking(ship);
				if (place > -1)
				{
					DrawPort();
					MessageBox.Show("Вашеместо: " + (place + 1));
				}
				else
				{
					MessageBox.Show("Не удалось поставить.");
				}
			}
		}
	}
}
