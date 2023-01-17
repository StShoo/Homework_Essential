namespace Homework_E_8_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }

    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
        }
    }

    enum EnumColors : int
    {
        Red = 1,
        Green = 2,
        Blue = 3,
        Yellow = 4
    }
}