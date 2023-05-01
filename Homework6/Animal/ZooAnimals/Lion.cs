using static UtilsLibrary.RandomUtils;

namespace Homework6.ZooAnimal.Animal {
    public class Lion : Animal, IDescription {
        public Lion()
        {
            Name = "Lion-" + GetRandomNumberInRange(1, 100).ToString();
            FoodType = "Carnivore";
            IsFed = false;
        }
        public Lion(String name)
        {
            Name = name;
            FoodType = "Carnivore";
            IsFed = false;
        }

        public string GetDescription()
        {
            return $"This is {Name}, who is {FoodType}." +
                $"The lion is a large, carnivorous feline that lives in groups called prides.";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
