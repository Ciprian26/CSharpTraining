using Homework2.CommonUtils;

class HomeworkTwo {
    public static void Run()
    {
        int selectedTask;
        do
        {
            selectedTask = DisplayAndSelectTaskNumberToRun();
            switch (selectedTask)
            {
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                case 1:
                    CheckIfNumberIsDivisibleBy7and11();
                    break;
                case 2:
                    CheckIfYearIsLeap();
                    break;
                case 3:
                    Find47thPrimeNumber();
                    break;
                case 4:
                    SumOfEvenFibonacciNumbers();
                    break;
                case 5:
                    FindSecondLargestElement();
                    break;
                case 6:
                    FindSumOfDigits();
                    break;
                case 7:
                    ConvertBinaryToDecimal();
                    break;
                case 8:
                    FindOptimalBinaryRepresentation();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        } while (selectedTask != 0);
    }

    private static int DisplayAndSelectTaskNumberToRun()
    {
        ConsoleUtils.SetConsoleColor(ConsoleColor.Yellow);
        Console.WriteLine("---Homework #2---\n" +
                  "1. Check that number is divided by 7 and 11\n" +
                  "2. Check if year is leap\n" +
                  "3. Check what is 47th prime number\n" +
                  "4. Fibonacci even-numbers sum that not exceed 1000\n" +
                  "5. Second largest element in an array\n" +
                  "6. Find the sum of digits of a number read from the keyboard.\n" +
                  "7. Convert Binary 10011010 to Decimal number system.\n" +
                  "0. Exit\n\n" +
                  "Bonus:\n" +
                  "8. Challenge - Find an optimal solution to the code that converts a decimal to binary.\n\n" +
                  "\nEnter task number");

        ConsoleUtils.SetConsoleColor(ConsoleColor.Green);
        return InputUtils.GetNumberInRange(0, 8);
    }

    private static void CheckIfNumberIsDivisibleBy7and11()
    {
        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
        Console.WriteLine("Enter a number to check if it's divisible by 7 and 11: ");
        int number = InputUtils.GetNumber();
        if (number % 7 == 0 && number % 11 == 0)
        {
            Console.WriteLine($"Number {number} is divisible by 7 and 11");
        }
        else
        {
            Console.WriteLine($"Number {number} is not divisible by 7 and 11");
        }
    }

    private static void CheckIfYearIsLeap()
    {
        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
        int year = InputUtils.GetNumberInRange(1, 20000);

        if (year % 4 == 0)
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

        while (primeCount < TargetPrimeCount)
        {
            if (NumberUtils.IsPrime(currentNumber))
            {
                primeCount++;
            }

            if (primeCount == TargetPrimeCount)
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

        while (fibonnaciNumber <= limit)
        {
            if (fibonnaciNumber % 2 == 0)
            {
                sum += fibonnaciNumber;
            }

            int temp = previousFibonnaciNumber + fibonnaciNumber;
            previousFibonnaciNumber = fibonnaciNumber;
            fibonnaciNumber = temp;
        }

        Console.WriteLine("The sum of the even-valued numbers in the Fibonacci sequence up to 1000 is: " + sum);

    }

    private static void FindSecondLargestElement()
    {
        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
        Console.WriteLine("Enter the length of the array");
        int n = InputUtils.GetNumberInRange(2, 10);

        int[] arr = new int[n];

        NumberUtils.SetArrayElements(arr);

        int[] sortedArray = arr.OrderByDescending(n => n).ToArray();

        Console.WriteLine($"Second largest number in given array is: {sortedArray[1]}");
    }

    private static void FindSumOfDigits()
    {
        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
        int number = InputUtils.GetNumberInRange(1, 100000);
        int[] digits = NumberUtils.GetNumberDigits(number);

        int sum = digits.Sum(n => n);
        Console.WriteLine($"Number {number} digits sum is: {sum}");
    }

    private static void ConvertBinaryToDecimal()
    {
        String binarNumber = "10011010";
        ConsoleUtils.SetConsoleColor(ConsoleColor.Blue);
        double number = NumberUtils.ConvertBinaryToDecimal(binarNumber);
        Console.WriteLine($"The decimal of {binarNumber} binary is: {number}");
    }

    private static void FindOptimalBinaryRepresentation()
    {
        throw new NotImplementedException();
    }
}