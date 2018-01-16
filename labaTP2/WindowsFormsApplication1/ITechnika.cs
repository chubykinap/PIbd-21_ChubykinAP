using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
	public interface ITechnika
	{
		void moveSudno(Graphics g);
		void drawSudno(Graphics g);
		void setPos(int x, int y);
		void loadCrew(int count);
		int getCrew();
		void setMainColor(Color color);
        string getInfo();
	}
}