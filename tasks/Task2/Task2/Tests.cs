using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace Task2
{

    [TestFixture]
    class Tests
    {
        [Test]


        public void TestsPlane()
        {
            // Alowe to Create Plane
            var example = new Plane("3HF543", 250);

            // Alowe to Get PlaneNumber   
            Assert.IsTrue(example.PlaneNumber == "3HF543");

            // Alowe to Get NumberOfSeats
            Assert.IsTrue(example.NumberOfSeats == 0);

            // Alowe to change NumberOfSeats
            example.NumberOfSeats = 300;
            Assert.IsTrue(example.NumberOfSeats == 300);

            // Alowe to Get maxFuel
            Assert.IsTrue(example.ShowMaxFuelInfo() == 250);
        }

        public void TestseSailPlane()
        {
            // Alowe to Create SailPlane 
            var example = new SailPlane("3HC943", 1);

            // Alowe to Get PlaneNumber
            Assert.IsTrue(example.PlaneNumber == "3HC943");

            // Alowe to Get NumberOfSeats
            Assert.IsTrue(example.NumberOfSeats == 1);


        }
    }
}
