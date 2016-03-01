using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class Plane : IAircraft
    {
        private int maxFuel;

        //Konstruktor (name muss identisch wie die klasse sein)
        public Plane(string planeNumber, int maxFuel)
        {
            this.PlaneNumber = planeNumber;
            this.maxFuel = maxFuel;
        }

        // holen von daten
        public string PlaneNumber { get; set; }
        //holen & ändern
        public int NumberOfSeats { get; set; }




        //funktion zu ausgabe von daten(die eigentlich privat ist)
        public int ShowMaxFuelInfo()
        {
            return maxFuel;
        }

    }
}

