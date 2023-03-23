using Homework3.Gearboxes;

namespace Homework3 {
    internal class Program {
        static void Main(string[] args)
        {
            ManualGearbox manualGearbox = new ManualGearbox();
            Car manualCar = new Car("Toyota", "Prius", 1996, 4, manualGearbox);
            Console.WriteLine(manualCar.ToString);
        }
    }
}