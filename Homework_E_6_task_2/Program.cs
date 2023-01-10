namespace Homework_E_6_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notes = new Book.Notes("My note");

            notes.PrintNote();
        }

        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Пошук рядка : " + str);
            }

            public class Notes
            {
                string noteToAdd;
                string savedNotes;

                public Notes(string noteToAdd)
                {
                    this.noteToAdd = noteToAdd;
                    AddNote();
                }

                private void AddNote()
                {
                    savedNotes += noteToAdd + " ";
                }

                public void PrintNote()
                {
                    Console.WriteLine($"Youre note is: {savedNotes}");
                }
            }
        }
    }
}