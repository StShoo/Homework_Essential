using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_4_task_1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open xml document");
        }
        public override void Create()
        {
            Console.WriteLine("Create xml document");
        }
        public override void Change()
        {
            Console.WriteLine("Change xml document");
        }
        public override void Save()
        {
            Console.WriteLine("Save xml document");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open txt document");
        }
        public override void Create()
        {
            Console.WriteLine("Create txt document");
        }
        public override void Change()
        {
            Console.WriteLine("Change txt document");
        }
        public override void Save()
        {
            Console.WriteLine("Save txt document");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open doc document");
        }
        public override void Create()
        {
            Console.WriteLine("Create doc document");
        }
        public override void Change()
        {
            Console.WriteLine("Change doc document");
        }
        public override void Save()
        {
            Console.WriteLine("Save doc document");
        }
    }
}
