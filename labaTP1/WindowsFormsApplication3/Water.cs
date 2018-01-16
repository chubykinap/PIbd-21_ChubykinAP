using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Water
    {
        private int temperature = 0;
        public int Temperature { set; get; }
        public void Heat()
        {
            if(temperature < 100)
            {
                temperature++;
            }
        }
    }
}
