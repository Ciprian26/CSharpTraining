using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Terrain {
        internal string Name { get; set; }
        protected Level elevation { get; set; }
        protected int size { get; set; }
        protected Weather weather { get; set; }

        public virtual string ToString()
        {
            return $"Name: {Name}, Elevation: {elevation}, Size: {size}, Weather: {weather}";
        }
    }
}
