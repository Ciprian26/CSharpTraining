using static UtilsLibrary.RandomUtils;

namespace Homework6.ZooAnimal.Animal {
    public class Giraffe : Animal, IDescription {
        public Giraffe()
        {
            Name = "Giraffe-" + GetRandomNumberInRange(1, 100).ToString();
            FoodType = "Herbivore";
            IsFed = false;
        }
        public Giraffe(String name)
        {
            Name = name;
            FoodType = "Herbivore";
            IsFed = false;
        }

        public string GetDescription()
        {
            return $"This is {Name}, who is {FoodType}. " +
                $"The giraffe is a tall, long-necked mammal native to Africa, known for its distinctive spotted coat and long legs.";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hum");
        }
    }
}
