using System;

namespace Homework_E_3_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane();
            Vehicle car = new Car();
            Vehicle ship = new Ship();

            plane.PrintInfo();
            car.PrintInfo();
            ship.PrintInfo();
        }
    }
}
