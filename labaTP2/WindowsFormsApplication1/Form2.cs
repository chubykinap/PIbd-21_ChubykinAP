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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			panel2.MouseDown += panelColor_MouseDown;
			panel3.MouseDown += panelColor_MouseDown;
			panel4.MouseDown += panelColor_MouseDown;
			panel5.MouseDown += panelColor_MouseDown;
			panel6.MouseDown += panelColor_MouseDown;
			panel7.MouseDown += panelColor_MouseDown;
			panel8.MouseDown += panelColor_MouseDown;
			panel9.MouseDown += panelColor_MouseDown;

			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		ITechnika ship = null;

		public ITechnika getShip { get { return ship; } }

		private void Drawship()
		{
			if (ship != null)
			{
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				ship.setPos(20, 10);
				ship.drawSudno(gr);
				pictureBox1.Image = bmp;
			}
		}

		private event Del eventAddship;

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelCruiser_MouseDown(object sender, MouseEventArgs e)
		{
			labelCruiser.DoDragDrop(labelCruiser.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panel1_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Ship":
					ship = new Ship(100, 4, 500, Color.White);
					break;
				case "Cruiser":
					ship = new Cruiser(100, 4, 500, Color.White, true, true, Color.Black);
					break;
			}
			Drawship();
		}

		private void panel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (ship != null)
			{
				ship.setMainColor((Color)e.Data.GetData(typeof(Color)));
				Drawship();
			}
		}

		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor,
			  DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (ship != null)
			{
				if (ship is Cruiser)
				{
					(ship as Cruiser).setDopColor((Color)e.Data.GetData(typeof(Color)));
					Drawship();
				}
			}
		}

		public void AddEvent(Del ev)
		{
			if (eventAddship == null)
			{
				eventAddship = new Del(ev);
			}
			else
			{
				eventAddship += ev;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{			
			if (eventAddship != null)
			{
				eventAddship(ship);
			}
			Close();
		}
	}
}
