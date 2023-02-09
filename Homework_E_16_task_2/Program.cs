namespace Homework_E_16_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House orginalHouse = new House(new NumberOfRooms(4), 60);
            House surfaceClone = (House)orginalHouse.Clone();
            House deepClone = orginalHouse.DeepClone();

            Console.WriteLine($"Original: Num of rooms - {orginalHouse.NumOfRooms.NumOfRooms}, Area - {orginalHouse.Area}");
            Console.WriteLine($"Surface: Num of rooms - {surfaceClone.NumOfRooms.NumOfRooms}, Area - {surfaceClone.Area}");
            Console.WriteLine($"Deep: Num of rooms - {deepClone.NumOfRooms.NumOfRooms}, Area - {deepClone.Area}");
            Console.WriteLine();

            deepClone.NumOfRooms.NumOfRooms = 2;
            deepClone.Area = 20;

            Console.WriteLine($"Original: Num of rooms - {orginalHouse.NumOfRooms.NumOfRooms}, Area - {orginalHouse.Area}");
            Console.WriteLine($"Deep: Num of rooms - {deepClone.NumOfRooms.NumOfRooms}, Area - {deepClone.Area}");
            Console.WriteLine();

            surfaceClone.NumOfRooms.NumOfRooms = 2;
            surfaceClone.Area = 20;

            Console.WriteLine($"Original: Num of rooms - {orginalHouse.NumOfRooms.NumOfRooms}, Area - {orginalHouse.Area}");
            Console.WriteLine($"Surface: Num of rooms - {surfaceClone.NumOfRooms.NumOfRooms}, Area - {surfaceClone.Area}");
        }
    }

    class House : ICloneable
    {
        NumberOfRooms numOfRooms;
        double area;

        public House(NumberOfRooms numOfRooms, double area) 
        {
            this.numOfRooms = numOfRooms;
            this.area = area;
        }
        public NumberOfRooms NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public object Clone() => MemberwiseClone();

        public House DeepClone() => new House(new NumberOfRooms(numOfRooms.NumOfRooms), Area);
    }

    class NumberOfRooms
    {
        int numOfRooms;

        public NumberOfRooms(int numOfRooms)
        {
            this.numOfRooms = numOfRooms;
        }
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }
    }
}