using System;

namespace Homework_E_3_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to print: ");

            Printer coloredPrinter = new ColoredPrinter();
            coloredPrinter.Print(Console.ReadLine());

            Console.Write("Enter string to print: ");

            Printer regPrinter = new Printer();
            regPrinter.Print(Console.ReadLine());
        }
    }
}
