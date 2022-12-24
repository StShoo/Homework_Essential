using System;

namespace Homework_E_2_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter login: ");
            string account = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter youre age: ");
            int age = ReadIntValue();
            Console.Write("Enter date of registration: ");
            string dateOfRegistration = Console.ReadLine();

            User userData = new User(account, name, surname, age, dateOfRegistration);

            Console.WriteLine("User Data:\n" +
                $"Login: {userData.Login}\n" +
                $"Name: {userData.Name}\n" +
                $"Surname: {userData.Surname}\n" +
                $"Age: {userData.Age}\n" +
                $"Date of registration: {userData.DateOfRegistration}");
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
    }
}
