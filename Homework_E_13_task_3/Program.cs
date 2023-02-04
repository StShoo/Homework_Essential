namespace Homework_E_13_task_3
{
    internal class Program
    {
        static int counter = 10;
        static void Main(string[] args)
        {
            ThreadsCreator();
        }

        static void ThreadsCreator()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.GetHashCode()} was created");
            if(counter > 0)
            {
                counter--;
                Thread writeNext = new Thread(ThreadsCreator);
                writeNext.Start();
            }
        }
    }
}