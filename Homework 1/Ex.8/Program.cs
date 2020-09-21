using System;

namespace Ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese introduce number N");
            string numberAsString = Console.ReadLine();
            int index;
            int.TryParse(numberAsString, out index);
            Console.WriteLine("The numbers from 1 to N, which are not divisible by 3 and 7 simultaneously are:");
            for (int i = 1; i <= index; i++)
            {
                if (i%3==0 & i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}