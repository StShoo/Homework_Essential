namespace Homework_E_9_task_3
{

    public delegate int MidValueDelegat(int a, int b, int c);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            MidValueDelegat midValueDelegat = delegate (int a, int b, int c) { return (a + b + c) / arr.Length; };
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"Enter {i+1} element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Youre middle value is {midValueDelegat.Invoke(arr[0], arr[1], arr[2])}");
        }
    }
}