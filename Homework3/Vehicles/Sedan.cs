using Homework3.Gearboxes;
using Homework3.Terrains;
using Homework3.Vehicles;

namespace Homework3 {
    public class Sedan : Car {
        private bool isInComfortRegime;
        public Sedan(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox gearboxType)
            : base(make, model, year, maxSpeed, numberOfDoors, gearboxType)
        {
            isInComfortRegime = false;
            isCarRunning = false;
        }

        public void PutInComfortRegime()
        {
            if (isCarRunning)
            {
                isInComfortRegime = true;
                Console.WriteLine("Car is in comfort regime.");
            }
            else
            {
                Console.WriteLine("Start the car first.");
            }
        }

        public override void Drive(Terrain terrain)
        {
            if (!isCarRunning)
            {
                Console.WriteLine("Start the car first.");
            }
            else if ((terrain is City) && isInComfortRegime)
            {
                Console.WriteLine("You are driving in the city... but with comfort.");
            }
            else if ((terrain is City) && !isInComfortRegime)
            {
                Console.WriteLine("You are driving in the city");
            }
            else
            {
                Console.WriteLine("This car is not suitable for this kind of terrain");
            }
        }

        public override string ToString()
        {
            return $"Type: Sedan, " + base.ToString() + $", Comfort Regime: {isInComfortRegime}";
        }
    }
}
