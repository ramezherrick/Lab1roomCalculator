using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!\n\n");

            while (cont == "y")
            {
               

                Console.Write("\nEnter length:");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width:");
                double width = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);

                Console.WriteLine("Area:" + area);
                Console.WriteLine("perimeter:" + perimeter+"\n");

                Console.Write("continue? (y/n)");
                cont = Console.ReadLine();
            }

        }
    }
}
