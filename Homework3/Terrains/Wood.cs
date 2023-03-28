using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Wood : Terrain {
        private Level treeDensity { get; set; }

        readonly Random random = new Random();

        public Wood()
        {
            Name = "Wood-" + random.Next(1, 100);
            elevation = Level.Medium;
            size = 300;
            weather = Weather.Rainy;
            treeDensity = Level.High;
        }

        public Wood(string name)
        {
            Name = name;
            elevation = Level.Medium;
            size = 300;
            weather = Weather.Rainy;
            treeDensity = Level.High;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tree density: {treeDensity}";
        }
    }
}
