using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string radiusAsString;
            double radius, perimeterOrArea;
            
            Console.WriteLine("Enter radius: ");
            radiusAsString = Console.ReadLine();
            radius = Radius(radiusAsString);

            perimeterOrArea = 2 * Math.PI * radius;
            Console.WriteLine($"The perimeter of the circle is: {perimeterOrArea}");

            perimeterOrArea = Math.Pow(radius,2) * Math.PI;
            Console.WriteLine($"The area of the circle is: {perimeterOrArea}");
        }
        static double Radius(string radiusAsString)
        {
            double radius;
            double.TryParse(radiusAsString, out radius);
            return radius;
        }
    }
}
