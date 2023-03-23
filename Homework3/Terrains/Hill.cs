using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Hill : Terrain {
        public bool IsRocky;

        Random random = new Random();

        public Hill()
        {
            Name = "Hill-" + random.Next(1, 100);
            Elevation = Level.High;
            Weather = Weather.Cloudy;
            Size = 1000;
            IsRocky = true;
        }
        public Hill(string name)
        {
            Name = name;
            Elevation = Level.High;
            Weather = Weather.Cloudy;
            Size = 1000;
            IsRocky = true;
        }
    }
}
