using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3.Terrains.Enums;

namespace Homework3.Terrains {
    public class Terrain {
        public string Name { get; set; }
        public Level Elevation { get; set; }
        public int Size { get; set; }
        public Weather Weather { get; set; }

        public virtual string ToString()
        {
            return $"Name: {Name}, Elevation: {Elevation}, Size: {Size}, Weather: {Weather}";
        }
    }
}
