using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Hill : Terrain {
        private bool IsRocky;

        readonly Random random = new Random();

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

        public override string ToString()
        {
            return base.ToString() + $", Is Rocky: {IsRocky}";
        }
    }
}
