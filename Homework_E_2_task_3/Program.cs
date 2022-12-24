using System;

namespace Homework_E_2_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account: ");
            int account = ReadIntValue();
            Console.Write("Enter custumer: ");
            string custumer = Console.ReadLine();
            Console.Write("Enter provider: ");
            string provider = Console.ReadLine();
            Console.Write("Enter product name: ");
            string article = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = ReadIntValue();
            Console.Write("Enter VAT rate in youre country: ");
            double vatRate = ReadDoubleValue();

            Invoice invoice = new Invoice(account, custumer, provider)
            {
                Article = article,
                Quantity = quantity,
                VatRate = vatRate
            };

            invoice.CalculateCost();

            Console.WriteLine($"Cost without VAT is: {invoice.CostWithoutVAT}\n" +
                $"Cost including VAT is: {invoice.CostWithVAT}");
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

        private static double ReadDoubleValue()
        {
            do
            {
                try
                {
                    double number = Convert.ToDouble(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only double values");
                }
            } while (true);
        }

    }
}
