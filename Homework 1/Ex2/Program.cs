using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber, greatestNumber;
            string myNumber;
            greatestNumber = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Introduce number {i}:");
                myNumber = Console.ReadLine();
                lastNumber = numberAsInt(myNumber);
                if (i == 1)
                {
                    greatestNumber = lastNumber;
                }
                if (lastNumber > greatestNumber)
                {
                    greatestNumber = lastNumber;
                }

            }
            Console.WriteLine($"The greatest number is: {greatestNumber}");


        }
        static int numberAsInt(string myNumber)
        {
            int numberAsInt;
            int.TryParse(myNumber, out numberAsInt);
            return numberAsInt;
        }

    }
}
