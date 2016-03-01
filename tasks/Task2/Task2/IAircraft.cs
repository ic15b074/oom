using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IAircraft
    {
        string PlaneNumber { get; set; }
        int NumberOfSeats { get; set;  }
    }
}
