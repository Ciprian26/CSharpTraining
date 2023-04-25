using Homework6.ZooAnimal.Animal;
using static UtilsLibrary.RandomUtils;

namespace Homework6.Person.Workers {
    public class CareWorker : ZooWorker, IDescription {
        public List<Animal> AnimalsInCare { get; set; }

        public CareWorker(String name, int age, int salary)
        {
            Name = name;
            Age = age;
            this.salary = salary;
        }
        public CareWorker(int age, int salary)
        {
            Name = "Worker-" + GetRandomNumberInRange(1, 100).ToString();
            Age = age;
            this.salary = salary;
        }

        public void FeedAnimalsInCare()
        {
            foreach (Animal animal in AnimalsInCare)
            {
                animal.Feed();
                Console.WriteLine($"{Name} fed {animal.Name}.");
            }
        }

        public void AddAnimalToCare(Animal animal)
        {
            AnimalsInCare.Add(animal);
            Console.WriteLine($"Animal {animal.Name} was added in care to {Name}.");
        }

        public void RemoveAnimalFromCare(Animal animal)
        {
            AnimalsInCare.Remove(animal);
            Console.WriteLine($"Animal {animal.Name} was removed from care of {Name}.");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} started working.");
            FeedAnimalsInCare();
            Console.WriteLine($"{Name} finished working.");
        }

        public string GetDescription()
        {
            return $"This is {Name}, age {Age}.";
        }
    }
}
