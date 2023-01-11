namespace Homework_E_7_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не змінено";
            myStruct.change = "не змінено";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine($"Class result: {myClass.change}\n" +
                $"Sructure result: {myStruct.change}");
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "змінено";
        }
    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
}