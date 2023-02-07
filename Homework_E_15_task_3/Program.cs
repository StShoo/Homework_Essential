namespace Homework_E_15_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            char sign;

            Console.Write("Please enter first value: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second value: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter sign of operation: ");
            sign = Convert.ToChar(Console.ReadLine());

            Calculator calculator = new Calculator(a, b);
            calculator.Sign = sign;
            Console.WriteLine($"{a} {sign} {b} = {calculator.MakeCalculations()}");
        }
    }

    class Calculator
    {
        private double a;
        private double b;
        private char sign;
        private char[] avaliableSigns = {'+', '-', '*', '/'}; 

        public Calculator(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public char Sign
        {
            set { sign = value; }
        }

        public double MakeCalculations()
        {
            if (IfCharIsCorrect())
            {
                switch (sign)
                {
                    case'+':
                        return Add();
                        
                    case '-':
                        return Sub();
                        
                    case '*':
                        return Mul();
                        
                    case '/':
                        return Div();
                        
                    default:
                        throw new Exception("Exeption in switch case");
                }
            }
            else
            {
                Console.WriteLine("We dont know such sign. Result set to zero.");
                return 0;
            }
        }
        
        bool IfCharIsCorrect()
        {
            for (int i = 0; i < avaliableSigns.Length; i++)
            {
                if (avaliableSigns[i] == sign)
                {
                    return true;
                }
            }
            return false;
        }
        
        double Add()
        {
            return a + b;
        }

        double Sub()
        {
            return a - b;
        }

        double Mul()
        {
            return a * b;
        }

        double Div()
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException is noticed. Result set to zero.");
                return 0;
            }
        }
    }
}