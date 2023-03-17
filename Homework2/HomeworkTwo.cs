using Homework2.CommonUtils;

namespace Homework2 {
    public static class HomeworkTwo {
        public static void Run()
        {
            int selectedTask;
            do
            {
                selectedTask = DisplayAndSelectTaskNumberToRun();
                switch(selectedTask)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    case 1:
                        Console.WriteLine("Check that number is divided by 7 and 11.");
                        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
                        Console.WriteLine("Enter a number to check if it's divisible by 7 and 11: ");
                        int number = InputUtils.GetNumberInRange(int.MinValue, int.MaxValue);
                        CheckIfNumberIsDivisibleBy7and11(number);
                        break;
                    case 2:
                        Console.WriteLine("Check if year is leap.");
                        int year = InputUtils.GetNumberInRange(int.MinValue, int.MaxValue);
                        CheckIfYearIsLeap(year);
                        break;
                    case 3:
                        Console.WriteLine("Check what is 47th prime number.");
                        Find47thPrimeNumber();
                        break;
                    case 4:
                        Console.WriteLine("Fibonacci even-numbers sum that not exceed 1000.");
                        SumOfEvenFibonacciNumbers();
                        break;
                    case 5:
                        Console.WriteLine("Find the sum of digits of a number read from the keyboard.");
                        int num = InputUtils.GetNumberInRange(1, int.MaxValue);
                        FindSumOfDigits(num);
                        break;
                    case 6:
                        Console.WriteLine("Convert Binary 10011010 to Decimal number system.");
                        String binaryNumber = "10011010";
                        ConvertBinaryToDecimal(binaryNumber);
                        break;
                    case 7:
                        Console.WriteLine("Find an optimal solution to the code that converts a decimal to binary.");
                        int decimalNumber = InputUtils.GetNumberInRange(0, int.MaxValue);
                        FindOptimalBinaryRepresentation(decimalNumber);
                        break;
                    case 8:
                        Console.WriteLine("Enter the length of the array");
                        int arrayLength = InputUtils.GetNumberInRange(2, 10);

                        int[] arr = new int[arrayLength];
                        NumberUtils.SetArrayElements(arr);
                        FindSecondLargestElement(arr);
                        break;
                    default:
                        Console.WriteLine("Invalid task number. Please try again.");
                        break;
                }
            } while(selectedTask != 0);
        }

        private static int DisplayAndSelectTaskNumberToRun()
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("\n\n---Homework #2---\n" +
                      "1. Check that number is divided by 7 and 11.\n" +
                      "2. Check if year is leap.\n" +
                      "3. Check what is 47th prime number.\n" +
                      "4. Fibonacci even-numbers sum that not exceed 1000.\n" +
                      "5. Find the sum of digits of a number read from the keyboard.\n" +
                      "0. Exit.\n\n" +
                      "-Challenge:\n" +
                      "6. Convert Binary 10011010 to Decimal number system.\n" +
                      "7. Find an optimal solution to the code that converts a decimal to binary.\n\n" +
                      "-Removed previously but working:\n" +
                      "8. Find second largest element in an array.\n\n" +
                      "\nEnter task number: ");

            ConsoleUtils.SetConsoleColor(ConsoleColor.Green);
            return InputUtils.GetNumberInRange(0, 8);
        }

        private static void CheckIfNumberIsDivisibleBy7and11(int number)
        {
            if(number % 7 == 0 && number % 11 == 0)
            {
                Console.WriteLine($"Number {number} is divisible by 7 and 11");
            }
            else
            {
                Console.WriteLine($"Number {number} is not divisible by 7 and 11");
            }
        }

        private static void CheckIfYearIsLeap(int year)
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);

            if(year % 4 == 0)
            {
                Console.WriteLine($"{year} is leap.");
            }
            else
            {
                Console.WriteLine($"{year} is not leap.");
            }
        }

        private static void Find47thPrimeNumber()
        {
            const int TargetPrimeCount = 47;
            const int FirstPrimeNumber = 2;

            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);

            int primeCount = 0;
            int currentNumber = FirstPrimeNumber;

            while(primeCount < TargetPrimeCount)
            {
                if(NumberUtils.IsPrime(currentNumber))
                {
                    primeCount++;
                }

                if(primeCount == TargetPrimeCount)
                {
                    Console.WriteLine($"The {TargetPrimeCount}th prime number is: {currentNumber}");
                    break;
                }

                currentNumber++;
            }
        }

        private static void SumOfEvenFibonacciNumbers()
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);

            int limit = 1000, sum = 0, previousFibonnaciNumber = 0, fibonnaciNumber = 1;

            while(fibonnaciNumber <= limit)
            {
                if(fibonnaciNumber % 2 == 0)
                {
                    sum += fibonnaciNumber;
                }

                int temp = previousFibonnaciNumber + fibonnaciNumber;
                previousFibonnaciNumber = fibonnaciNumber;
                fibonnaciNumber = temp;
            }

            Console.WriteLine("The sum of the even-valued numbers in the Fibonacci sequence up to 1000 is: " + sum);
        }

        private static void FindSumOfDigits(int number)
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
            int[] digits = NumberUtils.GetNumberDigits(number);

            int sum = digits.Sum(n => n);
            Console.WriteLine($"Number {number} digits sum is: {sum}");
        }

        private static void ConvertBinaryToDecimal(String binaryNumber)
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
            double number = NumberUtils.ConvertBinaryToDecimal(binaryNumber);
            Console.WriteLine($"The decimal of {binaryNumber} binary is: {number}");
        }

        private static void FindOptimalBinaryRepresentation(int decimalNumber)
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
            string binaryNumber = "";
            int initialDecimalNumber = decimalNumber;

            if(decimalNumber == 0)
            {
                Console.WriteLine($"The binary number of decimal {decimalNumber} is: 0");
                return;
            }

            while(decimalNumber > 0)
            {
                int bit = decimalNumber % 2;
                binaryNumber = bit + binaryNumber;
                decimalNumber /= 2;
            }

            Console.WriteLine($"The binary number of decimal {initialDecimalNumber} is: {binaryNumber}");
        }
        private static void FindSecondLargestElement(int[] arr)
        {
            ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);

            int[] sortedArray = arr.OrderByDescending(n => n).ToArray();

            Console.WriteLine($"Second largest number in given array is: {sortedArray[1]}");
        }
    }
}