using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_2
{
    class Title
    {
        private string bookTitle;

        public string BookTitle 
        {
            set
            {
                bookTitle = value;
            } 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Book Title: {bookTitle}");
        }
    }
}
