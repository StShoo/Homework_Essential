namespace Homework_E_17_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            var a = 12.0;
            var b = 16.0;

            Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calc.Sub(a, b)}");
            Console.WriteLine($"{a} * {b} = {calc.Mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {calc.Div(a, b)}");
        }
    }

    class Calculator
    {
        public dynamic Add(dynamic obj1, dynamic obj2)
        {
            return obj1 + obj2;
        }
        public dynamic Sub(dynamic obj1, dynamic obj2)
        {
            return obj1 - obj2;
        }
        public dynamic Mul(dynamic obj1, dynamic obj2)
        {
            return obj1 * obj2;
        }
        public dynamic? Div(dynamic obj1, dynamic obj2)
        {
            if(obj2 != 0)
            {
                return obj1 / obj2;
            }
            else
            {
                Console.WriteLine("Second value is 0. Result set to null.");
                return null;
            }
        }
    }
}