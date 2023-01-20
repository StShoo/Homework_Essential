namespace Homework_E_9_task_1
{

    public delegate double CalculateDelegat(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateDelegat calculateDelegat;

            Console.Write("Please enter a sign of an operation you want to perform (+, -, *, /): ");
            string sign = Console.ReadLine();
            double result;

            Console.Write("Please enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            {
                case "+":
                    calculateDelegat = (a, b) => { return a + b; };
                    result = calculateDelegat(firstNumber, secondNumber);
                    break;
                case "-":
                    calculateDelegat = (a, b) => { return a - b; };
                    result = calculateDelegat(firstNumber, secondNumber);
                    break;
                case "*":
                    calculateDelegat = (a, b) => { return a * b; };
                    result = calculateDelegat(firstNumber, secondNumber);
                    break;
                case "/":
                    calculateDelegat = (a, b) => { if (b == 0) { Console.WriteLine("Can not perfome an operation dew to second value.\nResult set to 0.");
                            return 0; } else { return a / b; } };
                    result = calculateDelegat(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Can not perfome an operation dew to the wrong sign.\nResult set to 0.");
                    result = 0;
                    break;
            }

            Console.WriteLine($"Result is {result}");

        }

    }
}