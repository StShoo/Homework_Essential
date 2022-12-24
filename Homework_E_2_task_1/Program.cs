using System;

namespace Homework_E_2_task_1
{
    class Program
    {
        const double uahToUsd = 0.027;
        const double uahToEur = 0.025;
        const double uahToRub = 1.9;

        const double usdToUah = 36.92;
        const double eurToUah = 39.39;
        const double rubToUah = 0.53;
        static void Main(string[] args)
        {
            double result = ConvertMoney(ChooseOpperation(), CheckCurrency(), EnterMoneyToConvert());

            Console.WriteLine($"Amount of money you get is: {result}");
        }

        private static double EnterMoneyToConvert()
        {
            double moneyToConvert;

            do
            {
                Console.WriteLine("Please enter amount of money you want to convert: ");
                moneyToConvert = ReadValue();

                if (IfValueMoreThanZero(moneyToConvert))
                {
                    return moneyToConvert;
                }

                Console.WriteLine("Amount of money should be more than zero");

            } while (true);

        }

        private static Converter ChooseOpperation()
        {
            do
            {
                Console.WriteLine("Please chouse an operation:\n" +
                    "Convert from UAH to USD/EUR/RUB - enter \"1\"\n" +
                    "Convert from USD/EUR/RUB to UAH - enter \"2\"");

                string operationName = Console.ReadLine();

                if (operationName.Equals("1"))
                {
                    Converter converter = new Converter(uahToUsd, uahToEur, uahToRub);
                    return converter;
                }
                else if (operationName.Equals("2"))
                {
                    Converter converter = new Converter(usdToUah, eurToUah, rubToUah);
                    return converter;
                }
                else
                {
                    Console.WriteLine("Sorry we can`t perform this opperation");
                }
            } while (true);
        }

        private static double ConvertMoney(Converter converter, string currency, double moneyToConvert)
        {
            double result = 0;

            if (currency.Equals("USD"))
            {
                result = moneyToConvert * converter.Usd;
            } else if (currency.Equals("EUR"))
            {
                result = moneyToConvert * converter.Eur;
            } else if (currency.Equals("RUB"))
            {
                result = moneyToConvert * converter.Rub;
            }
            return result;
        }

        private static string CheckCurrency()
        {
            string currency;

            do
            {
                Console.Write("Choose youre currency(USD/EUR/RUB): ");
                currency = Console.ReadLine();
                if(currency.Equals("USD") || currency.Equals("EUR") || currency.Equals("RUB")) { return currency; }
                Console.WriteLine("Sorry we don`t know such currency. Please choose between USD/EUR/RUB");
            } while (true);

        }

        private static double ReadValue()
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

        private static bool IfValueMoreThanZero(double value)
        {
            return value > 0;
        }
    }
}
