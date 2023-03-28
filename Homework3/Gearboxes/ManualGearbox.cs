namespace Homework3.Gearboxes {
    internal class ManualGearbox : Gearbox {
        readonly private int[] speeds = { -1, 0, 1, 2, 3, 4, 5 };
        internal int CurrentSpeed { get; set; }

        public ManualGearbox()
        {
            CurrentSpeed = 0;
        }

        public override void ShiftUp()
        {
            if(CurrentSpeed >= -1 && CurrentSpeed < 5)
            {
                CurrentSpeed++;
            }
            else
            {
                Console.WriteLine($"You cant move gearbox higher/lower than {CurrentSpeed} speed");
            }
        }

        public override void ShiftDown()
        {
            if(CurrentSpeed >= 0 && CurrentSpeed <= 5)
            {
                CurrentSpeed--;
            }
            else
            {
                Console.WriteLine($"You cant move gearbox higher/lower than {CurrentSpeed} speed");
            }
        }

        public override string ToString()
        {
            return $"Gearbox Type: Manual, Current Gearbox Speed: {CurrentSpeed}";
        }
    }
}
