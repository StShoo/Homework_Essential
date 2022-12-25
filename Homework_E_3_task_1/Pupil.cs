using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_3_task_1
{
    abstract class Pupil
    {
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("The best ");
        }
        public override void Read()
        {
            Console.WriteLine("The best ");
        }
        public override void Write()
        {
            Console.WriteLine("The best ");
        }
        public override void Relax()
        {
            Console.WriteLine("The worst ");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good ");
        }
        public override void Read()
        {
            Console.WriteLine("Good ");
        }
        public override void Write()
        {
            Console.WriteLine("Good ");
        }
        public override void Relax()
        {
            Console.WriteLine("Good ");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("The worst ");
        }
        public override void Read()
        {
            Console.WriteLine("The worst ");
        }
        public override void Write()
        {
            Console.WriteLine("The worst ");
        }
        public override void Relax()
        {
            Console.WriteLine("The best ");
        }
    }

}
