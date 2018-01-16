using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class ParkingAlredyHaveException : Exception
    {
        public ParkingAlredyHaveException() : base("Уже есть.") { }
    }
}
