using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SailPlane : IAircraft 
    {
        // holen von daten
        public string PlaneNumber { get; set; }
        //holen & ändern
        public int NumberOfSeats { get; set; }


    }
}
