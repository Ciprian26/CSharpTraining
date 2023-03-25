using Homework3.Gearboxes;
using Homework3.Terrains;
using Homework3.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
    public class Suv : Car {
        private bool IsInOffRoadRegime;
        public Suv(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox gearboxType)
            : base(make, model, year, maxSpeed, numberOfDoors, gearboxType)
        {
            IsInOffRoadRegime = false;
            IsCarRunning = false;
        }

        public void PutInOffRoadRegime()
        {
            if (IsCarRunning)
            {
                IsInOffRoadRegime = true;
            }
            else
            {
                Console.WriteLine("Start the car first");
            }
        }

        public override void Drive(Terrain terrain)
        {
            if (!IsCarRunning)
            {
                Console.WriteLine("Start the car first.");
            }
            else if ((terrain is Hill) && IsInOffRoadRegime)
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
            return $"Type: SUV, " + base.ToString() + $", Off-Road Regime: {IsInOffRoadRegime}";
        }
    }
}
