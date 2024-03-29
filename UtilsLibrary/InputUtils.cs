﻿namespace UtilsLibrary {
    public static class InputUtils
    {
        public static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int GetNumberInRange(int Min, int Max)
        {
            Console.Write("Please enter a number between " + Min + " and " + Max + ":");
            int number = int.Parse(Console.ReadLine());

            while (number < Min || number > Max)
            {
                Console.Write("Invalid input. Please enter a number between " + Min + " and " + Max + ":");
                number = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
