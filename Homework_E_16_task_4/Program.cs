namespace Homework_E_16_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(10, -2, 4);
            Point3D point2 = new Point3D(13, 40, -10);

            Point3D resultPoint = point1 + point2;

            Console.WriteLine($"Result point - X: {resultPoint.X}, Y: {resultPoint.Y}, Z: {resultPoint.Z}");
        }

        struct Point3D
        {
            public int X;
            public int Y;
            public int Z;

            public Point3D(int X, int Y, int Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            public static Point3D operator +(Point3D p1, Point3D p2)
            {
                return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
            }
        }
    }
}