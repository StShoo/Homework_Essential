using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_2_task_2
{
    class Employee
    {
        private string employeeSurname, employeeName, position;
        private double taxRate, experience;
        private double payment, taxPayment;


        public Employee(string employeeSurname, string employeeName)
        {
            this.employeeSurname = employeeSurname;
            this.employeeName = employeeName;
        }

        public void CountEmployeeSalary()
        {
            CountPayment();
            CountTaxPayment();
        }

        public double TaxPayment
        {
            get
            {
                return taxPayment;
            }
        }

        public double Payment
        {
            get
            {
                return payment;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName; 
            }
        }

        public string EmployeeSurname
        {
            get
            {
                return employeeSurname;
            }
        }

        private void CountTaxPayment()
        {
            taxPayment = payment * taxRate;
        }

        private void CountPayment()
        {
            if (position.Equals("Boss"))
            {
                payment = 6000 + (experience*100);
            } 
            else if (position.Equals("Programmer"))
            {
                payment = 4000 + (experience * 100);
            }
            else if (position.Equals("HR"))
            {
                payment = 2000 + (experience * 100);
            }
            else if (position.Equals("QA"))
            {
                payment = 1500 + (experience * 100);
            }
            else { Console.WriteLine("No such position exists"); }
        }

        public double TaxRate
        {
            set
            {
                taxRate = value;
            }
        }

        public double Experience
        {
            set
            {
                experience = value;
            }
        }

        public string Position
        {
            set
            {
                position = value;
            }
            get
            {
                return position;
            }
        }

    }
}
