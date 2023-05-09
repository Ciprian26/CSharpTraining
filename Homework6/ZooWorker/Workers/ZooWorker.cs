
namespace Homework6.Person.Workers {
    public abstract class ZooWorker : Person {
        internal int salary;

        public ZooWorker()
        {
        }

        public ZooWorker(String name, int age, int salary)
        {
            Name = name;
            Age = age;
            this.salary = salary;
        }

        public abstract void Work();
    }
}
