using System;

namespace Homework_E_1_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSides = ChooseFigure();

            if (numSides == 3) 
            { 
                Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint());
                Console.WriteLine("Youre figure is triangle");
                figure.Show();
            }

            else if (numSides == 4) 
            { 
                Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint(), CreatePoint());
                Console.WriteLine("Youre figure is quadrangle");
                figure.Show();
            }

            else if (numSides == 5)
            { 
                Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint(), CreatePoint(), CreatePoint());
                Console.WriteLine("Youre figure is pentagon");
                figure.Show();
            }
            else
            {
                Figure figure = new Figure(CreatePoint(), CreatePoint(), CreatePoint());
                Console.WriteLine("Number of points enetred was too low or too big \n" +
                    "Youre figure set to triangle");
                figure.Show();
            }
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
            Console.Write("Enter number of points you are ready to enter: ");
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
