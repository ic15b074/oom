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
            var planes = new List<Plane>();

            var plane1 = new Plane("3HF543", 250);
            var plane2 = new Plane("3GJ234", 200);
            var plane3 = new Plane("3SD654", 350);
            var plane4 = new Plane("3KJ897", 150);

            planes.Add(plane1);
            planes.Add(plane2);
            planes.Add(plane3);
            planes.Add(plane4);

            foreach(var plane in planes)
            {
                Console.WriteLine("Number of Seats:{0} Plane Number: {1}",plane.NummberOfSeats, plane.PlaneNummber);
                Console.WriteLine("Max Fuel Info:{0}", plane.ShowMaxFuelInfo());
            }

            plane2.NummberOfSeats = 10;

            Console.WriteLine();

            foreach (var plane in planes)
            {
                Console.WriteLine("Number of Seats:{0} Plane Number: {1}", plane.NummberOfSeats, plane.PlaneNummber);
                Console.WriteLine("Max Fuel Info:{0}", plane.ShowMaxFuelInfo());
            }

            Console.ReadLine();
        }
    }
}
