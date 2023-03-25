namespace Homework3.Gearboxes {
    public class Gearbox {
        public virtual void ShiftUp()
        {
            Console.WriteLine("Shifting gear one speed up");
        }

        public virtual void ShiftDown()
        {
            Console.WriteLine("Shifting gear one speed down");
        }
    }
}
