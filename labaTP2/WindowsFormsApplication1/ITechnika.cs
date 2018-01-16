using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface ITechnika
    {
        void moveSudno(Graphics g);
        void drawSudno(Graphics g);
        void setPos(int x, int y);
        void loadCrew(int count);
        int getCrew();
    }
}