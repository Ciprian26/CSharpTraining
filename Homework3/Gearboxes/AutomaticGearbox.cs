using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Gearboxes {
    internal class AutomaticGearbox : Gearbox {
        public char[] Speeds = { 'R', 'N', 'D', 'P' };
        public char CurrentSpeed { get; set; }

        public AutomaticGearbox() {
            CurrentSpeed = 'P';
        }

        public void SetCurrentSpeed(char selectedSpeed)
        {
            if(Speeds.Contains(selectedSpeed))
            {
                CurrentSpeed = selectedSpeed;
            }
            else
            {
                Console.WriteLine($"Invalid speed, please select a speed (R, N, D, P): ");
            }
        }
        public override string ToString()
        {
            return $"Gearbox Type: Automatic, Current Gearbox Speed: {CurrentSpeed}";
        }
    }
}
