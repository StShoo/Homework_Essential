using System;

namespace Homework_E_1_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(ReadBookTitle(), ReadBookContent(), ReadBookAuthor());
        }

        private static string ReadBookTitle()
        {
            Console.WriteLine("Please enter book title: ");
            string bookTitle = Console.ReadLine();
            return bookTitle;
        }

        private static string ReadBookContent()
        {
            Console.WriteLine("Please enter book content: ");
            string bookContent = Console.ReadLine();
            return bookContent;
        }

        private static string ReadBookAuthor()
        {
            Console.WriteLine("Please enter book author: ");
            string bookAuthor = Console.ReadLine();
            return bookAuthor;
        }
    }
}
