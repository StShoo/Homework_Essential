using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_2_task_1
{
    class Converter
    {
        private double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double Usd
        {
            get
            {
                return usd;
            }
        }

        public double Eur
        {
            get
            {
                return eur;
            }
        }

        public double Rub
        {
            get
            {
                return rub;
            }
        }
    }
}
