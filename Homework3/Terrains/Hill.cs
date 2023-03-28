using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Hill : Terrain {
        private bool isRocky;

        readonly Random random = new Random();

        public Hill()
        {
            Name = "Hill-" + random.Next(1, 100);
            elevation = Level.High;
            weather = Weather.Cloudy;
            size = 1000;
            isRocky = true;
        }
        public Hill(string name)
        {
            Name = name;
            elevation = Level.High;
            weather = Weather.Cloudy;
            size = 1000;
            isRocky = true;
        }

        public override string ToString()
        {
            return base.ToString() + $", Is Rocky: {isRocky}";
        }
    }
}
