namespace Homework_E_11_task_5
{
    class MyClass<T> where T: new()
    {
        T instance = new T();
        public T FacrotyMethod()
        {
            return instance;
        }
    }
    class NewClass{ }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<NewClass> inst= new MyClass<NewClass>();
        }
    }
}