using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class City : Terrain {
        private int population { get; set; }

        readonly Random random = new Random();

        public City()
        {
            Name = "City-" + random.Next(1, 100);
            population = random.Next(1000, int.MaxValue);
            elevation = Level.Low;
            weather = Weather.Sunny;
            size = 500;
        }
        public City(string name)
        {
            Name = name;
            population = random.Next(1000, int.MaxValue);
            elevation = Level.Low;
            weather = Weather.Sunny;
            size = 500;
        }
        public City(string name, int population, int size)
        {
            Name = name;
            this.population = population;
            elevation = Level.Low;
            weather = Weather.Sunny;
            base.size = size;
        }

        public override string ToString()
        {
            return base.ToString() + $", Population: {population}";
        }
    }
}
