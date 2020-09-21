using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N: ");
            int numberN = readInteger();
            
            int[] ordonatedArray = new int[numberN];//reserv empty array with N elements          
            ordonatedArray = arrayFromOneToN(numberN);//creats an ordonated list from 1 to N

            int[] randArray = new int[numberN]; //reser empty array with N elements for randomized array
            randArray = randomizeArray(ordonatedArray);//cals randomize methode

            Console.WriteLine("The numbers from 1 to N in random order are: ");
            for (int i=0; i<numberN;i++) //print numbers from 1 to N in randomized order
            {
                Console.Write(" " + randArray[i]);
            }

        }
        static int[] randomizeArray(int[] ordonatedArray)
        {
            Random random = new Random();
            for (int i = ordonatedArray.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);
                int temp = ordonatedArray[i];
                ordonatedArray[i] = ordonatedArray[randomIndex];
                ordonatedArray[randomIndex] = temp;
            }
            return ordonatedArray;
        }
        static int[] arrayFromOneToN(int numberN)
        {
            int[] ordonatedArray = new int[numberN];
            for (int i = 0; i < numberN; i++)
            {
                ordonatedArray[i] = i;
            }
            return ordonatedArray;
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
