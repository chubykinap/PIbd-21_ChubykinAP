using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("Нет свободных мест") { }
    }
}
