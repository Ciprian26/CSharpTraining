using Homework3.Gearboxes;
using Homework3.Terrains;
using Homework3.Vehicles;
using System.Linq;
using UtilsLibrary;

namespace Homework3 {
    public static class Program {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            Car selectedCar;
            int counter = 1;

            Dictionary<string, Car> defaultCarsList = SetUpCars();
            Dictionary<string, Terrain> defaultTerrainsList = SetUpTerrains();
            Dictionary<string, City> capitalCitiesList = SetUpCapitalCities();

            Console.WriteLine("Would you like to make your own car? Y/N");

            String userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Y":
                    Car usersCar = MakeOwnCar<Car>();
                    AddCarToCarList<Car>(defaultCarsList, usersCar);
                    selectedCar = usersCar;
                    break;
                case "N":
                    Console.WriteLine("A random car will be assigned from the default car list: ");
                    foreach (var car in defaultCarsList)
                    {
                        Console.WriteLine("\n" + car.ToString());
                    }
                    selectedCar = defaultCarsList.Values.ElementAt(rand.Next(defaultCarsList.Count));
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("A random car will be assigned from the default car list: ");
                    foreach (var car in defaultCarsList)
                    {
                        Console.WriteLine("\n" + car.ToString());
                    }
                    selectedCar = defaultCarsList.Values.ElementAt(rand.Next(defaultCarsList.Count));
                    break;
            }
            ConsoleUtils.SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("\nYour selected car is " + selectedCar.ToString());

