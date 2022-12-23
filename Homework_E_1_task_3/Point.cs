using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_3
{
    class Point
    {
        private int firstCordinat;
        private int secondCordinat;
        private string pointName;

        public int FirstCordinat 
        {
            get
            {
                return firstCordinat;
            }
        }

        public int SecondCordinat
        {
            get
            {
                return secondCordinat;
            }
        }
        public string PointName
        {
            get
            {
                return pointName;
            }
        }

        public Point(int firstCordinat, int secondCordinat, string pointName)
        {
            this.firstCordinat = firstCordinat;
            this.secondCordinat = secondCordinat;
            this.pointName = pointName;
        }
    }
}
