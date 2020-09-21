using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, result;
            string myNumber;
            result = 1;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                myNumber = Console.ReadLine();
                a = numberAsInt(myNumber);
                result = result * a;
            }
            Console.WriteLine($"Result is: {result}");

        }
        static int numberAsInt(string myNumber)
        {
            int numberAsInt;
            int.TryParse(myNumber, out numberAsInt);
            return numberAsInt;
        }
    }
}
