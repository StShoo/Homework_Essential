namespace Homework_E_6_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.MakeAnOperation();
        }
    }

    static class Calculator
    {
        public static void MakeAnOperation()
        {
            Console.WriteLine("First number");
            int firstValue = ReadIntValue();
            Console.WriteLine("Second number");
            int secondValue = ReadIntValue();
            Console.WriteLine("Choose an operation");
            Console.Write("Please enter an operation sign: ");
            char sign = CheckSign();

            switch (sign)
            {
                case '+':
                    PrintResult(Add(firstValue, secondValue), firstValue, secondValue, sign);
                    break;
                case '-':
                    PrintResult(Sub(firstValue, secondValue), firstValue, secondValue, sign);
                    break;
                case '*':
                    PrintResult(Mul(firstValue, secondValue), firstValue, secondValue, sign);
                    break;
                case '/':
                    if (IsSecondValueZero(secondValue))
                    {
                        Console.WriteLine("secondValue is equal to 0, can`t perform the operation");
                    }
                    else
                    {
                        PrintResult(Div(firstValue, secondValue), firstValue, secondValue, sign);
                    }
                    break;
                default:
                    Console.WriteLine("Error is occured, answer is set to 0");
                    break;
            }
        }

        private static int Add(int firstValue, int secondValue)
        {
            int result = firstValue + secondValue;
            return result;
        }

        private static int Sub(int firstValue, int secondValue)
        {
            int result = firstValue - secondValue;
            return result;
        }

        private static int Mul(int firstValue, int secondValue)
        {
            int result = firstValue * secondValue;
            return result;
        }

        private static double Div(int firstValue, int secondValue)
        {
            double result = Convert.ToDouble(firstValue) / Convert.ToDouble(secondValue);
            return result;
        }

        private static bool IsSecondValueZero(int secondValue)
        {
            bool isSecondValueZero = secondValue == 0;
            return isSecondValueZero;
        }

        private static void PrintResult(double result, int firstValue, int secondValue, char sign)
        {
            Console.WriteLine($"Your answer is: {firstValue} {sign} {secondValue} = {result}");
        }

        private static int ReadIntValue()
        {
            do
            {
                Console.Write("Please enter int number: ");
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

        private static char ReadSign()
        {
            do
            {
                try
                {
                    var sign = Convert.ToChar(Console.ReadLine() ?? string.Empty);
                    return sign;
                }
                catch
                {
                    Console.WriteLine("Please enter only available sign");
                }

            } while (true);
        }

        private static char CheckSign()
        {
            do
            {
                char sign = ReadSign();
                if (sign is '+' or '-' or '/' or '*')
                {
                    return sign;
                }
                Console.WriteLine("Please enter only available sign: +, -, *, /");
            } while (true);
        }
    }
}