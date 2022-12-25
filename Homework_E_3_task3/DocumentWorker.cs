using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_3_task3
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версії Про");
        }
    }

    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }

    class ExpertDocumentWorker: DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }

}
