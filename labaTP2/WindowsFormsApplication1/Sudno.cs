using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
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
    }
}
