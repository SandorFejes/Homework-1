using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB, min, max, counter=0;
            int[] myArray=new int[100];//used to store the "5mod" elements
            string numberAsString;

            Console.WriteLine("Insert  first number: ");
            numberAsString = Console.ReadLine();
            numberA = numberAsInt(numberAsString);

            Console.WriteLine("Insert  second number: ");
            numberAsString = Console.ReadLine();
            numberB = numberAsInt(numberAsString);

            min = Math.Min(numberA, numberB);
            max = Math.Max(numberA, numberB);
            
            while (min <= max)
            {
                if (min%5==0)
                {
                    myArray[counter] = min;
                    counter++;
                }
                min = min + 1;             
            }

            Console.WriteLine($"In the range of ({min}, {max}) there are {counter} such numbers:");
            printMyArray(myArray, counter);
        }

        static void printMyArray(int[] myArray, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write($" {myArray[i]}");
            }
        }
        static int numberAsInt(string number)
        {
            int numberAsInt;
            int.TryParse(number, out numberAsInt);
            return numberAsInt;
        }
    }
}
