using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Terka
    {
        public void Nateret(Other_ing o)
        {
            if (!o.has_ready)
            {
                o.has_ready = true;
            }
        }
    }
}
