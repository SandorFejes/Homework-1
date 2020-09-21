using System;
using System.Data;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of stars on diagonal");
           
            int numberOfStars = readInteger();
            drawFirstHalf(numberOfStars);
            
        }
        static void drawFirstHalf(int numberOfStars)
        {
            string stars = ("*");
            string oneStar = ("*");
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.WriteLine(stars);
                stars = stars + oneStar;
                if(i==numberOfStars)
                {
                    stars = stars.Remove(numberOfStars, 1);
                }
            }
            
            while (numberOfStars >= 1)
            {
                stars = stars.Remove(numberOfStars-1, 1);
                Console.WriteLine(stars);
                numberOfStars = numberOfStars - 1;
            }

        }
        static int readInteger()
        {
            string integerAsString = Console.ReadLine();
            int numberOfStars;
            int.TryParse(integerAsString,out numberOfStars);
            return numberOfStars;
        }
    }
}
