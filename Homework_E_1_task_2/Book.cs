using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_2
{
    class Book
    {
        public Book(string bookTitle, string bookContent, string bookAuthor)
        {
            Title title = new Title()
            {
                BookTitle = bookTitle
            };
            Content content = new Content()
            {
                BookContent = bookContent
            };
            Author author = new Author()
            {
                BookAuthor = bookAuthor
            };

            title.Show();
            author.Show();
            content.Show();
        }
    }
}
