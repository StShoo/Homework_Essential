using System;

namespace Homework_E_2_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of the employee: ");
            string name = Console.ReadLine();
            Console.Write("Enter surename of the employee: ");
            string surname = Console.ReadLine();
            Console.Write("Enter position of the employee: ");
            string position = Console.ReadLine();
            Console.Write("Enter experience of the employee: ");
            double experience = ReadValue();
            Console.Write("Enter tax rate in youre country: ");
            double taxRate = ReadValue();


            Employee employee = new Employee(name, surname)
            {
                Position = position,
                Experience = experience,
                TaxRate = taxRate
            };

            employee.CountEmployeeSalary();
            Console.WriteLine("Employee Data:\n" +
                $"Name: {employee.EmployeeName}\n" +
                $"Surname: {employee.EmployeeSurname}\n" +
                $"Position: {employee.Position}\n" +
                $"Salary: {employee.Payment}\n" +
                $"Tax: {employee.TaxPayment}");
            
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

    }
}
