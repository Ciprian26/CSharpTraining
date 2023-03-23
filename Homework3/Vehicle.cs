namespace Homework3 {
    public class Vehicle {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }

        public virtual void Start()
        {
            Console.WriteLine($"Starting...");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Stopping...");
        }

    }
}
