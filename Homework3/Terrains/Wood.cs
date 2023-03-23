using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Wood : Terrain {
        public Level TreeDensity { get; set; }

        Random random = new Random();

        public Wood()
        {
            Name = "Wood" + random.Next(1, 100);
            Elevation = Level.Medium;
            Size = 300;
            Weather = Weather.Rainy;
            TreeDensity = Level.High;
        }

        public Wood(string name)
        {
            Name = name;
            Elevation = Level.Medium;
            Size = 300;
            Weather = Weather.Rainy;
            TreeDensity = Level.High;
        }
    }
}
