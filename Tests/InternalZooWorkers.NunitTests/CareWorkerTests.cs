using Homework6.Person.Workers;
using Homework6.ZooAnimal.Animal;

namespace InternalZooWorkers.NunitTests {
    public class CareWorkerTests {
        [Test]
        public void Constructor_ValidArgumentsWithNoName_CreatesCareWorkerInstanceWithRandonName()
        {
            //Arrange
            string Name = "George";
            int Age = 25;
            int Salary = 8000;

            //Act
            var careWorker = new CareWorker(Age, Salary);

            //Assert
            Assert.IsNotNull(careWorker);
            Assert.AreNotEqual(Name, careWorker.Name);
            Assert.AreEqual(Age, careWorker.Age);
            Assert.IsNull(careWorker.AnimalsInCare);
        }

        [Test]
        public void AddAnimalToCare_AnimalNotInCare_AnimalAddedToAnimalsInCareList()
        {
            // Arrange
            var worker = new CareWorker("George", 25, 8000);
            var animal1 = new Lion();

            // Act
            worker.AnimalsInCare = new List<Animal>();
            worker.AddAnimalToCare(animal1);

            // Assert
            Assert.IsTrue(worker.AnimalsInCare.Contains(animal1));
        }

        [Test]
        public void FeedAnimalsInCare_AllAnimalsAreFed_CallsFeedMethodForEachAnimal()
        {
            // Arrange
            var worker = new CareWorker("George", 25, 8000);
            var animal1 = new Lion();
            var animal2 = new Monkey();

            worker.AnimalsInCare = new List<Animal> { animal1, animal2 };

            // Act
            worker.FeedAnimalsInCare();

            // Assert
            Assert.IsTrue(animal1.IsFed);
            Assert.IsTrue(animal2.IsFed);
        }

        [Test]
        public void RemoveAnimalFromCare_AnimalExistsInCare_AnimalRemovedFromAnimalsInCareList()
        {
            // Arrange
            var worker = new CareWorker("George", 25, 8000);
            var animal1 = new Lion();
            var animal2 = new Monkey();
            worker.AnimalsInCare = new List<Animal> { animal1, animal2 };

            // Act
            worker.RemoveAnimalFromCare(animal1);

            // Assert
            Assert.IsFalse(worker.AnimalsInCare.Contains(animal1));
            Assert.IsTrue(worker.AnimalsInCare.Contains(animal2));
        }
    }
}