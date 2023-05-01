using Homework6.Person.Workers;
using Homework6.ZooAnimal.Animal;
using static UtilsLibrary.ConsoleUtils;

namespace Homework6 {
    public static class Zoo {
        public static void Run()
        {
            List<Animal> animals = SetUpAnimals();
            List<CareWorker> careWorkers = SetUpWorkers(animals);
            TicketSeller ticketSeller = SetUpTicketSeller();

            int selectedAction;
            do
            {
                SetConsoleColor(ConsoleColor.Yellow);
                Console.WriteLine("\n*=====* Actions *=====*");

                DisplayOptionMenu();
                Console.WriteLine("\nEnter action number: ");
                selectedAction = int.Parse(Console.ReadLine());

                switch (selectedAction)
                {
                    case 1:
                        foreach (CareWorker worker in careWorkers)
                        {
                            worker.FeedAnimalsInCare();
                        }
                        break;
                    case 2:
                        ticketSeller.SellTicket();
                        break;
                }
            } while (selectedAction != 0);
        }

        private static void DisplayOptionMenu()
        {
            SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("Select an option:\n" +
                  "1. Feed animals.\n" +
                  "2. Sell 1 ticket.\n" +
                  "0. Exit.");

            SetConsoleColor(ConsoleColor.White);
        }

        private static List<Animal> SetUpAnimals()
        {
            List<Animal> animals = new List<Animal>();
            Giraffe giraffe = new Giraffe("Melman");
            Lion lion = new Lion("Alex");
            Monkey monkey = new Monkey("Julien");

            animals.Add(giraffe);
            animals.Add(lion);
            animals.Add(monkey);

            return animals;
        }

        private static List<CareWorker> SetUpWorkers(List<Animal> animals)
        {
            List<CareWorker> careWorkerList = new List<CareWorker>();
            CareWorker careWorker = new CareWorker("Jeff", 25, 1200);
            careWorker.AnimalsInCare = animals;
            careWorkerList.Add(careWorker);

            return careWorkerList;
        }

        private static TicketSeller SetUpTicketSeller()
        {
            TicketSeller ticketSeller = new TicketSeller("Mark", 35, 1600);
            return ticketSeller;
        }
    }
}
