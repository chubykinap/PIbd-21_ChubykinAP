using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Other_ing
    {
        public bool be = true;
        private int ready = 0;
        public bool has_ready { set; get; }
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
