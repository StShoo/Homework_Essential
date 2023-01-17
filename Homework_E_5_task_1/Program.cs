namespace Homework_E_5_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeCalculations results = new MakeCalculations(ReadArraySize());

            results.PrintCalculations();
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i+1} element is {arr[i]}");
            }
        }

        static int ReadArraySize()
        {
            Console.Write("Enter sice of an array: ");
            int n = ReadValue();
            return n;
        }

        static int ReadValue()
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
}