using Homework3.Terrains.Enums;

namespace Homework3.Terrains
{
    public class City : Terrain
    {
        public int Population { get; set; }

        Random random = new Random();

        public City()
        {
            Name = "City-" + random.Next(1, 100);
            Population = random.Next(1000, int.MaxValue);
            Elevation = Level.Low;
            Weather = Weather.Sunny;
            Size = 500;
        }
        public City(string name) { 
            Name = name;
            Population = random.Next(1000, int.MaxValue);
            Elevation = Level.Low;
            Weather = Weather.Sunny;
            Size = 500;
        }
        public City(string name, int population, int size)
        {
            Name = name;
            Population = population;
            Elevation = Level.Low;
            Weather = Weather.Sunny;
            Size = size;
        }
    }
}
