using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Pan
    {
        private Water water;
        private Potato[] potato;
        private Kapusta[] kapusta;
        private Other_ing other = new Other_ing();
        private bool ready_to_cook = false;
        public bool Ready_to_cook { get { AllIn(); return ready_to_cook; } }

        public void Init(int count1, int count2)
        {
            potato = new Potato[count1];
            kapusta = new Kapusta[count2];
        }

        public void addKap(Kapusta[] k)
        {
            if (kapusta == null)
            {
                kapusta = k;
            }
        }

        public void addWater(Water w)
        {
            water = w;
        }

        public void addPotato(Potato[] p)
        {
            if (potato == null)
            {
                potato = p;
                return;
            }
        }

        public void addOther(Other_ing o)
        {
            other = o;
        }

        public void GetHeat()
        {
            if (!ready_to_cook)
            {
                return;
            }
            if (water.Temperature == 100)
            {
                for (int i = 0; i < potato.Length; i++)
                {
                    potato[i].Heat();
                }
                for (int i = 0; i < kapusta.Length; i++)
                {
                    kapusta[i].Heat();
                }
                other.Heat();
            }
            else
            {
                water.Heat();
            }
        }

        public void AllIn()
        {
            if (kapusta == null || potato == null || other == null || water == null)
            {
                ready_to_cook = false;
            }
            ready_to_cook = true;
        }

        public bool Is_ready()
        {
            if (kapusta == null || potato == null)
            {
                return false;
            }
            for (int i = 0; i < kapusta.Length; i++)
            {
                if (kapusta[i].Ready < 10)
                {
                    return false;
                }
            }
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i].Ready < 10)
                {
                    return false;
                }
            }
            if (other.Ready < 10)
            {
                return false;
            }

            return true;
        }
    }
}