using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_3_task_2
{
    abstract class Vehicle
    {
        public int courdinats, numOfPassengers, speed;

        public abstract void PrintInfo();
    }

    class Plane: Vehicle
    {
        const int planeHigh = 2400;
        const int planePassengersNum = 200;
        public override void PrintInfo()
        {
            courdinats = planeHigh;
            numOfPassengers = planePassengersNum;

            Console.WriteLine($"\nPlane data:\n" +
                $"High: {courdinats}\n" +
                $"Number of Passangers: {numOfPassengers}");
        }
    }

    class Car: Vehicle
    {
        const int carSpeed = 2400;
        const int maxCarPassengers = 200;
        public override void PrintInfo()
        {
            speed = carSpeed;
            numOfPassengers = maxCarPassengers;

            Console.WriteLine($"\nCar data:\n" +
                $"Speed: {speed}\n" +
                $"Number of Passangers: {numOfPassengers}");
        }
    }

    class Ship : Vehicle
    {
        const int docCordinats = 142;
        const int shipPassengers = 200;
        public override void PrintInfo()
        {
            courdinats = docCordinats;
            numOfPassengers = shipPassengers;

            Console.WriteLine($"\nShip data:\n" +
                $"Doc courdinats: {courdinats}\n" +
                $"Number of Passangers: {numOfPassengers}");
        }
    }
}
