using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Homeworks.CommonUtils {
    internal class NumberUtils {
        public static void SetArrayElements(int[] array)
        {
            Console.WriteLine("Enter the elements of the array:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                int inputNumber;
                while(!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write($"Element {i + 1}: ");
                }
                array[i] = inputNumber;
            }
        }

        public static int[] GetNumberDigits(int number)
        {
            int index = 0;
            int[] digits = new int[number.ToString().Length];
            while(number > 0)
            {
                digits[index] = number % 10;
                number /= 10;
                index++;
            }
            digits.Reverse();
            return digits;
        }

        public static double ConvertBinaryToDecimal(string binaryNumber)
        {
            double decimalNumber = 0;
            for(int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = (int)Char.GetNumericValue(binaryNumber[binaryNumber.Length - i - 1]);
                decimalNumber += digit * Math.Pow(2, i);
            }
            return decimalNumber;
        }

        public static bool IsPrime(int num)
        {
            if(num < 2)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
