using static UtilsLibrary.ListUtils;
using static UtilsLibrary.InputUtils;
using static UtilsLibrary.ConsoleUtils;

using Homework4.Implementations.ArrayType;
using Homework4.Implementations.ListType;

namespace Homework4
{
    public static class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation: \n1. List\n2. Array\nEnter desired implementation:");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    ProgramList.Run();
                    break;
                case 2:
                    ProgramArray.Run();
                    break;
            }
        }
    }
}