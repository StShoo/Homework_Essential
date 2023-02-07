namespace Homework_E_15_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Worker[] workers = new Worker[n];
            bool isIntFlag = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please name and surname of {i + 1} worker: ");
                workers[i].NameSurname = Console.ReadLine();
                Console.Write($"Please position of {i + 1} worker: ");
                workers[i].Position = Console.ReadLine();
                do
                {
                    Console.Write($"Please year of start of {i + 1} worker: ");
                    try
                    {
                        workers[i].YearOfStart = Convert.ToInt32(Console.ReadLine());
                        isIntFlag = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Input exeption. Try again");
                        isIntFlag = false;
                    }
                } while (!isIntFlag);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Name of {i + 1} worker: {workers[i].NameSurname}");
                Console.WriteLine($"position of {i + 1} worker: {workers[i].Position}");
                Console.WriteLine($"Year of start of {i + 1} worker: {workers[i].YearOfStart}");
                Console.WriteLine();
            }
        }
    }

    struct Worker
    {
        public string NameSurname { get; set; }
        public string Position { get; set; }
        public int YearOfStart { get; set; }
    }
}