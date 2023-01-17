namespace Homework_E_8_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youre Birthday date (Format: Month_Day): ");
            string birthdayString = Console.ReadLine();
            Array arrayOfBirthdays = Enum.GetValues(typeof(BirthdayDatesInJanuary));
            int indexOfBirthday = Array.IndexOf(arrayOfBirthdays, Enum.Parse<BirthdayDatesInJanuary>(birthdayString));

            BirthdayDatesInJanuary currentBirthday = Enum.Parse<BirthdayDatesInJanuary>(birthdayString);

            int daysDistance = (int)arrayOfBirthdays.GetValue(++indexOfBirthday) - (int)currentBirthday;
            Console.WriteLine($"Next Birthday in this month will be in {daysDistance} days");
        }
    }

    enum BirthdayDatesInJanuary: int
    {
        January_2 = 2, 
        January_10 = 10, 
        January_15 = 15,
        January_22 = 22,
        January_30 = 30
    }
}