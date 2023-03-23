using Homework3.Gearboxes;
using Homework3.Terrains;
using Homework3.Vehicles;

namespace Homework3
{
    internal class Program {
        static void Main(string[] args)
        {
            ManualGearbox manualGearbox = new ManualGearbox();
            Car manualCar = new Car("Toyota", "Prius", 1996, 4, manualGearbox);
            Console.WriteLine(manualCar.ToString());
        }

        static void SetUpTerrains()
        {
            Hill defaultHill = new Hill();
            City defaultCity = new City();
            Wood defaultWood = new Wood();

            City Chisinau = new City("Chisinau", 523000, 123);
            City Bucharest = new City("Bucharest", 1830000, 239);
            City Sofia = new City("Sofia", 1230000, 492);
        }

        static void SetUpCars() { 
            ManualGearbox manualGearbox = new ManualGearbox();
            AutomaticGearbox automaticGearbox = new AutomaticGearbox();

            Suv defaultManualSuv = new Suv("Hyundai", "Tucson", 2019, 220, 5, manualGearbox);
            Suv defaultAutomaticSuv = new Suv("Mazda", "CX-30", 2020, 200, 5, automaticGearbox);

            Sedan defaultManualSedan = new Sedan("Volkswagen", "Gold", 2017, 260, 4, manualGearbox);
            Sedan defaultAutomatiSedan = new Sedan("Ford", "Fusion", 2015, 200, 5, automaticGearbox);
        }
    }
}