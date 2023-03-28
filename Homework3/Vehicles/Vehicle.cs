namespace Homework3 {
    public class Vehicle {
        internal string Make { get; set; }
        internal string Model { get; set; }
        protected int year { get; set; }
        protected int maxSpeed { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Starting...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping...");
        }
    }
}
