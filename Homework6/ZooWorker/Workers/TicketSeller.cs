using static UtilsLibrary.RandomUtils;

namespace Homework6.Person.Workers {
    public class TicketSeller : ZooWorker, IDescription {
        public static int TotalTicketsSold { get; private set; }
        public int TicketsSold { get; set; }

        public TicketSeller(String name, int age, int salary) : base(name, age, salary)
        {
        }
        public TicketSeller(int age, int salary) : base("Worker-" + GetRandomNumberInRange(1, 100).ToString(), age, salary)
        {
        }

        public TicketSeller() : base()
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
