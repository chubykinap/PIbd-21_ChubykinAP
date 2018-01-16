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
		Port<ITechnika> port;

		public Form()
		{
			InitializeComponent();
			port = new Port<ITechnika>(25, null);
			DrawPort();
		}

		private void DrawPort()
		{
			Bitmap bmp = new Bitmap(picture.Width, picture.Height);
			Graphics gr = Graphics.FromImage(bmp);
			port.Draw(gr, picture.Width, picture.Height);
			picture.Image = bmp;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var ship = new Ship(30, 300, 9000, dialog.Color, dialogDop.Color);
					int place = port + ship;
					DrawPort();
					MessageBox.Show("Вашеместо: " + place);
				}
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					ColorDialog dialogDopp = new ColorDialog();
					if (dialogDopp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						var ship = new Cruiser(30, 300, 9000, dialog.Color, true, true, dialogDop.Color, dialogDopp.Color);
						int place = port + ship;
						DrawPort();
						MessageBox.Show("Вашеместо: " + place);
					}
				}

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (maskedTextBox1.Text != "")
			{
				ITechnika ship = port - Convert.ToInt32(maskedTextBox1.Text);
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

		private void groupBox1_Enter(object sender, EventArgs e)
		{ }
	}
}