            Console.WriteLine("\nStart the car? Y/N");
            switch (Console.ReadLine())
            {
                case "Y":
                    selectedCar.Start();
                    break;
                default:
                    Console.WriteLine("There is no point to go further if you don't start the car. Let me start it for you.");
                    selectedCar.Start();
                    break;
            }
            if (selectedCar is Sedan)
            {
                Console.WriteLine("\nWould you like to put your car in comfort mode? Y/N");
                switch (Console.ReadLine())
                {
                    case "Y":
                        Console.WriteLine("Car was put in comfort regime");
                        ((Sedan)selectedCar).PutInComfortRegime();
                        break;
                    default:
                        Console.WriteLine("No comfort regime was activated.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nWould you like to put your car in off-road regime? Y/N");
                switch (Console.ReadLine())
                {
                    case "Y":
                        Console.WriteLine("Car was put in off-road regime");
                        ((Suv)selectedCar).PutInOffRoadRegime();
                        break;
                    default:
                        Console.WriteLine("No comfort regime was activated.");
                        break;
                }
            }

            ConsoleUtils.SetConsoleColor(ConsoleColor.Green);
            Console.WriteLine("\nAvailable terrains: ");
            foreach (var terrain in defaultTerrainsList)
            {
                Console.WriteLine($"\n {counter}." + terrain.Value.ToString());
                counter++;
            }

            Console.WriteLine("\n Choose a number to visit the location, or choose 4 for a special trip :)");
            int selectedTerrainNumber = int.Parse(Console.ReadLine());
            if (selectedTerrainNumber == 4)
            {
                Console.WriteLine("You are going on a little trip to some capitals.");
                foreach (var capital in capitalCitiesList)
                {
                    selectedCar.Drive(capital.Value);
                    Console.WriteLine(capital.Value.ToString());
                }
            }
            else if (selectedTerrainNumber > 0 && selectedTerrainNumber < 4)
            {
                selectedCar.Drive(defaultTerrainsList.ElementAt(selectedTerrainNumber - 1).Value);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static Dictionary<string, Terrain> SetUpTerrains()
        {
            Console.WriteLine("Setting up default terrains...");

            Dictionary<string, Terrain> terrainsList = new Dictionary<string, Terrain>();

            Hill defaultHill = new Hill("Default Hill");
            City defaultCity = new City("Default City");
            Wood defaultWood = new Wood("Default Wood");
            AddTerrainToList(terrainsList, defaultHill);
            AddTerrainToList(terrainsList, defaultCity);
            AddTerrainToList(terrainsList, defaultWood);

            return terrainsList;
        }

        static Dictionary<string, City> SetUpCapitalCities()
        {
            Console.WriteLine("Setting up capital cities...");

            Dictionary<string, City> citiesList = new Dictionary<string, City>();
            City Chisinau = new City("Chisinau", 523000, 123);
            City Bucharest = new City("Bucharest", 1830000, 239);
            City Sofia = new City("Sofia", 1230000, 492);
            AddTerrainToList(citiesList, Chisinau);
            AddTerrainToList(citiesList, Bucharest);
            AddTerrainToList(citiesList, Sofia);

            return citiesList;
        }

        static Dictionary<string, Car> SetUpCars()
        {
            Console.WriteLine("Setting up default cars...");

            Dictionary<string, Car> carsList = new Dictionary<string, Car>();
            ManualGearbox manualGearbox = new ManualGearbox();
            AutomaticGearbox automaticGearbox = new AutomaticGearbox();

            Suv defaultManualSuv = new Suv("Hyundai", "Tucson", 2019, 220, 5, manualGearbox);
            Suv defaultAutomaticSuv = new Suv("Mazda", "CX-30", 2020, 200, 5, automaticGearbox);
            AddCarToCarList(carsList, defaultManualSuv);
            AddCarToCarList(carsList, defaultAutomaticSuv);

            Sedan defaultManualSedan = new Sedan("Volkswagen", "Gold", 2017, 260, 4, manualGearbox);
            Sedan defaultAutomatiSedan = new Sedan("Ford", "Fusion", 2015, 200, 5, automaticGearbox);
            AddCarToCarList(carsList, defaultManualSedan);
            AddCarToCarList(carsList, defaultAutomatiSedan);

            return carsList;
        }

        static void AddCarToCarList<T>(Dictionary<string, T> carList, T carToAdd) where T : Car
        {
            carList.Add($"{carToAdd.Make} {carToAdd.Model}", carToAdd);
        }

        static void AddTerrainToList<T>(Dictionary<string, T> terrainList, T terrainToAdd) where T : Terrain
        {
            terrainList.Add($"{terrainToAdd.Name}", terrainToAdd);
        }

        static T MakeOwnCar<T>() where T : Car
        {
            Console.WriteLine("Specify your car parameters, divided by comma:\n" +
                "Sedan/SUV, Make, Model, Year, Top Speed, Door numbers, Gearbox Type: \n" +
                "Example: Sedan, Toyota, Prius, 2014, 220, 5, Automatic");

            string input = Console.ReadLine();
            string[] parameters = input.Split(',');

            string carType = parameters[0].Trim();
            string make = parameters[1].Trim();
            string model = parameters[2].Trim();
            int year = int.Parse(parameters[3].Trim());
            int topSpeed = int.Parse(parameters[4].Trim());
            int doorCount = int.Parse(parameters[5].Trim());
            string gearboxType = parameters[6].Trim();

            if (carType.Equals("SUV", StringComparison.OrdinalIgnoreCase) && gearboxType.Equals("Automatic", StringComparison.OrdinalIgnoreCase))
            {
                return new Suv(make, model, year, topSpeed, doorCount, new AutomaticGearbox()) as T;
            }
            else if (carType.Equals("SUV", StringComparison.OrdinalIgnoreCase))
            {
                return new Suv(make, model, year, topSpeed, doorCount, new ManualGearbox()) as T;
            }
            else if (carType.Equals("Sedan", StringComparison.OrdinalIgnoreCase) && gearboxType.Equals("Automatic", StringComparison.OrdinalIgnoreCase))
            {
                return new Sedan(make, model, year, topSpeed, doorCount, new AutomaticGearbox()) as T;
            }
            else
            {
                return new Sedan(make, model, year, topSpeed, doorCount, new ManualGearbox()) as T;
            }
        }
    }
}