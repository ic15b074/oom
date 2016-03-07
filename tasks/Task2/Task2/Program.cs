using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var planes = new IAircraft[]
            {
                    //(planeNumber, maxFuel)
                new Plane("3HF543", 250),
                new Plane("3GJ234", 200),
                new Plane("3SD654", 350),
                new Plane("3KJ897", 150),
                    //(planeNumber, numberOfSeats)
                new SailPlane("3HC943", 1),
                new SailPlane("3GLC34", 2),
            };

            foreach (var x in planes)
            {
                Console.WriteLine($"{x.PlaneNumber} {x.NumberOfSeats} ");
            }

            Console.ReadLine();



            ///ALter Code TASK 1 & 2

            
            //(ist ähnlich wie das malloc, nur naturlich besser :-D )
            //var planes = new List<Plane>();


            //erstelln von FLugzeugen(Daten)
            //var plane1 = new Plane("3HF543", 250);
            //var plane2 = new Plane("3GJ234", 200);
            //var plane3 = new Plane("3SD654", 350);
            //var plane4 = new Plane("3KJ897", 150);

            //hinzufügen zu Daten
            //planes.Add(plane1);
            //planes.Add(plane2);
            //planes.Add(plane3);
            //planes.Add(plane4);

            //Schleife zum ausgeben
            //foreach (var plane in planes)
            //{
            //    Console.WriteLine("Number of Seats:{0} Plane Number: {1}",plane.NumberOfSeats, plane.PlaneNumber);
            //Console.WriteLine("Max Fuel Info:{0}", plane.ShowMaxFuelInfo());
            //}

            //Beispiel zum nutzen von "set;"
            //Änder der Anzahl der sitze von einem bestimmten Flugzeug 
            //plane2.NumberOfSeats = 10;

            //sogrt für eine leerezeile so ähnlich "\n"

            //Schleife zum ausgeben, aber diesmal mit der änderung
            //foreach (var plane in planes)
            //{
            //    Console.WriteLine("Number of Seats:{0} Plane Number: {1}", plane.NumberOfSeats, plane.PlaneNumber);
            //    Console.WriteLine("Max Fuel Info:{0}", plane.ShowMaxFuelInfo());
            //}

            //Console.WriteLine();

            //var sailPlanes = new List<SailPlane>();

            //var sailplane1 = new SailPlane("3HC943", 1);
            //var sailplane2 = new SailPlane("3GLC34", 2);

            //sailPlanes.Add(sailplane1);
            //sailPlanes.Add(sailplane2);

            //foreach (var sailplane in sailPlanes)
            //{
            //    Console.WriteLine("Number of Seats:{0} Plane Number: {1}", sailplane.NumberOfSeats, sailplane.PlaneNumber);

            //}
           
            ///
        }
    }
}
