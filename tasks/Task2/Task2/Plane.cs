using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Plane
    {

        private int maxFuel;

        public Plane(string planeNumber, int maxFuel){

            this.PlaneNummber = planeNumber;
            this.maxFuel = maxFuel;
        }

        
        public string PlaneNummber { get;}
        public int NummberOfSeats { get; set; }

        public int ShowMaxFuelInfo()
        {
            return maxFuel;
        }
        
    }
}
