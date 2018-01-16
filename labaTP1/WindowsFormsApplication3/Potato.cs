using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Potato
    {
        private int ready = 0;
        public bool cutted { set; get; }
        public int Ready { get { return ready; } }
        public void Heat()
        {
            if (ready < 10)
            {
                ready++;
            }
        }
    }
}
