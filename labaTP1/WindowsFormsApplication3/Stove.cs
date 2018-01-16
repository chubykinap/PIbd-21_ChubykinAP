using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Stove
    {
        private Pan pan;
        public bool state { set; get; }
        public Pan Pan { set { pan = value; }get { return pan; } }

        public void Cook()
        {
            if (state)
            {
                while (pan.Is_ready())
                {
                    pan.GetHeat();
                }
            }
        }
    }
}
