namespace Homework6.ZooAnimal.Animal {
    public abstract class Animal {
        public string Name { get; set; }
        public string FoodType { get; set; }
        public bool IsFed { get; set; }

        public void Feed()
        {
            if (IsFed)
            {
                Console.WriteLine($"{Name} has been already fed.");
            }
            else
            {
                IsFed = true;
                Console.WriteLine($"{Name} has been fed.");
            }
        }

        public abstract void MakeSound();

        public virtual String GetFedStatus()
        {
            return $"{Name} looks {(IsFed ? "fed" : "hungry")}.";
        }
    }
}
