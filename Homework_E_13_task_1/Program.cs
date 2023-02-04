using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_13_task_2
{
    class Program
    {
        static Random randomPosition = new Random();

        static ConsoleColor basecolor = ConsoleColor.DarkGreen;
        static ConsoleColor greencolor = ConsoleColor.Green;
        static ConsoleColor fadedcolor = ConsoleColor.White;

        static void Main()
        {

            Console.ForegroundColor = basecolor;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;

            int whidth, height;
            int[] y;
            Initialize(out whidth, out height, out y);

            while (true)
            {
                ColumnUpdate(whidth, height, y);
            }
        }

        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();

            for (int x = 0; x < width; ++x)
            {
                y[x] = randomPosition.Next(height);
            }
        }

        static char Asciicharacters
        {
            get
            {
                int t = randomPosition.Next(10);

                if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)('a' + randomPosition.Next(27));
                else if (t <= 6) return (char)('A' + randomPosition.Next(27));
                else return (char)(randomPosition.Next(32, 255));

            }
        }

        public static int YPositionFields(int yPosition, int height)
        {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;

        }

        private static void ColumnUpdate(int width, int height, int[] y)
        {



            for (int x = 0; x < width; ++x)
            {
                if (x % 10 == 1) Console.ForegroundColor = fadedcolor;
                else Console.ForegroundColor = basecolor;

                Console.SetCursorPosition(x, y[x]);
                Console.Write(Asciicharacters);

                if (x % 10 == 9) Console.ForegroundColor = fadedcolor;
                else Console.ForegroundColor = basecolor;

                int temp = y[x] - 2;
                Console.SetCursorPosition(x, YPositionFields(temp, height));
                Console.Write(Asciicharacters);

                int temp1 = y[x] - 20;
                Console.SetCursorPosition(x, YPositionFields(temp1, height));
                Console.Write(' ');
                y[x] = YPositionFields(y[x] + 1, height);
            }
        }
    }
}