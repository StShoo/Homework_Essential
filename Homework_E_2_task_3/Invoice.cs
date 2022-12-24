using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_2_task_3
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;

        string article;
        int quantity;
        double vatRate;

        double costWithVAT;
        double costWithoutVAT;


        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalculateCost()
        {
            if (article.Equals("Books"))
            {
                costWithoutVAT = 100 * quantity;
                costWithVAT = costWithoutVAT + (costWithoutVAT * vatRate);
            } else if (article.Equals("Bags"))
            {
                costWithoutVAT = 70 * quantity;
                costWithVAT = costWithoutVAT + (costWithoutVAT * vatRate);
            } else if (article.Equals("T-shirts"))
            {
                costWithoutVAT = 150 * quantity;
                costWithVAT = costWithoutVAT + (costWithoutVAT * vatRate);
            }
            else { Console.WriteLine("We don`t have such product"); }
        }

        public double CostWithVAT
        {
            get
            {
                return costWithVAT;
            }
        }

        public double CostWithoutVAT
        {
            get
            {
                return costWithoutVAT;
            }
        }

        public string Article
        {
            set
            {
                article = value;
            }
        }

        public int Quantity
        {
            set
            {
                quantity = value;
            }
        }

        public double VatRate
        {
            set
            {
                vatRate = value;
            }
        }
    }
}
