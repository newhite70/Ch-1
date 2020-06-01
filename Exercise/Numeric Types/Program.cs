using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int length;
            string length_input;
            string width_input;
            

            Console.WriteLine("Please provide the length of the rectangle:");
            length_input = Console.ReadLine();
            length = int.Parse(length_input);
            Console.WriteLine("Please provide the width of the rectangle:");
            width_input = Console.ReadLine();
            width = int.Parse(width_input);
            int area = (width * length);
            Console.WriteLine(area);
        }
    }
}
