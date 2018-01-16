using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Ship : Sudno
    {
		protected float startPosX;
		protected float startPosY;

        public override int maxSpeed
        {
            get
            {
                return base.maxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 40)
                {
                    base.maxSpeed = value;
                }
                else
                {
                    base.maxSpeed = 20;
                }
            }
        }

        public override int maxCrew
        {
            get
            {
                return base.maxCrew;
            }

            protected set
            {
                if (value > 100 && value < 400)
                {
                    base.maxCrew = value;
                }
                else
                {
                    base.maxCrew = 300;
                }
            }
        }

        public override double displacement
        {
            get
            {
                return base.displacement;
            }

            protected set
            {
                if (value > 8000 && value < 12000)
                {
                    base.displacement = value;
                }
                else
                {
                    base.displacement = 9000;
                }
            }
        }

        public Ship(int maxSpeed, int maxCrew, double displacement, Color color1, Color color2)
        {
            this.maxSpeed = maxSpeed;
            this.maxCrew = maxCrew;
            this.ColorBody1 = color1;
            this.ColorBody2 = color2;
            this.displacement = displacement;
            this.CrewCount = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void moveSudno(Graphics g)
        {
            startPosX += (maxSpeed * 50 / ((float)displacement / 100)) / (CrewCount == 0 ? 1 : CrewCount);
            drawSudno(g);
        }

        public override void drawSudno(Graphics g)
        {
            drawNormalSudno(g);
        }

        protected virtual void drawNormalSudno(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush grayB = new SolidBrush(ColorBody1);
            Brush brownB = new SolidBrush(Color.SandyBrown);
            Brush grayDB = new SolidBrush(ColorBody2);

            g.FillRectangle(brownB, startPosX - 10, startPosY, 70, 40);
            g.DrawRectangle(pen, startPosX - 10, startPosY, 70, 40);
            g.FillEllipse(brownB, startPosX, startPosY, 120, 40);
            g.DrawEllipse(pen, startPosX, startPosY, 120, 40);

            g.FillRectangle(grayB, startPosX - 10, startPosY +5, 30, 30);
            g.DrawRectangle(pen, startPosX - 10, startPosY +5, 30, 30);

            g.FillRectangle(grayDB, startPosX + 30, startPosY + 5, 45, 30);
            g.FillRectangle(grayB, startPosX + 30, startPosY + 10, 45, 20);
            g.DrawRectangle(pen, startPosX + 30, startPosY + 10, 45, 20);
            g.FillEllipse(grayB, startPosX + 60, startPosY + 5, 10, 30);
            g.DrawEllipse(pen, startPosX + 60, startPosY + 5, 10, 30);
            g.DrawEllipse(pen, startPosX + 35, startPosY + 15, 10, 10);
            g.DrawEllipse(pen, startPosX + 45, startPosY + 15, 10, 10);
            g.DrawRectangle(pen, startPosX + 30, startPosY + 5, 45, 30);
        }

		public override void setPos(int x, int y)
		{
			startPosX = x;
			startPosY = y;
		}
    }
}