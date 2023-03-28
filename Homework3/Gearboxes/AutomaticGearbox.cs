namespace Homework3.Gearboxes {
    internal class AutomaticGearbox : Gearbox {
        readonly private char[] speeds = { 'R', 'N', 'D', 'P' };
        internal char CurrentSpeed { get; set; }

        public AutomaticGearbox() {
            CurrentSpeed = 'P';
        }

        public void SetCurrentSpeed(char selectedSpeed)
        {
            if(speeds.Contains(selectedSpeed))
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
