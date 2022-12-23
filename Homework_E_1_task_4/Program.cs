using System;

namespace Homework_E_1_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintAdress(WriteAdress());
        }

        private static Adress WriteAdress()
        {
            Adress adress = new Adress()
            {
                Index = Console.ReadLine(),
                Country = Console.ReadLine(),
                City = Console.ReadLine(),
                Street = Console.ReadLine(),
                House = Console.ReadLine(),
                Apartment = Console.ReadLine()
            };

            return adress;
        }

        private static void PrintAdress(Adress adress)
        {
            Console.WriteLine("" +
                $"Index: {adress.Index}\n" +
                $"Country: {adress.Country}\n" +
                $"City: {adress.City}\n" +
                $"Street: {adress.Street}\n" +
                $"House: {adress.House}\n" +
                $"Apartment: {adress.Apartment}\n");
        }
    }
}
