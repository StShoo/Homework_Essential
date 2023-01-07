namespace Homework_E_5_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter matrix size: ");
            MyMatrix firstMatrix = new MyMatrix(ReadValue(), ReadValue());

            Console.WriteLine("Youre matrix: ");
            firstMatrix.PrintMatrix();

            Console.WriteLine("Do you want to change it? (Y/N)");
            string answer = Console.ReadLine();

            if (answer.Equals("Y"))
            {
                MyMatrix secondMatrix = new MyMatrix(ReadValue(), ReadValue());
                Console.WriteLine("Youre final matrix is: ");
                secondMatrix.PrintMatrix();
            }
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