using System;
using System.Linq;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOf5Ints = new int[5];
            
            Console.WriteLine("Please introduce 5 numbers: ");
            for(int i=0;i<=4;i++)
            {
                arrayOf5Ints[i] = valueOfString();
            }
            int maxValue = arrayOf5Ints.Max();
            Console.WriteLine("The maximum of the 5 integers is: " + maxValue);
        }
        static int valueOfString()
        {
            string intAsString = Console.ReadLine();
            int value;
            int.TryParse(intAsString, out value);
            return value;
        }
    }
}
