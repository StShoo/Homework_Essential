using NewNamespace;

namespace Homework_E_18_task_2
{
    internal class Program: MyClass
    {
        static void Main(string[] args)
        {
            MyClass myClass= new MyClass();
            myClass.MyMethod();
        }
    }
}

namespace NewNamespace
{
    class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("My method from my class from NewNamespace");
        }
    }
}