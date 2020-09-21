using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output");
            Console.WriteLine("fizzbuzz");
            for(int i=1;i<=50;i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("fizz");
                }
                if(i%5==0)
                {
                    Console.WriteLine("buzz");
                }
                if(i%5==0 & i%3==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if(!(i%3==0) & !(i % 5 == 0))
                {
                    Console.WriteLine(i);
                }

                    
            }
        }
    }
}
