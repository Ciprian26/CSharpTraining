using Homework3.Gearboxes;

namespace Homework3 {
    public class Car : Vehicle {
        public int NumberOfDoors { get; set; }
        public bool IsCarRunning { get; set; }
        public Gearbox GearboxType { get; set; }

        public Car(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox _gearbox)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.MaxSpeed = maxSpeed;
            this.NumberOfDoors = numberOfDoors;
            this.GearboxType = _gearbox;
            this.IsCarRunning = false;
        }
        public Car(string make, string model, int year, int numberOfDoors, Gearbox _gearbox)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.NumberOfDoors = numberOfDoors;
            this.GearboxType = _gearbox;
            this.IsCarRunning = false;
        }

        public override void Start()
        {
            if(!IsCarRunning)
            {
                Console.WriteLine("Starting the car...\n Engine is revving up...\n " +
                    "Putting off the hand brake...\n Car has started. Drive safe!");
            }
            else { Console.WriteLine("Car is already running."); }
        }

        public override void Stop()
        {
            if(IsCarRunning)
            {
                Console.WriteLine("Stopping the car...\n Setting the hand brake on.");
            }
        }
    }
}
