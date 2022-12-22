using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_2
{
    class Author
    {
        private string bookAuthor;

        public string BookAuthor
        {
            set
            {
                bookAuthor = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Book Title: {bookAuthor}");
        }
    }
}
