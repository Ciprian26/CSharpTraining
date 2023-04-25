using static UtilsLibrary.RandomUtils;

namespace Homework6.ZooAnimal.Animal {
    public class Monkey : Animal, IDescription {
        public Monkey()
        {
            Name = "Monkey-" + GetRandomNumberInRange(1, 100).ToString();
            FoodType = "Omnivore";
            IsFed = false;
        }
        public Monkey(String name)
        {
            Name = name;
            FoodType = "Omnivore";
            IsFed = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hiss");
        }

        public string GetDescription()
        {
            return $"This is {Name}, who is {FoodType}. " +
                $"Monkeys are intelligent primates known for their dexterous hands and complex social behaviors.";
        }
    }
}
