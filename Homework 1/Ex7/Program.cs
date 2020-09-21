using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese introduce number N");
            string numberAsString = Console.ReadLine();
            int index;
            int.TryParse(numberAsString, out index);
            Console.WriteLine("The numbers from 1 to N are:");
            for (int i = 1; i <= index; i++)
            {
                if (i==1)
                { Console.Write(i);
                } else
                {
                    Console.Write(", " + i);
                }                
            }
            Console.ReadLine();
        }
    }
}
