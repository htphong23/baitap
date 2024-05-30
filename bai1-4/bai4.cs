using System;

namespace FindMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine($"The maximum value in the array is {maxValue}");
        }
    }
}
