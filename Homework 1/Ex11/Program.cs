using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce decimal to transform:");
            int number = readInteger();
            int restBy2;
            string result=string.Empty;
            while (number > 0)
            {
                restBy2 = number % 2;
                number = number / 2;
                result = result + restBy2;
            }
            Console.WriteLine("binary representation is: "+ result);

        }
        static int readInteger()
        {
            string integerAsString = Console.ReadLine();
            int decimalNumber;
            int.TryParse(integerAsString, out decimalNumber);
            return decimalNumber;
        }
    }
}
