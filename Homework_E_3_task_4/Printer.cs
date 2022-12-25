using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_3_task_4
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class ColoredPrinter: Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
