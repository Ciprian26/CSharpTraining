using Homework3.Gearboxes;
using Homework3.Terrains;

namespace Homework3.Vehicles {
    public class Car : Vehicle {
        private int numberOfDoors { get; set; }
        protected bool isCarRunning { get; set; }
        protected Gearbox gearboxType { get; set; }

        public Car(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox gearbox)
        {
            Make = make;
            Model = model;
            base.year = year;
            base.maxSpeed = maxSpeed;
            this.numberOfDoors = numberOfDoors;
            gearboxType = gearbox;
            isCarRunning = false;
        }
        public Car(string make, string model, int year, int numberOfDoors, Gearbox gearbox)
        {
            Make = make;
            Model = model;
            base.year = year;
            this.numberOfDoors = numberOfDoors;
            gearboxType = gearbox;
            isCarRunning = false;
        }

        public override void Start()
        {
            if(!isCarRunning)
            {
                Console.WriteLine("Starting the car...\n Engine is revving up...\n " +
                    "Putting off the hand brake...\n Car has started. Drive safe!");

                if(gearboxType is ManualGearbox)
                {
                    ((ManualGearbox)gearboxType).CurrentSpeed = 1;
                }
                else if(gearboxType is AutomaticGearbox)
                {
                    ((AutomaticGearbox)gearboxType).CurrentSpeed = 'D';
                }

                isCarRunning = true;
            }
            else { Console.WriteLine("Car is already running."); }
        }

        public override void Stop()
        {
            if(isCarRunning)
            {
                Console.WriteLine("Stopping the car...\n Setting the hand brake on.");
                if(gearboxType is ManualGearbox)
                {
                    ((ManualGearbox)gearboxType).CurrentSpeed = 0;
                }
                else
                {
                    ((AutomaticGearbox)gearboxType).CurrentSpeed = 'P';
                }
            }
        }

        public virtual void Drive(Terrain terrain)
        {
            Console.WriteLine("Driving...");
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {year}, Max Speed: {maxSpeed}, " +
                   $"Number of Doors: {numberOfDoors}, Gearbox Type: {gearboxType}, " +
                   $"Is Car Running: {isCarRunning}";
        }
    }
}
