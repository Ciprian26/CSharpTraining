using Homework3.Gearboxes;
using Homework3.Terrains;

namespace Homework3.Vehicles {
    public class Car : Vehicle {
        public int NumberOfDoors { get; set; }
        public bool IsCarRunning { get; set; }
        public Gearbox GearboxType { get; set; }

        public Car(string make, string model, int year, int maxSpeed, int numberOfDoors, Gearbox gearbox)
        {
            Make = make;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            NumberOfDoors = numberOfDoors;
            GearboxType = gearbox;
            IsCarRunning = false;
        }
        public Car(string make, string model, int year, int numberOfDoors, Gearbox gearbox)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfDoors = numberOfDoors;
            GearboxType = gearbox;
            IsCarRunning = false;
        }

        public override void Start()
        {
            if(!IsCarRunning)
            {
                Console.WriteLine("Starting the car...\n Engine is revving up...\n " +
                    "Putting off the hand brake...\n Car has started. Drive safe!");

                if(GearboxType is ManualGearbox)
                {
                    ((ManualGearbox)GearboxType).CurrentSpeed = 1;
                }
                else if(GearboxType is AutomaticGearbox)
                {
                    ((AutomaticGearbox)GearboxType).CurrentSpeed = 'D';
                }

                IsCarRunning = true;
            }
            else { Console.WriteLine("Car is already running."); }
        }

        public override void Stop()
        {
            if(IsCarRunning)
            {
                Console.WriteLine("Stopping the car...\n Setting the hand brake on.");
                if(GearboxType is ManualGearbox)
                {
                    ((ManualGearbox)GearboxType).CurrentSpeed = 0;
                }
                else
                {
                    ((AutomaticGearbox)GearboxType).CurrentSpeed = 'P';
                }
            }
        }

        public virtual void Drive(Terrain terrain)
        {
            Console.WriteLine("Driving...");
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Max Speed: {MaxSpeed}, " +
                   $"Number of Doors: {NumberOfDoors}, Gearbox Type: {GearboxType}, " +
                   $"Is Car Running: {IsCarRunning}";
        }
    }
}
