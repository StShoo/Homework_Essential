using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_2
{
    class Content
    {
        private string bookContent;
        public string BookContent
        {
            set
            {
                bookContent = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Book Title: {bookContent}");
        }
    }
}
