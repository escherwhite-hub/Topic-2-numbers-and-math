using System.Diagnostics.CodeAnalysis;

namespace Topic__2_numbers_and_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I will now count my chickens");
            Console.WriteLine("Hens " + (10 + 5 * 2));
            Console.WriteLine("Roosters " + (25 + 30 / 6));
            Console.WriteLine("Six" + 6);
            Console.WriteLine("6 + 6");
            Console.WriteLine("6" + 6);
            Console.WriteLine(6 + 6);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now i will count the eggs");
            Console.WriteLine(11.0 / 2);
            Console.WriteLine();
            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);
            Console.WriteLine("What is 3 + 2? " + (3 + 2));
            Console.WriteLine("What is 5 - 7? " + (5 - 7));
            Console.WriteLine("Oh, that's why it's " + (3 + 2 < 5 - 7));
        }
    }
}
