using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_1_task_3
{
    class Figure
    {
        private Point firstPoint;
        private Point secondPoint;
        private Point thirdPoint;
        private Point fourthPoint;
        private Point fifthPoint;

        public Figure(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
        }

        private double LengthSide(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.FirstCordinat - firstPoint.FirstCordinat, 2)
                + Math.Pow(secondPoint.SecondCordinat - firstPoint.SecondCordinat, 2));
        }

        private void PrintPointsNames(Point firstPoint, Point secondPoint)
        {
            Console.Write($"Distanse between {firstPoint.PointName} and {secondPoint.PointName} is: ");
        }

        public void Show()
        {
            PrintPointsNames(firstPoint, secondPoint);
            Console.WriteLine(LengthSide(firstPoint, secondPoint));
        }
    }
}
