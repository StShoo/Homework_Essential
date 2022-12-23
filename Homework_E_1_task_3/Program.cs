using System;

namespace Homework_E_1_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numSides = ChooseFigure();
            switch (numSides)
            {
                case 3:
                    Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint());
                default:
                    Console.WriteLine("Error");
            }*/

            Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint());
            figure.Show();
        }

        private static Point CreatePoint()
        {
            Console.Write("Enter X cordinat: ");
            int firstCordinat = ReadValue();

            Console.Write("Enter Y cordinat: ");
            int secondCordinat = ReadValue();

            Console.Write("Enter point name: ");
            string pointName = Console.ReadLine();

            Point point = new Point(firstCordinat, secondCordinat, pointName);

            return point;
        }

        private static int ChooseFigure()
        {
            Console.Write("Enter number of sides of the figure: ");
            return ReadValue();
        }

        private static int ReadValue()
        {
            do
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only int values");
                }
            } while (true);
        }
    }
}
