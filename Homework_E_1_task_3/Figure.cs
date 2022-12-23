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

        public Figure()
        {

        }

        public Figure(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
        }

        public Figure(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
            this.fourthPoint = fourthPoint;
        }

        public Figure(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint, Point fifthPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
            this.fourthPoint = fourthPoint;
            this.fifthPoint = fifthPoint;
        }

        private double LengthSide(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Convert.ToDouble(Math.Pow(secondPoint.FirstCordinat - firstPoint.FirstCordinat, 2)
                + Math.Pow(secondPoint.SecondCordinat - firstPoint.SecondCordinat, 2)));
        }

        private void PrintPointsNames(Point firstPoint, Point secondPoint)
        {
            Console.Write($"Distanse between {firstPoint.PointName} and {secondPoint.PointName} is: ");
        }


        private double PerimeterCalculator(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint, Point fifthPoint)
        {
            double perimeter;
            if (fourthPoint == null)
            {
                perimeter = LengthSide(firstPoint, secondPoint) + LengthSide(secondPoint, thirdPoint) + LengthSide(thirdPoint, firstPoint);
            } 
            else if (fifthPoint == null) 
            {
                perimeter = LengthSide(firstPoint, secondPoint) + LengthSide(secondPoint, thirdPoint) + LengthSide(thirdPoint, fourthPoint) +
                    LengthSide(fourthPoint, firstPoint);
            }
            else
            {
                perimeter = LengthSide(firstPoint, secondPoint) + LengthSide(secondPoint, thirdPoint) + LengthSide(thirdPoint, fourthPoint) + 
                    LengthSide(fourthPoint, fifthPoint) + LengthSide(fifthPoint, firstPoint);
            }
           
            return perimeter;
        }

        public void Show()
        {
            Console.WriteLine($"Youre perimeter is {PerimeterCalculator(firstPoint, secondPoint, thirdPoint, fourthPoint, fifthPoint)}");
        }
    }
}
