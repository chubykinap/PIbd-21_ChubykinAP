using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Port<T>
	{
		private T[] places;
		private int GetCountPlaces { get { return places.Length; } }
		private T defValue;

		private bool CheckFreePlaces(int index)
		{
			if (index < 0 || index > places.Length)
			{
				return false;
			}
			if (places[index] == null)
			{
				return true;
			}
			return false;
		}

		private void AddShip(int index, T ship)
		{
			places[index] = ship;
		}

		private T GetShip(int index)
		{
			T ship = places[index];
			places[index] = defValue;
			return ship;
		}

		public static int operator +(Port<T> p, T ship)
		{
			for (int i = 0; i < p.GetCountPlaces; i++)
			{
				if (p.CheckFreePlaces(i))
				{
					p.AddShip(i, ship);
					return i;
				}
			}
			return -1;
		}

		public static T operator -(Port<T> p, int index)
		{
			if (!p.CheckFreePlaces(index))
			{
				return p.GetShip(index);
			}
			return p.defValue;
		}

		public Port(int size, T defVal)
		{
			defValue = defVal;
			places = new T[size];
			for (int i = 0; i < places.Length; i++)
			{
				places[i] = defValue;
			}
		}

		public void Draw(Graphics g, int width, int height)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, width, height);
			int shipCount = 0;
			for (int i = 0, chet = 0; i < width; chet++)
			{
				for (int j = 0; (j + 1) * 80 < height; ++j)
				{
					if (shipCount < places.Length)
					{
						if (places[shipCount] != null)
						{
							if (places[shipCount] is ITechnika)
							{
								(places[shipCount] as ITechnika).setPos(i + 15, j * 80 + 15);
								(places[shipCount] as ITechnika).drawSudno(g);
							}
						}
						shipCount++;
					}
					g.DrawLine(pen, i, j * 80 + 70, i + 130, j * 80 + 70);
				}
				if (chet % 2 == 0)
				{
					i += 180;
				}
				else
				{
					g.DrawLine(pen, i + 140, 5, i + 140, height - 5);
					i += 145;
				}
			}
		}
	}
}
