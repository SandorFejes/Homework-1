using System;
using System.Threading;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert  first number: ");
            string numberAsString = Console.ReadLine();
            int numberA = numberAsInt(numberAsString);

            Console.WriteLine("Insert  second number: ");
            numberAsString = Console.ReadLine();
            int numberB = numberAsInt(numberAsString);
            if(numberA>numberB)
            {
                Console.WriteLine("The greatest number is: " + numberA);
            }
            if (numberB>numberA)
            {
                Console.WriteLine("The greatest number is: " + numberB);
            }
            if (numberA==numberB)
            {
                Console.WriteLine("The numbers are equal");
            }
            //Console.WriteLine("The greates number is: "+ Math.Max(numberA, numberB));
        }
        static int numberAsInt(string myNumber)
        {
            int numberAsInt;
            int.TryParse(myNumber, out numberAsInt);
            return numberAsInt;
        }
    }
}
