using Homework3.Gearboxes;
using Homework3.Terrains;
using Homework3.Vehicles;

namespace Homework3 {
    public class Suv : Car {
        private bool isInOffRoadRegime;
        public Suv(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox gearboxType)
            : base(make, model, year, maxSpeed, numberOfDoors, gearboxType)
        {
            isInOffRoadRegime = false;
            isCarRunning = false;
        }

        public void PutInOffRoadRegime()
        {
            if (isCarRunning)
            {
                isInOffRoadRegime = true;
            }
            else
            {
                Console.WriteLine("Start the car first");
            }
        }

        public override void Drive(Terrain terrain)
        {
            if (!isCarRunning)
            {
                Console.WriteLine("Start the car first.");
            }
            else if ((terrain is Hill) && isInOffRoadRegime)
            {
                Console.WriteLine("You are driving on hills.");
            }
            else if (terrain is Hill)
            {
                Console.WriteLine("Better first to put car in off-road regime");
            }
            else if (terrain is City)
            {
                Console.WriteLine("You are driving in the city");
            }
            else
            {
                Console.WriteLine("You are driving in the woods");
            }
        }

        public override string ToString()
        {
            return $"Type: SUV, " + base.ToString() + $", Off-Road Regime: {isInOffRoadRegime}";
        }
    }
}
