using static UtilsLibrary.RandomUtils;

namespace Homework6.Person.Workers {
    internal class TicketSeller : ZooWorker, IDescription {
        public static int TotalTicketsSold { get; private set; }
        public int TicketsSold { get; set; }

        public TicketSeller(String name, int age, int salary)
        {
            Name = name;
            Age = age;
            this.salary = salary;
        }
        public TicketSeller(int age, int salary)
        {
            Name = "Worker-" + GetRandomNumberInRange(1, 100).ToString();
            Age = age;
            this.salary = salary;
        }

        public TicketSeller()
        {
            TicketsSold = 0;
        }

        public void SellTicket()
        {
            TicketsSold++;
            TotalTicketsSold++;
            Console.WriteLine($"Sold ticket with number {TicketsSold}");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} started workin.");
        }

        public string GetDescription()
        {
            return $"This is {Name} of age {Age}. He is a ticket seller. Currently he sold {TicketsSold} tickets.";
        }
    }
}
