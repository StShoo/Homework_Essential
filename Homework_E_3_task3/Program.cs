using System;

namespace Homework_E_3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key to activate Pro or Expert version (if you don`t have key enter \"skip\"): ");
            string key = CheckKey();

            if (key.Equals("Pro"))
            {
                DocumentWorker proWorker = new ProDocumentWorker();
                proWorker.OpenDocument();
                proWorker.EditDocument();
                proWorker.SaveDocument();
            } 
            else if (key.Equals("Expert"))
            {
                DocumentWorker expertWorker = new ExpertDocumentWorker();
                expertWorker.OpenDocument();
                expertWorker.EditDocument();
                expertWorker.SaveDocument();
            }
            else
            {
                DocumentWorker docWorker = new DocumentWorker();
                docWorker.OpenDocument();
                docWorker.EditDocument();
                docWorker.SaveDocument();
            }
            
        }

        private static string CheckKey(){ return Console.ReadLine(); }
    }
}
