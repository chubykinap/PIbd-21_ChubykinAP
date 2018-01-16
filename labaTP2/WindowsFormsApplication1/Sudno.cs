using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
	public abstract class Sudno : ITechnika
	{
		protected float startPosX;
		protected float startPosY;
		protected int CrewCount;
		public virtual int maxCrew { protected set; get; }
		public virtual int maxSpeed { protected set; get; }
		public Color ColorBody1 { protected set; get; }
		public Color ColorBody2 { protected set; get; }
		public virtual double displacement { protected set; get; }
		public abstract void moveSudno(Graphics g);
		public abstract void drawSudno(Graphics g);

		public virtual void setPos(int x, int y)
		{
			startPosX = x;
			startPosY = y;
		}

		public void loadCrew(int count)
		{
			if (CrewCount + count < maxCrew)
			{
				CrewCount += count;
			}
		}

		public int getCrew()
		{
			int count = CrewCount;
			CrewCount = 0;
			return count;
		}

		public virtual void setMainColor(Color color)
		{
			ColorBody1 = color;
			ColorBody2 = color;
		}
	}
}
