namespace Homework_E_8_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string you want to print: ");
            string textToPrint = Console.ReadLine();
            Console.WriteLine("Please enter colore: \n" +
                "Red = 1,\r\n" +
                "Green = 2,\r\n" +
                "Blue = 3,\r\n" +
                "Yellow = 4");
            int color = Console.ReadLine();
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