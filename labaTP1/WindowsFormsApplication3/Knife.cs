using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Knife
    {       
        public void CutKap(Kapusta k)
        {
            if (!k.cutted)
            {
                k.cutted = true;
            }
            
        }   
        public void CutPot(Potato p)
        {
            if (!p.cutted)
            {
                p.cutted = true;
            }
        }   
    }
}
