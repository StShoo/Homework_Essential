namespace Homework_E_8_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter position of worker: ");
            Post worker = Enum.Parse<Post>(Console.ReadLine());
            Console.WriteLine("Please enter how many hours did he/she worked: ");
            int hours = ReadIntValue();

            Accountant accountant = new Accountant();
            Console.WriteLine(accountant.AskForBonus(worker, hours));
        }

        private static int ReadIntValue()
        {
            do
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only int values");
                }
            } while (true);
        }
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if((int)worker < hours){ return true;}
            else { return false; }
        }
    }

    enum Post: int
    {
        None = 0,
        QA = 90,
        Programer = 105,
        TeamLead = 120
    }
}