using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int integerInput = int.Parse(Console.ReadLine());

            // Casting integer to double
            double doubleNumber = (double)integerInput;

            Console.WriteLine($"The number you entered is {integerInput} and as a double is {doubleNumber}");
        }
    }
}
