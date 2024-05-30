using System;

namespace CharToIntConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a character: ");
            char charInput = Console.ReadKey().KeyChar;
            Console.WriteLine();  // Move to the next line after character input

            // Casting char to int to get ASCII code
            int asciiCode = (int)charInput;

            Console.WriteLine($"The character you entered is '{charInput}', its ASCII code is {asciiCode}");
        }
    }
}
