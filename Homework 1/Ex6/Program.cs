using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, result;
            string myNumber;
            result = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                myNumber = Console.ReadLine();
                a = numberAsInt(myNumber);
                result = result + a;
            }
            Console.WriteLine($"Result is: {result}");

        }
        static int numberAsInt(string myNumber)
        {
            int numberAsInt;
            if (! int.TryParse(myNumber, out numberAsInt))
            {
                Console.WriteLine("Please integers only ");
            }
            int.TryParse(myNumber, out numberAsInt);
            return numberAsInt;
        }
    }
}