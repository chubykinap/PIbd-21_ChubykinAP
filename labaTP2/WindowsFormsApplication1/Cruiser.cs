using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
	class Cruiser : Ship
	{
		private bool frontCannon;
		private bool backCannon;
		private Color dopColor;
		private Color dopColor1;

		public Cruiser(int maxSpeed, int maxCrew, double displacement, Color mainC, bool frontCannon, bool backCannon, Color secondC) : base(maxSpeed, maxCrew, displacement, mainC)
		{
			this.frontCannon = frontCannon;
			this.backCannon = backCannon;
			this.dopColor = secondC;
		}

        public Cruiser(string info) : base(info)
        {
            string[] str = info.Split(';');
            if (str.Length == 7)
            {
                maxSpeed = Convert.ToInt32(str[0]);
                maxCrew = Convert.ToInt32(str[1]);
                displacement = Convert.ToInt32(str[2]);
                ColorBody1 = Color.FromName(str[3]);
                ColorBody2 = ColorBody1;
                frontCannon = Convert.ToBoolean(str[4]);
                backCannon = Convert.ToBoolean(str[5]);
                dopColor = Color.FromName(str[6]);
            }
        }


        protected override void drawNormalSudno(Graphics g)
		{
			base.drawNormalSudno(g);
			if (frontCannon)
			{
				Pen pen = new Pen(Color.Black);
				Brush grayB = new SolidBrush(dopColor);

				g.FillRectangle(grayB, startPosX + 80, startPosY + 10, 20, 20);
				g.DrawRectangle(pen, startPosX + 80, startPosY + 10, 20, 20);
				g.DrawRectangle(pen, startPosX + 90, startPosY + 15, 10, 10);
				g.FillRectangle(grayB, startPosX + 92, startPosY + 17, 25, 6);
				g.DrawRectangle(pen, startPosX + 92, startPosY + 17, 25, 6);
			}
			if (backCannon)
			{
				Pen pen = new Pen(Color.Black);
				Brush grayB = new SolidBrush(dopColor);

				g.FillEllipse(grayB, startPosX - 5, startPosY + 10, 20, 20);
				g.DrawEllipse(pen, startPosX - 5, startPosY + 10, 20, 20);
				g.DrawLine(pen, startPosX + 5, startPosY + 15, startPosX - 7, startPosY + 15);
				g.DrawLine(pen, startPosX + 5, startPosY + 25, startPosX - 7, startPosY + 25);
			}
		}

		public void setDopColor(Color color)
		{
			dopColor = color;
        }

        public override string getInfo()
        {
            return maxSpeed + ";" + maxCrew + ";" + displacement + ";" + ColorBody1.Name + ";"  + frontCannon + ";" + backCannon + ";" + dopColor.Name;
        }
    }
}
