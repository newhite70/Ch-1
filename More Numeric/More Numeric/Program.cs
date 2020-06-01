using System;

namespace More_Numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            int gallons;
            string miles_input;
            string gallons_input;


            Console.WriteLine("How many miles have you driven:");
            miles_input = Console.ReadLine();
            miles = int.Parse(miles_input);
            Console.WriteLine("How many gallons of fuel have you used:");
            gallons_input = Console.ReadLine();
            gallons = int.Parse(gallons_input);
            int mph = (miles / gallons);
            Console.WriteLine(mph);
        }
    }
}
