using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Water_tap
    {
        public bool State { set; get; }
        public Water GetWater()
        {
            if (State)
            {
                return new Water();
            }
            else
            {
                return null;
            }
        }
    }
}
