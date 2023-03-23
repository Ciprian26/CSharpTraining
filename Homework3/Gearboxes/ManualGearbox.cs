namespace Homework3.Gearboxes {
    internal class ManualGearbox : Gearbox {
        public int[] Speeds = { -1, 0, 1, 2, 3, 4, 5 };
        public int CurrentSpeed { get; set; }

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
    }
}
