namespace Homework_E_16_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(23, 12, 2023);
            Date d2 = new Date(15, 10, 2001);

            Date addDate = d1 + d2;
            Date subDate = d1 - d2;

            Console.WriteLine($"Added days: Days - {addDate.Day}, Monthes - {addDate.Month}, Years - {addDate.Year}");
            Console.WriteLine($"Subed days: Days - {subDate.Day}, Monthes - {subDate.Month}, Years - {subDate.Year}");
        }
    }

    class Date
    {
        int day;
        int month;
        int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day { get { return day; } set {day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }

        public static Date operator -(Date d1, Date d2)
        {
            return new Date(d1.Day - d2.Day, d1.Month - d2.Month, d1.Year - d2.Year);
        }
        public static Date operator +(Date d1, Date d2)
        {
            return new Date(d1.Day + d2.Day, d1.Month + d2.Month, d1.Year + d2.Year);
        }
    }
}