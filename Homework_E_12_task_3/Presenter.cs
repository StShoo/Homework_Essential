using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_12_task_3
{
    internal class Presenter
    {
        double value1;
        double value2;

        public double Value1{get; set; }
        public double Value2 {get; set; }

        public Presenter(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public double Sum()
        {
            return value1 + value2;
        }
        public double Min()
        {
            return value1 - value2;
        }
        public double Mult()
        {
            return value1 * value2;
        }
        public double Div() 
        {
            return value1 / value2;
        }
    }
}
