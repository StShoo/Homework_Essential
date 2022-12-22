using System;

namespace Homework_E_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(InitialaseSide(), InitialaseSide());

            Console.WriteLine($"Area of the Rectangle is {rectangle.Area}");
            Console.WriteLine($"Perimeter of the Rectangle is {rectangle.Perimeter}");
        }

        private static double InitialaseSide()
        {
            double side;
            do
            {
                Console.Write("Please enter side of rectangle: ");
                side = ReadValue();

                if (!IfValueMoreThanZero(side))
                {
                    Console.WriteLine("Side should be more than zero");
                }

            } while (!IfValueMoreThanZero(side));

            return side;
        }

        private static double ReadValue()
        {
            do
            {
                try
                {
                    double number = Convert.ToDouble(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only double values");
                }
            } while (true);
        }

        private static bool IfValueMoreThanZero(double value)
        {
            return value > 0;
        }
    }
}
