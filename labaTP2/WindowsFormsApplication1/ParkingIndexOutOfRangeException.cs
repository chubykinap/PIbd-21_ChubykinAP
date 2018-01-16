using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException() : base("Нет корабля на этом месте") { }
    }
}
